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
            MaterialSkin.Controls.MaterialLabel materialLabel11;
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
            this.somsAnarchy = new MaterialSkin.Controls.MaterialRadioButton();
            this.somsMain = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.launchLegacyMode = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbSkipHashCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbSkipAssetsDownload = new MaterialSkin.Controls.MaterialCheckbox();
            this.Launch = new MaterialSkin.Controls.MaterialButton();
            this.Pb_Progress = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbUsername = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.cbVersion = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Lv_Status = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WindowTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel11
            // 
            materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            materialLabel11.Location = new System.Drawing.Point(1079, 806);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new System.Drawing.Size(341, 14);
            materialLabel11.TabIndex = 51;
            materialLabel11.Text = "Launching in 1.2 mode might fix some issues with mods (Beta)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.TxtXmx);
            this.groupBox2.Controls.Add(this.txtXms);
            this.groupBox2.Controls.Add(this.Txt_JavaArgs);
            this.groupBox2.Controls.Add(this.materialButton5);
            this.groupBox2.Location = new System.Drawing.Point(3, 397);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(468, 256);
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
            this.TxtXmx.Size = new System.Drawing.Size(307, 50);
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
            this.txtXms.Size = new System.Drawing.Size(307, 50);
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
            this.Txt_JavaArgs.Size = new System.Drawing.Size(455, 50);
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
            this.materialButton5.Location = new System.Drawing.Point(397, 163);
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
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.lbJavaPath);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Location = new System.Drawing.Point(477, 479);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(701, 174);
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
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.somsAnarchy);
            this.groupBox3.Controls.Add(this.somsMain);
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.launchLegacyMode);
            this.groupBox3.Controls.Add(this.cbSkipHashCheck);
            this.groupBox3.Controls.Add(this.cbSkipAssetsDownload);
            this.groupBox3.Location = new System.Drawing.Point(1195, 414);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(227, 239);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Options";
            // 
            // somsAnarchy
            // 
            this.somsAnarchy.AutoSize = true;
            this.somsAnarchy.Depth = 0;
            this.somsAnarchy.Location = new System.Drawing.Point(15, 182);
            this.somsAnarchy.Margin = new System.Windows.Forms.Padding(0);
            this.somsAnarchy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.somsAnarchy.MouseState = MaterialSkin.MouseState.HOVER;
            this.somsAnarchy.Name = "somsAnarchy";
            this.somsAnarchy.Ripple = true;
            this.somsAnarchy.Size = new System.Drawing.Size(189, 37);
            this.somsAnarchy.TabIndex = 53;
            this.somsAnarchy.TabStop = true;
            this.somsAnarchy.Text = "soms Anarchy (NEW!)";
            this.somsAnarchy.UseVisualStyleBackColor = true;
            // 
            // somsMain
            // 
            this.somsMain.AutoSize = true;
            this.somsMain.Checked = true;
            this.somsMain.Depth = 0;
            this.somsMain.Location = new System.Drawing.Point(15, 149);
            this.somsMain.Margin = new System.Windows.Forms.Padding(0);
            this.somsMain.MouseLocation = new System.Drawing.Point(-1, -1);
            this.somsMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.somsMain.Name = "somsMain";
            this.somsMain.Ripple = true;
            this.somsMain.Size = new System.Drawing.Size(162, 37);
            this.somsMain.TabIndex = 52;
            this.somsMain.TabStop = true;
            this.somsMain.Text = "soms Main Server";
            this.somsMain.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.Location = new System.Drawing.Point(15, 130);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 17);
            this.materialLabel4.TabIndex = 51;
            this.materialLabel4.Text = "Server";
            // 
            // launchLegacyMode
            // 
            this.launchLegacyMode.AutoSize = true;
            this.launchLegacyMode.Depth = 0;
            this.launchLegacyMode.Location = new System.Drawing.Point(15, 93);
            this.launchLegacyMode.Margin = new System.Windows.Forms.Padding(0);
            this.launchLegacyMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.launchLegacyMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchLegacyMode.Name = "launchLegacyMode";
            this.launchLegacyMode.ReadOnly = false;
            this.launchLegacyMode.Ripple = true;
            this.launchLegacyMode.Size = new System.Drawing.Size(180, 37);
            this.launchLegacyMode.TabIndex = 50;
            this.launchLegacyMode.Text = "Legacy mod support";
            this.launchLegacyMode.UseVisualStyleBackColor = true;
            // 
            // cbSkipHashCheck
            // 
            this.cbSkipHashCheck.AutoSize = true;
            this.cbSkipHashCheck.Depth = 0;
            this.cbSkipHashCheck.Location = new System.Drawing.Point(15, 56);
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
            this.cbSkipAssetsDownload.Location = new System.Drawing.Point(15, 20);
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
            // Launch
            // 
            this.Launch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Launch.AutoSize = false;
            this.Launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Launch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Launch.Depth = 0;
            this.Launch.HighEmphasis = true;
            this.Launch.Icon = null;
            this.Launch.Location = new System.Drawing.Point(1358, 320);
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
            // Pb_Progress
            // 
            this.Pb_Progress.Depth = 0;
            this.Pb_Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pb_Progress.Location = new System.Drawing.Point(3, 728);
            this.Pb_Progress.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pb_Progress.Name = "Pb_Progress";
            this.Pb_Progress.Size = new System.Drawing.Size(1423, 5);
            this.Pb_Progress.TabIndex = 33;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsername.AutoSize = true;
            this.lbUsername.Depth = 0;
            this.lbUsername.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbUsername.Location = new System.Drawing.Point(477, 458);
            this.lbUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(68, 17);
            this.lbUsername.TabIndex = 47;
            this.lbUsername.Text = "test_user3";
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(1340, 30);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(82, 36);
            this.materialButton4.TabIndex = 47;
            this.materialButton4.Text = "Log Out";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1281, 320);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(69, 36);
            this.materialButton1.TabIndex = 38;
            this.materialButton1.Text = "About";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
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
            this.materialButton2.Location = new System.Drawing.Point(560, 668);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(84, 36);
            this.materialButton2.TabIndex = 39;
            this.materialButton2.Text = "Refresh";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
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
            this.cbVersion.Location = new System.Drawing.Point(72, 662);
            this.cbVersion.MaxDropDownItems = 4;
            this.cbVersion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(479, 49);
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
            this.materialLabel1.Location = new System.Drawing.Point(6, 675);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 17);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Version : ";
            // 
            // Lv_Status
            // 
            this.Lv_Status.AutoSize = true;
            this.Lv_Status.Depth = 0;
            this.Lv_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lv_Status.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lv_Status.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.Lv_Status.Location = new System.Drawing.Point(3, 711);
            this.Lv_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lv_Status.Name = "Lv_Status";
            this.Lv_Status.Size = new System.Drawing.Size(41, 17);
            this.Lv_Status.TabIndex = 42;
            this.Lv_Status.Text = "Ready";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1417, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // WindowTitle
            // 
            this.WindowTitle.AutoSize = true;
            this.WindowTitle.Depth = 0;
            this.WindowTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WindowTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.WindowTitle.Location = new System.Drawing.Point(9, 37);
            this.WindowTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(100, 29);
            this.WindowTitle.TabIndex = 51;
            this.WindowTitle.Text = "Launcher";
            // 
            // materialButton6
            // 
            this.materialButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(1187, 320);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(86, 36);
            this.materialButton6.TabIndex = 53;
            this.materialButton6.Text = "Updates";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(477, 414);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(185, 37);
            this.materialSwitch1.TabIndex = 54;
            this.materialSwitch1.Text = "Enable light mode";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1429, 736);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialButton6);
            this.Controls.Add(this.WindowTitle);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(materialLabel11);
            this.Controls.Add(this.Lv_Status);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Pb_Progress);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "soms Client";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton Launch;
        private MaterialSkin.Controls.MaterialProgressBar Pb_Progress;
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
        private MaterialSkin.Controls.MaterialCheckbox cbSkipHashCheck;
        private MaterialSkin.Controls.MaterialCheckbox cbSkipAssetsDownload;
        private MaterialSkin.Controls.MaterialCheckbox launchLegacyMode;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel WindowTitle;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRadioButton somsAnarchy;
        private MaterialSkin.Controls.MaterialRadioButton somsMain;
    }
}