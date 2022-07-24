﻿using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Installer;
using CmlLib.Core.Files;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core.Downloader;
using CmlLib.Core.Version;
using MaterialSkin;
using MaterialSkin.Controls;
using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Auth.Microsoft.UI.WinForm;
using somsClient;
using MineStatLib;

namespace CmlLibWinFormSample
{
    public partial class MainForm : MaterialForm
    {
        public MainForm(MSession session)
        {
            this.session = session;
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        CMLauncher launcher;
        readonly MSession session;
        MinecraftPath gamePath; 
        string javaPath;

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            
            // Initialize launcher
            var defaultPath = new MinecraftPath(MinecraftPath.GetOSDefaultPath());
            await initializeLauncher(defaultPath);

            var computerMemory = Util.GetMemoryMb();
            if (computerMemory == null)
            {
                MessageBox.Show("Failed to get computer memory");
                return;
            }

            var max = computerMemory / 2;
            if (max < 1024)
                max = 1024;
            else if (max > 8192)
                max = 8192;

            var min = max / 5;

            TxtXmx.Text = max.ToString();
            txtXms.Text = min.ToString();

        }

        private async Task initializeLauncher(MinecraftPath path)
        {
            lbUsername.Text = session.Username;
            txtPath.Text = path.BasePath;
            this.gamePath = path;
            
            launcher = new CMLauncher(path);
            launcher.FileChanged += Launcher_FileChanged;
            launcher.ProgressChanged += Launcher_ProgressChanged;
            await refreshVersions(null);
        }

        private async void btnRefreshVersion_Click(object sender, EventArgs e)
        {
            await refreshVersions(null);
        }

        private async Task refreshVersions(string showVersion)
        {
            cbVersion.Items.Clear();

            var versions = await launcher.GetAllVersionsAsync();

            bool showVersionExist = false;
            foreach (var item in versions)
            {
                if (showVersion != null && item.Name == showVersion)
                    showVersionExist = true;
                cbVersion.Items.Add(item.Name);
            }

            if (showVersion == null || !showVersionExist)
                btnSetLastVersion_Click(null, null);
            else
                cbVersion.Text = showVersion;
        }

        private void btnSetLastVersion_Click(object sender, EventArgs e)
        {
            cbVersion.Text = launcher.Versions?.LatestReleaseVersion?.Name;
        }

        // Start Game
        private async void Launch_Click1(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("Login First");
                return;
            }

            if (cbVersion.Text == "")
            {
                MessageBox.Show("Select Version");
                return;
            }

            MineStat ms = new MineStat("soms.colebolebole.tk", 25565);

            if (ms.ServerUp)
            {
                setUIEnabled(false);
            }
            else
            {
                MessageBox.Show("The soms server cannot be reached! Please try again later.");
                setUIEnabled(true);
                return;
            }


