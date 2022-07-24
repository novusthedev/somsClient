namespace CmlLibWinFormSample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAutoRamSet = new System.Windows.Forms.Button();
            this.txtXms = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtXmx = new System.Windows.Forms.TextBox();
            this.Txt_JavaArgs = new System.Windows.Forms.TextBox();
            this.Xmx_RAM = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lv_Status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeJava = new System.Windows.Forms.Button();
            this.lbJavaPath = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.rbSequenceDownload = new System.Windows.Forms.RadioButton();
            this.rbParallelDownload = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSkipHashCheck = new System.Windows.Forms.CheckBox();
            this.cbSkipAssetsDownload = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefreshVersion = new System.Windows.Forms.Button();
            this.Launch = new MaterialSkin.Controls.MaterialButton();
            this.Pb_File = new MaterialSkin.Controls.MaterialProgressBar();
            this.Pb_Progress = new MaterialSkin.Controls.MaterialProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAutoRamSet);
            this.groupBox2.Controls.Add(this.txtXms);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.TxtXmx);
            this.groupBox2.Controls.Add(this.Txt_JavaArgs);
            this.groupBox2.Controls.Add(this.Xmx_RAM);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(948, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(532, 131);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Java Options";
            // 
            // btnAutoRamSet
            // 
            this.btnAutoRamSet.Location = new System.Drawing.Point(461, 81);
            this.btnAutoRamSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutoRamSet.Name = "btnAutoRamSet";
            this.btnAutoRamSet.Size = new System.Drawing.Size(65, 23);
            this.btnAutoRamSet.TabIndex = 24;
            this.btnAutoRamSet.Text = "Auto";
            this.btnAutoRamSet.UseVisualStyleBackColor = true;
            this.btnAutoRamSet.Click += new System.EventHandler(this.btnAutoRamSet_Click);
            // 
            // txtXms
            // 
            this.txtXms.Location = new System.Drawing.Point(108, 66);
            this.txtXms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXms.Name = "txtXms";
            this.txtXms.Size = new System.Drawing.Size(347, 23);
            this.txtXms.TabIndex = 23;
            this.txtXms.TextChanged += new System.EventHandler(this.txtXms_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 22;
            this.label21.Text = "Xms(MinMb) : ";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // TxtXmx
            // 
            this.TxtXmx.Location = new System.Drawing.Point(108, 99);
            this.TxtXmx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtXmx.Name = "TxtXmx";
            this.TxtXmx.Size = new System.Drawing.Size(347, 23);
            this.TxtXmx.TabIndex = 11;
            this.TxtXmx.Text = "1024";
            // 
            // Txt_JavaArgs
            // 
            this.Txt_JavaArgs.Location = new System.Drawing.Point(108, 27);
            this.Txt_JavaArgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_JavaArgs.Name = "Txt_JavaArgs";
            this.Txt_JavaArgs.Size = new System.Drawing.Size(418, 23);
            this.Txt_JavaArgs.TabIndex = 7;
            // 
            // Xmx_RAM
            // 
            this.Xmx_RAM.AutoSize = true;
            this.Xmx_RAM.Location = new System.Drawing.Point(14, 102);
            this.Xmx_RAM.Name = "Xmx_RAM";
            this.Xmx_RAM.Size = new System.Drawing.Size(89, 15);
            this.Xmx_RAM.TabIndex = 10;
            this.Xmx_RAM.Text = "Xmx(MaxMb) : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Arguments : ";
            // 
            // Lv_Status
            // 
            this.Lv_Status.AutoSize = true;
            this.Lv_Status.Location = new System.Drawing.Point(779, 476);
            this.Lv_Status.Name = "Lv_Status";
            this.Lv_Status.Size = new System.Drawing.Size(39, 15);
            this.Lv_Status.TabIndex = 17;
            this.Lv_Status.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeJava);
            this.groupBox1.Controls.Add(this.lbJavaPath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(779, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(701, 110);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced";
            // 
            // btnChangeJava
            // 
            this.btnChangeJava.Location = new System.Drawing.Point(630, 77);
            this.btnChangeJava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeJava.Name = "btnChangeJava";
            this.btnChangeJava.Size = new System.Drawing.Size(65, 25);
            this.btnChangeJava.TabIndex = 21;
            this.btnChangeJava.Text = "Change";
            this.btnChangeJava.UseVisualStyleBackColor = true;
            this.btnChangeJava.Click += new System.EventHandler(this.btnChangeJava_Click);
            // 
            // lbJavaPath
            // 
            this.lbJavaPath.AutoSize = true;
            this.lbJavaPath.Location = new System.Drawing.Point(61, 77);
            this.lbJavaPath.Name = "lbJavaPath";
            this.lbJavaPath.Size = new System.Drawing.Size(90, 15);
            this.lbJavaPath.TabIndex = 20;
            this.lbJavaPath.Text = "Use default java";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Java : ";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(17, 46);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(678, 23);
            this.txtPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Game Path : ";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(619, 24);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(76, 24);
            this.logout.TabIndex = 22;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // cbVersion
            // 
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(66, 33);
            this.cbVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(360, 23);
            this.cbVersion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version : ";
            // 
            // btnChangelog
            // 
            this.btnChangelog.Location = new System.Drawing.Point(1312, 437);
            this.btnChangelog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(91, 29);
            this.btnChangelog.TabIndex = 26;
            this.btnChangelog.Text = "Changelogs";
            this.btnChangelog.UseVisualStyleBackColor = true;
            this.btnChangelog.Click += new System.EventHandler(this.btnChangelog_Click);
            // 
            // rbSequenceDownload
            // 
            this.rbSequenceDownload.AutoSize = true;
            this.rbSequenceDownload.Location = new System.Drawing.Point(6, 48);
            this.rbSequenceDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSequenceDownload.Name = "rbSequenceDownload";
            this.rbSequenceDownload.Size = new System.Drawing.Size(76, 19);
            this.rbSequenceDownload.TabIndex = 22;
            this.rbSequenceDownload.Text = "Sequence";
            this.rbSequenceDownload.UseVisualStyleBackColor = true;
            // 
            // rbParallelDownload
            // 
            this.rbParallelDownload.AutoSize = true;
            this.rbParallelDownload.Checked = true;
            this.rbParallelDownload.Location = new System.Drawing.Point(6, 21);
            this.rbParallelDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbParallelDownload.Name = "rbParallelDownload";
            this.rbParallelDownload.Size = new System.Drawing.Size(63, 19);
            this.rbParallelDownload.TabIndex = 23;
            this.rbParallelDownload.TabStop = true;
            this.rbParallelDownload.Text = "Parallel";
            this.rbParallelDownload.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSkipHashCheck);
            this.groupBox3.Controls.Add(this.cbSkipAssetsDownload);
            this.groupBox3.Controls.Add(this.rbSequenceDownload);
            this.groupBox3.Controls.Add(this.rbParallelDownload);
            this.groupBox3.Location = new System.Drawing.Point(779, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(163, 131);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download Options";
            // 
            // cbSkipHashCheck
            // 
            this.cbSkipHashCheck.AutoSize = true;
            this.cbSkipHashCheck.Location = new System.Drawing.Point(6, 102);
            this.cbSkipHashCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSkipHashCheck.Name = "cbSkipHashCheck";
            this.cbSkipHashCheck.Size = new System.Drawing.Size(134, 19);
            this.cbSkipHashCheck.TabIndex = 26;
            this.cbSkipHashCheck.Text = "Disable file checking";
            this.cbSkipHashCheck.UseVisualStyleBackColor = true;
            // 
            // cbSkipAssetsDownload
            // 
            this.cbSkipAssetsDownload.AutoSize = true;
            this.cbSkipAssetsDownload.Location = new System.Drawing.Point(6, 75);
            this.cbSkipAssetsDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSkipAssetsDownload.Name = "cbSkipAssetsDownload";
            this.cbSkipAssetsDownload.Size = new System.Drawing.Size(121, 19);
            this.cbSkipAssetsDownload.TabIndex = 25;
            this.cbSkipAssetsDownload.Text = "Skip downloading";
            this.cbSkipAssetsDownload.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefreshVersion);
            this.groupBox4.Controls.Add(this.cbVersion);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(779, 395);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(514, 77);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Launch";
            // 
            // btnRefreshVersion
            // 
            this.btnRefreshVersion.Location = new System.Drawing.Point(432, 33);
            this.btnRefreshVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshVersion.Name = "btnRefreshVersion";
            this.btnRefreshVersion.Size = new System.Drawing.Size(76, 23);
            this.btnRefreshVersion.TabIndex = 4;
            this.btnRefreshVersion.Text = "Refresh";
            this.btnRefreshVersion.UseVisualStyleBackColor = true;
            this.btnRefreshVersion.Click += new System.EventHandler(this.btnRefreshVersion_Click);
            // 
            // Launch
            // 
            this.Launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Launch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Launch.Depth = 0;
            this.Launch.HighEmphasis = true;
            this.Launch.Icon = null;
            this.Launch.Location = new System.Drawing.Point(1415, 395);
            this.Launch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Launch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Launch.Name = "Launch";
            this.Launch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Launch.Size = new System.Drawing.Size(64, 36);
            this.Launch.TabIndex = 31;
            this.Launch.Text = "Play";
            this.Launch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Launch.UseAccentColor = false;
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click1);
            // 
            // Pb_File
            // 
            this.Pb_File.Depth = 0;
            this.Pb_File.Location = new System.Drawing.Point(779, 494);
            this.Pb_File.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pb_File.Name = "Pb_File";
            this.Pb_File.Size = new System.Drawing.Size(701, 5);
            this.Pb_File.TabIndex = 32;
            // 
            // Pb_Progress
            // 
            this.Pb_Progress.Depth = 0;
            this.Pb_Progress.Location = new System.Drawing.Point(779, 506);
            this.Pb_Progress.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pb_Progress.Name = "Pb_Progress";
            this.Pb_Progress.Size = new System.Drawing.Size(701, 5);
            this.Pb_Progress.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1409, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(6, 68);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(767, 447);
            this.webView21.Source = new System.Uri("https://soms-site.colebolebole.repl.co/", System.UriKind.Absolute);
            this.webView21.TabIndex = 36;
            this.webView21.ZoomFactor = 1D;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.logout);
            this.groupBox5.Controls.Add(this.lbUsername);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(779, 186);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(701, 61);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(98, 29);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 15);
            this.lbUsername.TabIndex = 18;
            this.lbUsername.Text = "test_user";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Signed in as : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 521);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pb_Progress);
            this.Controls.Add(this.Pb_File);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lv_Status);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "soms Client";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_JavaArgs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lv_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtXmx;
        private System.Windows.Forms.Label Xmx_RAM;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnAutoRamSet;
        private System.Windows.Forms.TextBox txtXms;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnChangeJava;
        private System.Windows.Forms.Label lbJavaPath;
        private System.Windows.Forms.RadioButton rbSequenceDownload;
        private System.Windows.Forms.RadioButton rbParallelDownload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSkipAssetsDownload;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRefreshVersion;
        private System.Windows.Forms.CheckBox cbSkipHashCheck;
        private MaterialSkin.Controls.MaterialButton Launch;
        private MaterialSkin.Controls.MaterialProgressBar Pb_File;
        private MaterialSkin.Controls.MaterialProgressBar Pb_Progress;
        private Button logout;
        private Button button1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private GroupBox groupBox5;
        private Label lbUsername;
        private Label label9;
    }
}