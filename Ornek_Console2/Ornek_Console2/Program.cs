using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            isl.toplama(6,7);
            isl.toplama(450, 85);
            Console.WriteLine("\n\n\n\n\n");

            isl.kare(25);
            Console.Read();
        }
    }
}
