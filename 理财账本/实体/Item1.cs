using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实体
{
  public  class Item1
    {
        private string itemName;
        private string itemMoney;
        private string itemType;
        private string itemClazz;
        private string userName;

        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemMoney { get => itemMoney; set => itemMoney = value; }
        public string ItemType { get => itemType; set => itemType = value; }
        public string ItemClazz { get => itemClazz; set => itemClazz = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
