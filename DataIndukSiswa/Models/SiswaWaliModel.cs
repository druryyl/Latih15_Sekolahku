using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku.DataIndukSiswa.Models
{
    public class SiswaWaliModel
    {
        public int SiswaId { get; set; }
        public string JenisWali { get; set; }
        public string NamaLengkap { get; set; }
        public string TempatLahir { get; set; }
        public DateTime TglLahir { get; set; }
        public int Kewarganegaraan { get; set; }
        public string Pendidikan { get; set; }
        public string Pekerjaan { get; set; }
        public decimal Penghasilan { get; set; }
        public string Nik { get; set; }
        public string NoKk { get; set; }
    }
}
