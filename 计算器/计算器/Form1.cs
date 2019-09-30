using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        bool flag = true;
        bool flag0 = true;
        double num1 = 0;
        double num2 = 0;
        double res = 0;
        string type;
        public Form1()
        {
            InitializeComponent();
           
        }
      
        private void btn1_Click(object sender, EventArgs e)
        {
         string s =( (Button)sender).Text;
            if(flag)
            {
                textBox1.Text = s;
                flag = false;
                flag0 = false;
            }
            else
            {
                textBox1.AppendText(s);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            flag = true;
            flag0 = true;
             num1 = 0;
             num2 = 0;
        }

        private void btnJia_Click(object sender, EventArgs e)
        {
            type = "+";
            num1 +=Convert.ToDouble(textBox1.Text);
            flag = true;
            flag0 = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flag0)
            {
                textBox1.Text = "0";
                flag0 = false;
            }
            else
            {
                if (!flag)
                {
                    textBox1.AppendText("0");
                    

                }
            }
        }

        private void btnDeng_Click(object sender, EventArgs e)
        {
            num2 =Convert.ToDouble( textBox1.Text);
            switch (type)
            {
                case "+":res = num1 + num2;break;
                case "-": res = num1 - num2; break;
                case "*": res = num1 * num2; break;
                case "/": res = num1 / num2; break;
                case "X²": res = num1 * num1; break;
                case "X³": res = num1 *num1*num1; break;
            }
            textBox1.Text = res+"";
            num1 = 0;
            flag = true;
            flag0 = true;
        }

        private void btnDian_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (!s.Contains("."))
            {
              textBox1.AppendText(".");
                flag = false;
            }
        }

        private void btnJian_Click(object sender, EventArgs e)
        {
            type = "-";
            num1 += Convert.ToDouble(textBox1.Text);
            flag = true;
            flag0 = true;
        }

        private void btnCheng_Click(object sender, EventArgs e)
        {
            type = "*";
            num1 += Convert.ToDouble(textBox1.Text);
            flag = true;
            flag0 = true;
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            type = "/";
            num1 += Convert.ToDouble(textBox1.Text);
            flag = true;
            flag0 = true;
        }

        private void btnLiFang_Click(object sender, EventArgs e)
        {
            type = "X³";
            num1 = Convert.ToDouble(textBox1.Text);
            flag = true;
        }

        private void btnPingFang_Click(object sender, EventArgs e)
        {
            type = "X²";
            num1= Convert.ToDouble(textBox1.Text);
            flag = true;
        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            int x = textBox1.TextLength;
            if(textBox1.TextLength>0)
            {
                textBox1.Text = textBox1.Text.Substring(0, x - 1);
            }
            else
            {
                textBox1.Text = textBox1.Text;
            }
           
        
        }
    }
}
