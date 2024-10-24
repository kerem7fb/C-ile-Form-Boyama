using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Red;
            groupBox1.BackColor = Color.White;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Green;
            groupBox1.BackColor = Color.White;
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}
