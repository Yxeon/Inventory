using Inventory.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class MainForm : Form
    {
        private static MainForm Instance;

        public MainForm()
        {
            InitializeComponent();
            Instance = this;

            MaximumSize = Screen.FromControl(this).WorkingArea.Size;

            LoadForm(new LoadingForm());
            FormBorderStyle = FormBorderStyle.None;
        }

        public static void LoadingForm()
        {
            Instance.FormBorderStyle = FormBorderStyle.None;
        }

        public static void LoadForm(UserControl form)
        {
            Instance.AcceptButton = null;
            DisposeContent();
            Instance.WindowState = FormWindowState.Normal;
            Instance.FormBorderStyle = FormBorderStyle.Fixed3D;
            Instance.Size = form.Size;
            Instance.CenterToScreen();
            form.Dock = DockStyle.Fill;
            Instance.Controls.Add(form);
        }

        private static void DisposeContent()
        {
            while (Instance.Controls.Count >= 1)
            {
                Instance.Controls[0].Dispose();
            }
        }
    }
}
