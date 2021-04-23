using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan a1 = new Pertambahan(2, 1);
            Pengurangan a2 = new Pengurangan(2, 1);
            Perkalian a3 = new Perkalian(2, 1);
            Pembagian a4 = new Pembagian(2, 1);
            Console.WriteLine(a1.Proccess());
            Console.WriteLine(a1.A);
            Console.WriteLine(a1.B);
            a1.Display();
            Console.WriteLine(a2.Proccess());
            Console.WriteLine(a2.A);
            Console.WriteLine(a2.B);
            a2.Display();
            Console.WriteLine(a3.Proccess());
            Console.WriteLine(a3.A);
            Console.WriteLine(a3.B);
            a3.Display();
            Console.WriteLine(a4.Proccess());
            Console.WriteLine(a4.A);
            Console.WriteLine(a4.B);
            a4.Display();
            Console.Read();

        }
        class Pertambahan : PertambahanAbstract
        {
            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A + B;
            }
        }

        class Pengurangan : PenguranganAbstract
        {
            public Pengurangan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A - B;
            }
        }

        class Perkalian : PerkalianAbstract
        {
            public Perkalian(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A * B;
            }
        }

        class Pembagian : PembagianAbstract
        {
            public Pembagian(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A / B;
            }
        }
    }
}
