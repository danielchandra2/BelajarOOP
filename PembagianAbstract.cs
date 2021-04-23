using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    abstract class PembagianAbstract
    {
        public void Display()
        {
            Console.WriteLine("Pembagian 2 dengan 1 Selesai");
            Console.WriteLine("");
        }

        public abstract int Proccess();
    }
}
