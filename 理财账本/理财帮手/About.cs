using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 理财帮手
{
    public partial class About : Form
    {
        
        public About()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.BackColor = Color.Transparent;
        }

        private void About_Load(object sender, EventArgs e)
        {
            pictureBox2.Controls.Add(label10);
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox2.Controls.Add(label2);
            pictureBox2.Controls.Add(label1);
            pictureBox2.Controls.Add(label3);
            pictureBox2.Controls.Add(label4);
            pictureBox2.Controls.Add(label5);
            pictureBox2.Controls.Add(label6);
            pictureBox2.Controls.Add(label7);
            pictureBox2.Controls.Add(label8);
            pictureBox2.Controls.Add(label9);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
