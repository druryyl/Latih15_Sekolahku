namespace Latih15_Sekolahku.KelasSiswa
{
    public class KelasSiswaModel
    {
        public string KelasId { get; set; }
        public string KelasName { get; set; }
        public string TahunAjaran { get; set; }
        public string WaliKelasId { get; set; }
        public string WaliKelasName { get; set; }

        public List<KelasSiswaModel> ListSiswa { get; set; }
    }
}
