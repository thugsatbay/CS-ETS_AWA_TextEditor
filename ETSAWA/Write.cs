using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ETSAWA
{
    public partial class Write : Form
    {
        String topic;
        int time;
        public Write()
        {
            InitializeComponent();
        }

        public Write(String x)
        {
            InitializeComponent();
            topic = x;
            topictextbox.Text=topic;
            time = 1800;
            timer2.Start();
            toolStripStatusLabel1.Text = time.ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time-=1;
            toolStripStatusLabel1.Text = (time / 60).ToString();
            toolStripStatusLabel1.Text+=" : "+(time % 60).ToString();
            toolStripProgressBar1.PerformClick();
            if (time == 0)
            {
                essaytextbox.Enabled = true;
                essaytextbox.ReadOnly = true;
                timer2.Stop();
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
