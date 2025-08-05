using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console2
{
    internal class islem
    {
        public int toplama(int n1, int n2)
        {
            int n3 = n1 + n2;
            Console.WriteLine("Sonuç: " + n3);
            return n3;
        }

        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
    }
}
