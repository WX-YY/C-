using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using 实体;
using 业务;



namespace 理财帮手
{
    public partial class Login : Form
    {
           
        public Login()
        {
            InitializeComponent();
        }

     

        private void btDL_Click(object sender, EventArgs e)
        {
            User user = new User();
            Bussy bussy = new Bussy();
           user.UserName = txtName.Text;
            user.UserPass = txtPass.Text;
            
         

          
            if(bussy.Login(user))
            {
                MessageBox.Show("登录成功,欢迎"+user.UserName+"使用本程序");
                MainForm mf = new MainForm(user);
                mf.Visible = true;
                this.Visible = false;

            }       
            else {
                MessageBox.Show("登录失败");
            }
          

        }

        private void Esc_Click(object sender,EventArgs e)
        {
            
            Esc esc = new Esc();
             esc.ShowDialog();
        
        }
       

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
