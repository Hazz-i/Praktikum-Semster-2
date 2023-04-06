using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Mahasiswa
    {
        // properties
        public string Nama { get; set; }
        public string Nim { get; set; }
        public float Ipk { get; set; }


        // methode
        public void Registrasi()
            {
            Console.WriteLine("Nama\t: {0}", Nama);
            Console.WriteLine("Nim\t: {0}", Nim);
            Console.WriteLine("Ipk\t: {0}", Ipk);
            Console.WriteLine("\nTelah Melakukan Registrasi");
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses krs\n", Nama);
        }
    }
}
