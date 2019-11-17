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
using System.Data.Sql;
using System.Data.SqlClient;
using 实体;
using 数据库连接;


namespace 理财帮手
{
    public partial class FlowSelect : Form
    {
        Bussy bussy = new Bussy();
        User user = new User();


        public FlowSelect(User user)
        {

            InitializeComponent();
            this.user = user;

        }

        private void FlowSelect_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myFinancingDataSet.item”中。您可以根据需要移动或删除它。
            // this.itemTableAdapter.Fill(this.myFinancingDataSet.item);


        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            业务.Bussy bussy = new Bussy();
            DataTable dt =bussy.ALL(user);
            this.dataGridView1.DataSource = dt;
        }

 

        private void BtnSR_Click(object sender, EventArgs e)
        {
            业务.Bussy bussy = new Bussy();
            DataTable dt = bussy.SR(user);
            this.dataGridView1.DataSource = dt;
        }

        private void BtnZC_Click(object sender, EventArgs e)
        {
              业务.Bussy bussy = new Bussy();
            DataTable dt = bussy.ZC(user);
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

