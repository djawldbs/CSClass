using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vkdlfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //btn.Enabled = false;
            btn.Text = "눌렸음!";

            lblStatus.Text  += "+";
            tbStatus.Text += "+";
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                elapesedTime = 0;
                toolStripProgressBar1.Value = 0;
                lblStatus.Text = elapesedTime + "";
                tbStatus.Text = elapesedTime + "";
            }
            else
                timer1.Enabled=false;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapesedTime++;
            lblStatus.Text = elapesedTime + "초 경과";
            tbStatus.Text = elapesedTime + "초 경과";
            toolStripProgressBar1.Value = elapesedTime; 
        }
        private int elapesedTime = 0;

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
