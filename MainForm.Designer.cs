﻿namespace CmlLibWinFormSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtXmx = new MaterialSkin.Controls.MaterialTextBox();
            this.txtXms = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_JavaArgs = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbJavaPath = new MaterialSkin.Controls.MaterialLabel();
            this.txtPath = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cbSkipHashCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbSkipAssetsDownload = new MaterialSkin.Controls.MaterialCheckbox();
            this.rbSequenceDownload = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbParallelDownload = new MaterialSkin.Controls.MaterialRadioButton();
            this.Launch = new MaterialSkin.Controls.MaterialButton();
            this.Pb_File = new MaterialSkin.Controls.MaterialProgressBar();
            this.Pb_Progress = new MaterialSkin.Controls.MaterialProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbUsername = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Changelogs = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.cbVersion = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Lv_Status = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.TxtXmx);
            this.groupBox2.Controls.Add(this.txtXms);
            this.groupBox2.Controls.Add(this.Txt_JavaArgs);
            this.groupBox2.Controls.Add(this.materialButton5);
            this.groupBox2.Location = new System.Drawing.Point(982, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(498, 254);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Java Options";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel8.Location = new System.Drawing.Point(6, 198);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(74, 17);
            this.materialLabel8.TabIndex = 50;
            this.materialLabel8.Text = "Maximum : ";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel7.Location = new System.Drawing.Point(6, 143);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 17);
            this.materialLabel7.TabIndex = 48;
            this.materialLabel7.Text = "Minimum : ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(6, 102);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(206, 24);
            this.materialLabel6.TabIndex = 49;
            this.materialLabel6.Text = "Ram Allocation (in MB)";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(6, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(114, 24);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "Arguments : ";
            // 
            // TxtXmx
            // 
            this.TxtXmx.AnimateReadOnly = false;
            this.TxtXmx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtXmx.Depth = 0;
            this.TxtXmx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtXmx.LeadingIcon = null;
            this.TxtXmx.Location = new System.Drawing.Point(86, 183);
            this.TxtXmx.MaxLength = 50;
            this.TxtXmx.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtXmx.Multiline = false;
            this.TxtXmx.Name = "TxtXmx";
            this.TxtXmx.Size = new System.Drawing.Size(334, 50);
            this.TxtXmx.TabIndex = 27;
            this.TxtXmx.Text = "1024";
            this.TxtXmx.TrailingIcon = null;
            // 
            // txtXms
            // 
            this.txtXms.AnimateReadOnly = false;
            this.txtXms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXms.Depth = 0;
            this.txtXms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtXms.LeadingIcon = null;
            this.txtXms.Location = new System.Drawing.Point(86, 129);
            this.txtXms.MaxLength = 50;
            this.txtXms.MouseState = MaterialSkin.MouseState.OUT;
            this.txtXms.Multiline = false;
            this.txtXms.Name = "txtXms";
            this.txtXms.Size = new System.Drawing.Size(334, 50);
            this.txtXms.TabIndex = 26;
            this.txtXms.Text = "512";
            this.txtXms.TrailingIcon = null;
            // 
            // Txt_JavaArgs
            // 
            this.Txt_JavaArgs.AnimateReadOnly = false;
            this.Txt_JavaArgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_JavaArgs.Depth = 0;
            this.Txt_JavaArgs.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_JavaArgs.LeadingIcon = null;
            this.Txt_JavaArgs.Location = new System.Drawing.Point(6, 47);
            this.Txt_JavaArgs.MaxLength = 50;
            this.Txt_JavaArgs.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_JavaArgs.Multiline = false;
            this.Txt_JavaArgs.Name = "Txt_JavaArgs";
            this.Txt_JavaArgs.Size = new System.Drawing.Size(485, 50);
            this.Txt_JavaArgs.TabIndex = 25;
            this.Txt_JavaArgs.Text = "";
            this.Txt_JavaArgs.TrailingIcon = null;
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(427, 166);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(64, 36);
            this.materialButton5.TabIndex = 24;
            this.materialButton5.Text = "Auto";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.lbJavaPath);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Location = new System.Drawing.Point(779, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(701, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(15, 20);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(116, 24);
            this.materialLabel3.TabIndex = 46;
            this.materialLabel3.Text = "Game Path : ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(15, 107);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 24);
            this.materialLabel2.TabIndex = 45;
            this.materialLabel2.Text = "Java : ";
            // 
            // lbJavaPath
            // 
            this.lbJavaPath.AutoSize = true;
            this.lbJavaPath.Depth = 0;
            this.lbJavaPath.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbJavaPath.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbJavaPath.Location = new System.Drawing.Point(15, 131);
            this.lbJavaPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbJavaPath.Name = "lbJavaPath";
            this.lbJavaPath.Size = new System.Drawing.Size(104, 17);
            this.lbJavaPath.TabIndex = 44;
            this.lbJavaPath.Text = "Use default java";
            // 
            // txtPath
            // 
            this.txtPath.AnimateReadOnly = false;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Depth = 0;
            this.txtPath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPath.LeadingIcon = null;
            this.txtPath.Location = new System.Drawing.Point(15, 46);
            this.txtPath.MaxLength = 50;
            this.txtPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPath.Multiline = false;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(680, 50);
            this.txtPath.TabIndex = 43;
            this.txtPath.Text = "";
            this.txtPath.TrailingIcon = null;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(614, 112);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(80, 36);
            this.materialButton3.TabIndex = 42;
            this.materialButton3.Text = "Change";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.Controls.Add(this.materialLabel10);
            this.groupBox3.Controls.Add(this.materialLabel9);
            this.groupBox3.Controls.Add(this.cbSkipHashCheck);
            this.groupBox3.Controls.Add(this.cbSkipAssetsDownload);
            this.groupBox3.Controls.Add(this.rbSequenceDownload);
            this.groupBox3.Controls.Add(this.rbParallelDownload);
            this.groupBox3.Location = new System.Drawing.Point(779, 316);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(196, 254);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download Options";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(15, 129);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(125, 24);
            this.materialLabel10.TabIndex = 49;
            this.materialLabel10.Text = "More settings";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(15, 20);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(145, 24);
            this.materialLabel9.TabIndex = 48;
            this.materialLabel9.Text = "Download Mode";
            // 
            // cbSkipHashCheck
            // 
            this.cbSkipHashCheck.AutoSize = true;
            this.cbSkipHashCheck.Depth = 0;
            this.cbSkipHashCheck.Location = new System.Drawing.Point(15, 203);
            this.cbSkipHashCheck.Margin = new System.Windows.Forms.Padding(0);
            this.cbSkipHashCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbSkipHashCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbSkipHashCheck.Name = "cbSkipHashCheck";
            this.cbSkipHashCheck.ReadOnly = false;
            this.cbSkipHashCheck.Ripple = true;
            this.cbSkipHashCheck.Size = new System.Drawing.Size(137, 37);
            this.cbSkipHashCheck.TabIndex = 30;
            this.cbSkipHashCheck.Text = "Skip file check";
            this.cbSkipHashCheck.UseVisualStyleBackColor = true;
            // 
            // cbSkipAssetsDownload
            // 
            this.cbSkipAssetsDownload.AutoSize = true;
            this.cbSkipAssetsDownload.Depth = 0;
            this.cbSkipAssetsDownload.Location = new System.Drawing.Point(15, 167);
            this.cbSkipAssetsDownload.Margin = new System.Windows.Forms.Padding(0);
            this.cbSkipAssetsDownload.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbSkipAssetsDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbSkipAssetsDownload.Name = "cbSkipAssetsDownload";
            this.cbSkipAssetsDownload.ReadOnly = false;
            this.cbSkipAssetsDownload.Ripple = true;
            this.cbSkipAssetsDownload.Size = new System.Drawing.Size(162, 37);
            this.cbSkipAssetsDownload.TabIndex = 29;
            this.cbSkipAssetsDownload.Text = "Skip downloading";
            this.cbSkipAssetsDownload.UseVisualStyleBackColor = true;
            // 
            // rbSequenceDownload
            // 
            this.rbSequenceDownload.AutoSize = true;
            this.rbSequenceDownload.Depth = 0;
            this.rbSequenceDownload.Location = new System.Drawing.Point(15, 85);
            this.rbSequenceDownload.Margin = new System.Windows.Forms.Padding(0);
            this.rbSequenceDownload.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSequenceDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSequenceDownload.Name = "rbSequenceDownload";
            this.rbSequenceDownload.Ripple = true;
            this.rbSequenceDownload.Size = new System.Drawing.Size(104, 37);
            this.rbSequenceDownload.TabIndex = 28;
            this.rbSequenceDownload.TabStop = true;
            this.rbSequenceDownload.Text = "Sequence";
            this.rbSequenceDownload.UseVisualStyleBackColor = true;
            // 
            // rbParallelDownload
            // 
            this.rbParallelDownload.AutoSize = true;
            this.rbParallelDownload.Checked = true;
            this.rbParallelDownload.Depth = 0;
            this.rbParallelDownload.Location = new System.Drawing.Point(15, 48);
            this.rbParallelDownload.Margin = new System.Windows.Forms.Padding(0);
            this.rbParallelDownload.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbParallelDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbParallelDownload.Name = "rbParallelDownload";
            this.rbParallelDownload.Ripple = true;
            this.rbParallelDownload.Size = new System.Drawing.Size(88, 37);
            this.rbParallelDownload.TabIndex = 27;
            this.rbParallelDownload.TabStop = true;
            this.rbParallelDownload.Text = "Parallel";
            this.rbParallelDownload.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            this.Launch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Launch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Launch.Depth = 0;
            this.Launch.HighEmphasis = true;
            this.Launch.Icon = null;
            this.Launch.Location = new System.Drawing.Point(1416, 595);
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
            this.Pb_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pb_File.Depth = 0;
            this.Pb_File.Location = new System.Drawing.Point(1073, 655);
            this.Pb_File.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pb_File.Name = "Pb_File";
            this.Pb_File.Size = new System.Drawing.Size(406, 5);
            this.Pb_File.TabIndex = 32;
            // 
            // Pb_Progress
            // 
            this.Pb_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pb_Progress.Depth = 0;
            this.Pb_Progress.Location = new System.Drawing.Point(1073, 666);
            this.Pb_Progress.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pb_Progress.Name = "Pb_Progress";
            this.Pb_Progress.Size = new System.Drawing.Size(406, 5);
            this.Pb_Progress.TabIndex = 33;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox5.Controls.Add(this.materialLabel4);
            this.groupBox5.Controls.Add(this.lbUsername);
            this.groupBox5.Controls.Add(this.materialButton4);
            this.groupBox5.Location = new System.Drawing.Point(779, 234);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(701, 74);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(15, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(124, 24);
            this.materialLabel4.TabIndex = 47;
            this.materialLabel4.Text = "Signed in as : ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Depth = 0;
            this.lbUsername.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbUsername.Location = new System.Drawing.Point(15, 47);
            this.lbUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(68, 17);
            this.lbUsername.TabIndex = 47;
            this.lbUsername.Text = "test_user3";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(612, 23);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(82, 36);
            this.materialButton4.TabIndex = 47;
            this.materialButton4.Text = "Log Out";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Left;
            this.webView21.Location = new System.Drawing.Point(3, 64);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(767, 610);
            this.webView21.Source = new System.Uri("https://soms-site.colebolebole.repl.co/", System.UriKind.Absolute);
            this.webView21.TabIndex = 36;
            this.webView21.ZoomFactor = 1D;
            // 
            // Changelogs
            // 
            this.Changelogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Changelogs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Changelogs.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Changelogs.Depth = 0;
            this.Changelogs.HighEmphasis = true;
            this.Changelogs.Icon = null;
            this.Changelogs.Location = new System.Drawing.Point(1287, 595);
            this.Changelogs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Changelogs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Changelogs.Name = "Changelogs";
            this.Changelogs.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Changelogs.Size = new System.Drawing.Size(121, 36);
            this.Changelogs.TabIndex = 37;
            this.Changelogs.Text = "Change logs";
            this.Changelogs.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Changelogs.UseAccentColor = false;
            this.Changelogs.UseVisualStyleBackColor = true;
            this.Changelogs.Click += new System.EventHandler(this.Changelogs_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1210, 595);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(69, 36);
            this.materialButton1.TabIndex = 38;
            this.materialButton1.Text = "About";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(982, 632);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(84, 36);
            this.materialButton2.TabIndex = 39;
            this.materialButton2.Text = "Refresh";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // cbVersion
            // 
            this.cbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVersion.AutoResize = false;
            this.cbVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbVersion.Depth = 0;
            this.cbVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbVersion.DropDownHeight = 174;
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.DropDownWidth = 121;
            this.cbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.IntegralHeight = false;
            this.cbVersion.ItemHeight = 43;
            this.cbVersion.Location = new System.Drawing.Point(776, 625);
            this.cbVersion.MaxDropDownItems = 4;
            this.cbVersion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(199, 49);
            this.cbVersion.StartIndex = 0;
            this.cbVersion.TabIndex = 40;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(779, 605);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 17);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Version";
            // 
            // Lv_Status
            // 
            this.Lv_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lv_Status.AutoSize = true;
            this.Lv_Status.Depth = 0;
            this.Lv_Status.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lv_Status.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.Lv_Status.Location = new System.Drawing.Point(1073, 635);
            this.Lv_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lv_Status.Name = "Lv_Status";
            this.Lv_Status.Size = new System.Drawing.Size(41, 17);
            this.Lv_Status.TabIndex = 42;
            this.Lv_Status.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1486, 677);
            this.Controls.Add(this.Lv_Status);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Changelogs);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Pb_Progress);
            this.Controls.Add(this.Pb_File);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "soms Client";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton Launch;
        private MaterialSkin.Controls.MaterialProgressBar Pb_File;
        private MaterialSkin.Controls.MaterialProgressBar Pb_Progress;
        private GroupBox groupBox5;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private MaterialSkin.Controls.MaterialButton Changelogs;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox cbVersion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox txtPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbJavaPath;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbUsername;
        private MaterialSkin.Controls.MaterialLabel Lv_Status;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox TxtXmx;
        private MaterialSkin.Controls.MaterialTextBox txtXms;
        private MaterialSkin.Controls.MaterialTextBox Txt_JavaArgs;
        private MaterialSkin.Controls.MaterialRadioButton rbSequenceDownload;
        private MaterialSkin.Controls.MaterialRadioButton rbParallelDownload;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCheckbox cbSkipHashCheck;
        private MaterialSkin.Controls.MaterialCheckbox cbSkipAssetsDownload;
    }
}