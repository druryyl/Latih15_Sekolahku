namespace Latih15_Sekolahku.KelasSiswa
{
    public class KelasSiswaModel
    {
        public int KelasId { get; set; }
        public string KelasName { get; set; }
        public string TahunAjaran { get; set; }
        public int WaliKelasId { get; set; }
        public string WaliKelasName { get; set; }

        public List<KelasSiswaModel> ListSiswa { get; set; }
    }
}
