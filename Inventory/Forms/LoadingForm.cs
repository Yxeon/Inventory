using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class LoadingForm : UserControl
    {
        enum Result
        {
            FOUND,
            NONE
        }
        public LoadingForm()
        {
            InitializeComponent();
            progressBar1.Value = 10;
            progressBar1.Maximum = 110;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);

            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 100000; j++)
            {
                Calculate(j);
                backgroundWorker.ReportProgress((j * 100) / 100000);
            }

            var account = Password.GetPassword();
            if (account == null)
            {
                e.Result = Result.NONE;
            }
            else
            {
                e.Result = Result.FOUND;
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (e.Result)
            {
                case Result.FOUND:
                    MainForm.LoadForm(new LoginForm());
                    break;
                case Result.NONE:
                    MainForm.LoadForm(new RegisterForm());
                    break;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = 10 + e.ProgressPercentage;
        }
    }
}
