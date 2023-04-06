using System;

namespace tugas4
{
    internal class mobil
    {

        private String _warna;
        private int _JMLPintu;
        private String _model;
        private String _merek;
        private int _tahunPegneluaran;
        // property
        public string warna 
        {
            get {
                return _warna; 
                    }
            set { 
                value = _warna;
            } 
        }
        public int JMLPintu 
        {
            get { 
                return _JMLPintu;
            } 
            set {
                _JMLPintu = value;
            }
        }
        public string model 
        {
            get { 
                return _model;
            }
            set { 
                _model = value;
            }
        }
        public string merek 
        {
            get {
                return _merek;
            }
            set {
                _merek = value;
            }
        }
        public int tahunPengeluaran 
        {
            get {
                return _tahunPegneluaran;
            }
            set {
                _tahunPegneluaran = value;
            }
        }

        public void gas(int c)
        {
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