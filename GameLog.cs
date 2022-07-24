using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CmlLibWinFormSample
{
    public partial class GameLog : MaterialForm
    {
        public GameLog(Process process)
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;

            process.ErrorDataReceived += Process_DataReceived;
            process.OutputDataReceived += Process_DataReceived;
        }

        private readonly ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();

        private void Process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
                logQueue.Enqueue(e.Data);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
