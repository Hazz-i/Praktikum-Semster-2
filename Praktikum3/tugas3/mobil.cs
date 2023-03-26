using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3
{
    internal class mobil
    {
        // property
        public string warna { get; set; }
        public int JMLPintu { get; set; }
        public string model { get; set; }
        public string merek { get; set; }
        public int tahunPengeluaran { get; set; }

        public void gas(int c) {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}", model, c);
        }
        public void klakson(string suara)
        {
            Console.WriteLine($"\n{suara}\n");
        }
        public void tampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1}, model {2}, keluaran tahun {3}, dengan jumlah pintu sebanyak {4}\n\n", warna, merek, model, tahunPengeluaran, JMLPintu);
        }


    }
}
