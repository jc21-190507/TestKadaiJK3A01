using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211210
{
    public class Kuriage
    {
        public static int kuriage10(int i)
        {
            int surplus = i % 10;
            
            if(surplus != 0)
            {
                i = (i - surplus) + 10;
            }

            return i;

        }
    }
}
