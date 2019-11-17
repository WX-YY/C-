using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实体
{
    public class User
    {
       private string userName;
        private string userPass;
        private string userPhone;
        private string userEmail;
       

        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public string UserPhone { get => userPhone; set => userPhone = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }

    }
}
