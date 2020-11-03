using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    public struct Pen
    {
        internal int penid;
        public string color;
        //error
        //string type= "Fountain";
    }

    class StructEg
    {
        static void Main()
        {
            Pen p = new Pen();
            p.penid = 100;
            p.color = "RED";
        }

    }
}
