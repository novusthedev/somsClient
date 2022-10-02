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
        }

        private void JavaForm_Load(object sender, EventArgs e)
        {
            txtUserJava.Text = JavaBinaryPath;
            if (string.IsNullOrEmpty(JavaBinaryPath))
                materialCheckbox1.Checked = true;
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
            if (materialCheckbox1.Checked)
                txtUserJava.Clear();
            txtUserJava.Enabled = !materialCheckbox1.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
                txtUserJava.Clear();
            txtUserJava.Enabled = !materialCheckbox1.Checked;
        }
    }
}
