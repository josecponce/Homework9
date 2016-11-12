using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            
            this.notifyIcon.Icon = Properties.Resources.Icon1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form_Resize(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
           
           this.Show();
           this.WindowState = FormWindowState.Normal;
          
        }
    }
}
