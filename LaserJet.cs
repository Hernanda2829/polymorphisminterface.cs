using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphisminterface;

namespace Polymorphisminterface
{
    public class LaserJet : IPrinterWindows
    {
        public void print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public void show()
        {
            Console.WriteLine("LaserJet printer printing . . . .");
        }
    }
}