using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CmlLibWinFormSample
{
    public partial class JavaForm : MaterialForm
    {
        public string JavaBinaryPath { get; set; }

        public JavaForm(string javaPath)
        {
            this.JavaBinaryPath = javaPath;
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void JavaForm_Load(object sender, EventArgs e)
        {
            txtUserJava.Text = JavaBinaryPath;
            if (string.IsNullOrEmpty(JavaBinaryPath))
                cbAutoJava.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JavaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.JavaBinaryPath = txtUserJava.Text;
        }

        private void cbAutoJava_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoJava.Checked)
                txtUserJava.Clear();
            txtUserJava.Enabled = !cbAutoJava.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
