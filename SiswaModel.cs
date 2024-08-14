using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku
{
    public class SiswaModel
    {
        public int SiswaId { get; set; }
        public string NamaLengkap { get; set; }
        public string NamaPanggilan { get; set; }
        public string TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public int Gender { get; set; }
        public string Agama { get; set; }
        public string WargaNegara { get; set; }

        public int AnakKe { get; set; }
        public int JumSaudaraKandung { get; set; }
        public int JumSaudaraTiri { get; set; }
        public int JumSaudaraAngkat { get; set; }

        public string AlamatSiswa { get; set; }
        public string NomorHpRumah { get; set; }
        public string StatusTinggal { get; set; }
        public int JarakKeSekolah { get; set; }
        public string TransportKeSekolah {get;set; }
    }


}
