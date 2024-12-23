using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Inheritance
{
    internal class Chiled : Parent
    {
        public Chiled(int x, int y, int z):base (x, y)
        {
            Z= z;
        }

        public int Z { get; set; }
    }
}