                try
            {
                // create LaunchOption
                var launchOption = new MLaunchOption()
                {
                    MaximumRamMb = int.Parse(TxtXmx.Text),
                    Session = this.session,

                    GameLauncherName = "soms Client",
                    GameLauncherVersion = "2022.7.22",
                    VersionType = "soms",

                    ServerIp = "soms.colebolebole.tk",
                    ServerPort = 25565,

                };

                if (!string.IsNullOrEmpty(javaPath))
                    launchOption.JavaPath = javaPath;
                
                if (!string.IsNullOrEmpty(txtXms.Text))
                    launchOption.MinimumRamMb = int.Parse(txtXms.Text);

                if (!string.IsNullOrEmpty(Txt_JavaArgs.Text))
                    launchOption.JVMArguments = Txt_JavaArgs.Text.Split(' ');

                if (rbParallelDownload.Checked)
                {
                    System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                    launcher.FileDownloader = new AsyncParallelDownloader();
                }
                else
                    launcher.FileDownloader = new SequenceDownloader();

                if (cbSkipAssetsDownload.Checked)
                    launcher.GameFileCheckers.AssetFileChecker = null;
                else if (launcher.GameFileCheckers.AssetFileChecker == null)
                    launcher.GameFileCheckers.AssetFileChecker = new AssetChecker();
                
                // check file hash or don't check
                if (launcher.GameFileCheckers.AssetFileChecker != null)
                    launcher.GameFileCheckers.AssetFileChecker.CheckHash = !cbSkipHashCheck.Checked;
                if (launcher.GameFileCheckers.ClientFileChecker != null)
                    launcher.GameFileCheckers.ClientFileChecker.CheckHash = !cbSkipHashCheck.Checked;
                if (launcher.GameFileCheckers.LibraryFileChecker != null)
                    launcher.GameFileCheckers.LibraryFileChecker.CheckHash = !cbSkipHashCheck.Checked;

                var process = await launcher.CreateProcessAsync(cbVersion.Text, launchOption); // Create Arguments and Process

                process.Start();

                Application.Exit();

            }
            catch (FormatException fex) // int.Parse exception
            {
                MessageBox.Show("Failed to create MLaunchOption\n\n" + fex);
            }
            catch (MDownloadFileException mex) // download exception
            {
                MessageBox.Show(
                    $"FileName : {mex.ExceptionFile.Name}\n" +
                    $"FilePath : {mex.ExceptionFile.Path}\n" +
                    $"FileUrl : {mex.ExceptionFile.Url}\n" +
                    $"FileType : {mex.ExceptionFile.Type}\n\n" +
                    mex.ToString());
            }
            catch (Win32Exception wex) // java exception
            {
                MessageBox.Show(wex + "\n\nIt seems your java setting has problem");
            }
            catch (Exception ex) // all exception
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // enable ui
                setUIEnabled(true);
            }
        }
        
        private int uiThreadId = Thread.CurrentThread.ManagedThreadId;

        // Event Handler. Show download progress
        private void Launcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (Thread.CurrentThread.ManagedThreadId != uiThreadId)
            {
                Debug.WriteLine(e);
            }
            Pb_Progress.Maximum = 100;
            Pb_Progress.Value = e.ProgressPercentage;
        }

        private void Launcher_FileChanged(DownloadFileChangedEventArgs e)
        {
            if (Thread.CurrentThread.ManagedThreadId != uiThreadId)
            {
                Debug.WriteLine(e);
            }
            Pb_File.Maximum = e.TotalFileCount;
            Pb_File.Value = e.ProgressedFileCount;
            Lv_Status.Text = $"{e.FileKind} : {e.FileName} ({e.ProgressedFileCount}/{e.TotalFileCount})";
            //Debug.WriteLine(Lv_Status.Text);
        }

        private void btnChangeJava_Click(object sender, EventArgs e)
        {
            var form = new JavaForm(javaPath);
            form.ShowDialog();
            javaPath = form.JavaBinaryPath;
            
            if (string.IsNullOrEmpty(javaPath))
                lbJavaPath.Text = "Use default java";
            else
                lbJavaPath.Text = javaPath;
        }

        private void btnAutoRamSet_Click(object sender, EventArgs e)
        {
            var computerMemory = Util.GetMemoryMb();
            if (computerMemory == null)
            {
                MessageBox.Show("Failed to get computer memory");
                return;
            }

            var max = computerMemory / 2;
            if (max < 1024)
                max = 1024;
            else if (max > 8192)
                max = 8192;

            var min = max / 5;

            TxtXmx.Text = max.ToString();
            txtXms.Text = min.ToString();
        }

        private void setUIEnabled(bool value)
        {
            groupBox1.Enabled = value;
            groupBox2.Enabled = value;
            groupBox3.Enabled = value;
            groupBox4.Enabled = value;
        }

        private void StartProcess(Process process)
        {
            File.WriteAllText("launcher.txt", process.StartInfo.Arguments);
            
            // process options to display game log

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;
            process.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            process.EnableRaisingEvents = true;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
        }

        private static Task<MicrosoftLoginForm> CreateForm()
        {
            var loginHandler = new LoginHandler();
            MicrosoftLoginForm form = new MicrosoftLoginForm(loginHandler);

            //var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CmlLib.Core.Auth.Microsoft.UI.WinForm.TestApp");
            //form.WebView2Environment = await CoreWebView2Environment.CreateAsync(userDataFolder: dataPath);

            return Task.FromResult(form);
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            // Game Changelog
            var f = new ChangeLog();
            f.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // options.txt
            var path = System.IO.Path.Combine(gamePath.BasePath, "options.txt");
            var f = new GameOptions(path);
            f.Show();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            start("https://github.com/AlphaBs/CmlLib.Core");
        }

        private void btnWiki_Click(object sender, EventArgs e)
        {
            start("https://github.com/AlphaBs/CmlLib.Core/wiki/");
        }

        private void start(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string getLibraryVersion()
        {
            try
            {
                return Assembly.GetAssembly(typeof(CMLauncher)).GetName().Version.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        private async void logout_Click(object sender, EventArgs e)
        {
            MicrosoftLoginForm form = await CreateForm();
            form.ShowLogoutDialog(); // show logout form

            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, e) => this.Close();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // aboutform1
            var f = new AboutBox1();
            f.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtXms_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}