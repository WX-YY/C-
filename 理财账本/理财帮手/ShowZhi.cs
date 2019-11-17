using System.Data.Sql;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 业务;
using 实体;
using 数据库连接;

namespace 理财帮手
{
    public partial class ShowZhi : Form
    {
       
        Item1 Item= new Item1();
        Bussy bussy = new Bussy();
        User user;
        
        public ShowZhi(User user)
        {

            
            InitializeComponent();
            this.user = user;
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedIndex = 1;
          
            }
        }


        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    Item.ItemName = txtName.Text;
                    Item.ItemMoney = txtmoney.Text;
                    Item.ItemClazz = cboclass.SelectedItem.ToString();

                    if (rdoSR.Checked)
                    {
                        Item.ItemType = rdoSR.Text;
                    }
                    else
                    { Item.ItemType = rdoZC.Text; }
                    string message = string.Format("要添加的收支项目名称为：{0} \r\n金额：{1}\r\n所属类别为：{2}\r\n类别名称是：{3}\r\n", Item. ItemName, Item.ItemMoney, Item.ItemType, Item.ItemClazz);
                    txtInfo.Text = message;

                }
            }
        }




        private void button4_Click_1(object sender, EventArgs e)//颜色设置
        {
            colorDialog1.ShowDialog();
            txtInfo.ForeColor = colorDialog1.Color;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (bussy.bill(Item,user))
            {
                MessageBox.Show("添加成功");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ShowZhi_Load(object sender, EventArgs e)
        {
          cboclass.SelectedIndex = 0;
            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(label2);
            pictureBox1.Controls.Add(label3);
            pictureBox1.Controls.Add(label4);
            pictureBox1.Controls.Add(groupBox1);
            pictureBox1.Controls.Add(cboclass);
        }
    }
}
