using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xwriter
{
    public partial class formMainWindow : Form
    {

        private Process p;



        public formMainWindow()
        {
            p = new Process();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c dir *.cs";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            var output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            logBox.Text += (output);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            logBox.Clear();
        }




    }
}
