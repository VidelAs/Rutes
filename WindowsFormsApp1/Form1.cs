using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Application_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Application.StartupPath;
        }

        private void btn_runcalcu_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\calc.exe";
            this.process1.StartInfo.FileName= fn;
            if (System.IO.File.Exists(fn)== true)
            {
                this.process1.Start();
            }
            else
            {
                MessageBox.Show("I cant find calculator!!!");
            }
            
        }
    }
}
