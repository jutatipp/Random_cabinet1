using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_box
{
   public class Control
    {
        public int product1 = 2;
        public int product2 = 1;
        public int product3 = 4;
        public int product4 = 2;
        public int product5 = 3;
        public bool mybox2()
        {
            return true;
        }
        public bool mybox3()
        {
            if (product3 > 0)
            {
                return true;    
            }
            else { return false; }
        }
    }
}
