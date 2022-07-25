using CmlLib.Utils;
using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace CmlLibWinFormSample
{
    public partial class ChangeLog : MaterialForm
    {
        public ChangeLog()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private Changelogs changelogs;
        
        private async void ChangeLog_Load(object sender, EventArgs e)
        {
            changelogs = await Changelogs.GetChangelogs();
            listBox1.Items.AddRange(changelogs.GetAvailableVersions());
        }
        
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            var version = listBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(version))
                return;
            

            var body = await changelogs.GetChangelogHtml(version);
            webBrowser1.DocumentText = body;

        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var version = listBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(version))
                return;


            var body = await changelogs.GetChangelogHtml(version);
            webBrowser1.DocumentText = body;

        }
    }
}
