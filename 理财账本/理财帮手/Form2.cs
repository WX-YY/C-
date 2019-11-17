using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 实体;


namespace 理财帮手
{
    public partial class MainForm : Form
    {
        User user = new User();
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

     

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void 流水详细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FlowSelect flow = new FlowSelect(user);
            flow.Visible = true;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("是否退出？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            e.Cancel = re != DialogResult.OK;
            Application.Exit();
             
     
        }

        private void 添加支出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowZhi showZhi = new ShowZhi(user);
            showZhi.Visible = true;
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

