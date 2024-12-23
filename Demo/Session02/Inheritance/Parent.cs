using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Inheritance
{
    internal class Parent
    {
        public Parent(int x , int y)
        {
            X = x; 
            Y = y;
        }
        public int X {  get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X:{X}\n Y:{Y}";
        }
    }
}
