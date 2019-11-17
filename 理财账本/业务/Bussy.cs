using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using 实体;
using 数据库连接;


namespace 业务
{
   
    public class Bussy
    {
        //注册
        public bool Regist(User user)
        {
            string sql = "insert into userNums values('" + user.UserName + "','" + user.UserPass + "','" + user.UserPhone + "','" + user.UserEmail + "')";
            Sqlutil sd = new Sqlutil();
            int rs = sd.nonSelect(sql);
            if (rs > 0)
            {
                sd.closeCon();
                return true;
            }
            else
            {
                sd.closeCon();
                return false;
            }
        }
       
        //登录
        public bool Login(User user)
        {
            string sql = "select * from userNums where username='" + user.UserName + "' and userPass='" + user.UserPass + "'";
            Sqlutil sd = new Sqlutil();
            SqlDataReader sdr = sd.selectOne(sql);
            if (sdr.Read())
            {
                sd.closeCon();
                return true;
            }
            else
            {
                sd.closeCon();
                return false;
            }
        }

        //添加账单
        public bool bill(Item1 item,User user)
        {
            string sql = "insert into item values('" + item.ItemName + "','" + item.ItemMoney + "','" + item.ItemType + "','" + item.ItemClazz + "','"+user.UserName+"')";
            Sqlutil sd = new Sqlutil();
            int rs = sd.nonSelect(sql);
            if (rs > 0)
            {
                sd.closeCon();
                return true;
            }
            else
            {
                sd.closeCon();
                return false;
            }
        }
        //用户名重复查询
        public bool RgName(User user)
        {
            string sql = "select * from userNums where username='" + user.UserName + "' ";
            Sqlutil sd = new Sqlutil();
            SqlDataReader sdr = sd.selectOne(sql);
            if (sdr.Read())
            {
                sd.closeCon();
                return true;
            }
            else
            {
                sd.closeCon();
                return false;
            }
        }

        //账单查询
        public DataTable ALL(User user)
        {
            string sql = string.Format("select itemName as 项目名称,itemMoney as 金额 , itemType as 类别 ,itemClazz as 项目类型 ,userName as 查询人 from item where userName = '{0}' ",user.UserName);
            Sqlutil dao = new Sqlutil();
                 
            DataTable dt = dao.selectAll(sql);
            dao.closeCon();
            return dt;

        }
        //收入查询
        public DataTable SR(User user)
        {
            string sql = string.Format("select itemName as 项目名称,itemMoney as 金额 , itemType as 类别 ,itemClazz as 项目类型 ,userName as 查询人 from item where itemType='收入' and userName = '{0}' ", user.UserName);
            Sqlutil dao = new Sqlutil();

            DataTable dt = dao.selectAll(sql);
            dao.closeCon();
            return dt;

        }
        //支出查询
        public DataTable ZC(User user)
        {
            string sql = string.Format(" select itemName as 项目名称,itemMoney as 金额 , itemType as 类别 ,itemClazz as 项目类型 ,userName as 查询人  from item where itemType='支出' and userName = '{0}' ", user.UserName);
            Sqlutil dao = new Sqlutil();

            DataTable dt = dao.selectAll(sql);
            dao.closeCon();
            return dt;

        }
    }
}
