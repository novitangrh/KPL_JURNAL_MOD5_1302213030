using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213030
{
    class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T x1, T x2, T x3)
        {
            dynamic dyx1 = x1;
            dynamic dyx2 = x2;
            dynamic dyx3 = x3;

            T hasil = dyx1 + dyx2 + dyx3;
            Console.WriteLine(hasil);
        }
    }
}