using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem1._0
{
    public class ktra
    {
        public bool empty(string name, string pass, string user)
        {
            if (name == "" || pass == "" || user == "")
            {
                return true;
            }
            return false;
        }
    }
}
