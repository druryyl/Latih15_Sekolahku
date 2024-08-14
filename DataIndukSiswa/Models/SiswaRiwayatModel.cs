using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku.DataIndukSiswa.Models
{
    public class SiswaRiwayatModel
    {
        public int SiswaId { get; set; }

        public int GolDarah { get; set; }
        public string SakitPernahDiderita { get; set; }
        public string KelainanJasmani { get; set; }
        public int TinggiBadan { get; set; }
        public int BeratBadan { get; set; }


        public string PendidikanSebelumnya { get; set; }
        public DateTime TglIjazah { get; set; }
        public string NoIjazah { get; set; }
        public string LamaBelajar { get; set; }

        public string PindahanDari { get; set; }
        public string AlasanPindah { get; set; }

        public string KelasPenerimaan { get; set; }
        public string KompetensiKeahlian { get; set; }
        public DateTime TglDiterima { get; set; }
    }
}
