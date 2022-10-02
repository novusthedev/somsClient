using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Auth.Microsoft.UI.WinForm;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XboxAuthNet.OAuth;
using XboxAuthNet.XboxLive;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CmlLibWinFormSample
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.Blue200, TextShade.WHITE);


        }

        private void UpdateSession(MSession session)
        {
            // Success to login!

            var mainForm = new MainForm(session);
            mainForm.FormClosed += (s, e) => this.Close();
            mainForm.Show();
            this.Hide();
        }

        private static Task<MicrosoftLoginForm> CreateForm()
        {
            var loginHandler = new LoginHandler();
            MicrosoftLoginForm form = new MicrosoftLoginForm(loginHandler);

            //var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CmlLib.Core.Auth.Microsoft.UI.WinForm.TestApp");
            //form.WebView2Environment = await CoreWebView2Environment.CreateAsync(userDataFolder: dataPath);

            return Task.FromResult(form);
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {

            var form = await CreateForm();

            try
            {
                MSession session = await form.ShowLoginDialog(); // show login form
                Invoke(new Action(() =>
                {
                    UpdateSession(session);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }

        private async void LoginForm_Shown(object sender, EventArgs e)
        {
            var form = await CreateForm();

            try
            {
                MSession session = await form.ShowLoginDialog(); // show login form
                Invoke(new Action(() =>
                {
                    UpdateSession(session);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please log in manually.");
            }
        }
    }
}


