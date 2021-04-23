using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    abstract class PerkalianAbstract
    {
        public void Display()
        {
            Console.WriteLine("Perkalian 2 dengan 1 Selesai");
            Console.WriteLine("");
        }

        public abstract int Proccess();
    }
}
