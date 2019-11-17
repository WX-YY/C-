using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using 实体;
using 数据库连接;
using 业务;


namespace 理财帮手
{
    public partial class Register : Form
    {
        User user;
     
   
   
        public Register()
        {
            user = new User();
            InitializeComponent();
        }

        private void Esc2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Register1_Click(object sender, EventArgs e)
        {
            user.UserName= txtName.Text;
            user.UserPass = txtPasswd.Text;
            user.UserPhone= txtPhone.Text;
            user.UserEmail = txtEmail2.Text;
            Bussy bussy_user = new Bussy();
       
            if(txtPasswd.Text == "" || txtName.Text == ""|| txtEmail2.Text== "" || txtPhone.Text == "")
            {
                MessageBox.Show("不可为空");
            }
            else if (bussy_user.RgName(user))
            {
                MessageBox.Show("用户名已经存在");
                MessageBox.Show("注册失败！");
            }
            else if (txtPasswd2.Text != txtPasswd.Text)
            {


                MessageBox.Show("两次密码不一致");
                MessageBox.Show("注册失败！");
            }else if(bussy_user.Regist(user)){

               MessageBox.Show("注册成功！");
                  this.Visible = false;

            }
            else
            {
                MessageBox.Show("注册失败！");
            }
          
        }

        private void Register_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(label2);
            pictureBox1.Controls.Add(label3);
            pictureBox1.Controls.Add(label4);
         
            pictureBox1.Controls.Add(label5);
        }
    }
}
