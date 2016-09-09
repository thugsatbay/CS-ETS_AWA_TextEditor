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
    public partial class AWA : Form
    {
        Write ww;
        public AWA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();
            ww = new Write(richTextBox1.Text);
            ww.ShowDialog();
            this.Close();
            
        }
    }
}
