namespace somsClient
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProductName = new MaterialSkin.Controls.MaterialLabel();
            this.labelVersion = new MaterialSkin.Controls.MaterialLabel();
            this.labelCompanyName = new MaterialSkin.Controls.MaterialLabel();
            this.labelCopyright = new MaterialSkin.Controls.MaterialLabel();
            this.windowsBuild = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Depth = 0;
            this.labelProductName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelProductName.Location = new System.Drawing.Point(68, 27);
            this.labelProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(156, 29);
            this.labelProductName.TabIndex = 33;
            this.labelProductName.Text = "Product Name";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Depth = 0;
            this.labelVersion.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelVersion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelVersion.Location = new System.Drawing.Point(68, 56);
            this.labelVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(136, 24);
            this.labelVersion.TabIndex = 34;
            this.labelVersion.Text = "Version 0.0.0.0";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Depth = 0;
            this.labelCompanyName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCompanyName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelCompanyName.Location = new System.Drawing.Point(10, 83);
            this.labelCompanyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 24);
            this.labelCompanyName.TabIndex = 35;
            this.labelCompanyName.Text = "Company";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Depth = 0;
            this.labelCopyright.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCopyright.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labelCopyright.Location = new System.Drawing.Point(10, 107);
            this.labelCopyright.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(63, 17);
            this.labelCopyright.TabIndex = 36;
            this.labelCopyright.Text = "Copyright";
            // 
            // windowsBuild
            // 
            this.windowsBuild.AutoSize = true;
            this.windowsBuild.Depth = 0;
            this.windowsBuild.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.windowsBuild.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.windowsBuild.Location = new System.Drawing.Point(10, 124);
            this.windowsBuild.MouseState = MaterialSkin.MouseState.HOVER;
            this.windowsBuild.Name = "windowsBuild";
            this.windowsBuild.Size = new System.Drawing.Size(96, 19);
            this.windowsBuild.TabIndex = 37;
            this.windowsBuild.Text = "OS: Unknown";
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 148);
            this.Controls.Add(this.windowsBuild);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About soms Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelProductName;
        private MaterialSkin.Controls.MaterialLabel labelVersion;
        private MaterialSkin.Controls.MaterialLabel labelCompanyName;
        private MaterialSkin.Controls.MaterialLabel labelCopyright;
        private MaterialSkin.Controls.MaterialLabel windowsBuild;
    }
}
