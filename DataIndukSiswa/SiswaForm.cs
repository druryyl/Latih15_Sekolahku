using Latih15_Sekolahku.DataIndukSiswa.Dal;
using Latih15_Sekolahku.DataIndukSiswa.Models;

namespace Latih15_Sekolahku;

public partial class SiswaForm : Form
{
    private readonly SiswaDal _siswaDal;
    private readonly SiswaRiwayatDal _siswaRiwayatDal;
    private readonly SiswaPrestasiDal _siswaPrestasiDal;
    private readonly SiswaBeasiswaDal _siswaBeasiswaDal;
    private readonly SiswaWaliDal _siswaWaliDal;

    public SiswaForm()
    {
        InitializeComponent();

        _siswaDal = new SiswaDal();
        _siswaRiwayatDal = new SiswaRiwayatDal();
        _siswaPrestasiDal = new SiswaPrestasiDal();
        _siswaBeasiswaDal = new SiswaBeasiswaDal();
        _siswaWaliDal = new SiswaWaliDal();

        RegisterControlEvent();
        InitCombo();
    }

    private void RegisterControlEvent()
    {
        RefreshButton.Click += RefreshButton_Click;
        NewButton.Click += NewButton_Click;
        SavePersonalButton.Click += SaveButton_Click;
    }

    private void InitCombo()
    {
        AgamaCombo.Items.Add("ISLAM");
        AgamaCombo.Items.Add("KRISTEN");
        AgamaCombo.Items.Add("KATHOLIK");
        AgamaCombo.Items.Add("HINDU");
        AgamaCombo.Items.Add("BUDHA");
        AgamaCombo.Items.Add("KEPERCAYAAN");
        AgamaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        AgamaCombo.SelectedIndex = 0;

        KeberadaanOrtuCombo.Items.Add("HIDUP");
        KeberadaanOrtuCombo.Items.Add("YATIM IBU");
        KeberadaanOrtuCombo.Items.Add("YATIM BAPAK");
        KeberadaanOrtuCombo.Items.Add("YATIM-PIATU");
        KeberadaanOrtuCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        KeberadaanOrtuCombo.SelectedIndex = 0;


        StatusTinggalCombo.Items.Add("DENGAN ORTU");
        StatusTinggalCombo.Items.Add("DENGAN SAUDARA");
        StatusTinggalCombo.Items.Add("DI ASRAMA");
        StatusTinggalCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        StatusTinggalCombo.SelectedIndex = 0;

    }


    private void SaveButton_Click(object? sender, EventArgs e)
    {
        SaveSiswa();
    }

    private void SaveSiswa()
    {
        var siswaId = SaveSiswaPersonal();
        SaveSiswaRiwayat(siswaId);
        SaveSiswaPrestasi(siswaId);
        SaveSiswaBeasiswa(siswaId);
        SaveSiswaWali(siswaId);
    }

    private int SaveSiswaPersonal()
    {
        var siswaId = SiswaIdText.Text == string.Empty ? 0
            : int.Parse(SiswaIdText.Text);
        var siswa = new SiswaModel
        {
            SiswaId = siswaId,
            NamaLengkap = NamaLengkapText.Text,
            NamaPanggilan = PanggilanText.Text,
            TempatLahir = TempatLahirText.Text,
            TanggalLahir = TglLahirDatePicker.Value,
            Gender = PriaRadio.Checked ? 0 : 1,
            Agama = AgamaCombo.SelectedItem.ToString() ?? string.Empty,
            WargaNegara = WargaNegaraText.Text,
            AnakKe = (int)AnakKeNumeric.Value,
            JumSaudaraKandung = (int)JumSaudaraKandungNumeric.Value,
            JumSaudaraAngkat = (int)JumSaudaraAngkatNumeric.Value,
            JumSaudaraTiri = (int)JumSaudaraTiriNumeric.Value,
            KeberadaanOrtu = KeberadaanOrtuCombo.SelectedItem.ToString() ?? string.Empty,
            BahasaSehariHari = BahasaText.Text,
            AlamatSiswa = AlamatSiswaText.Text,
            NomorHpRumah = NomorHpSiswaText.Text,
            StatusTinggal = StatusTinggalCombo.SelectedItem.ToString() ?? string.Empty,
            JarakKeSekolah = (int)JarakSekolahNumeric.Value,
            TransportKeSekolah = TransportasiText.Text
        };
        if (siswa.SiswaId == 0)
            siswaId = _siswaDal.Insert(siswa);
        else
            _siswaDal.Update(siswa);

        return siswaId;
    }

    private void SaveSiswaRiwayat(int siswaId)
    {
        var golDarah = string.Empty;
        if (GolDarahABRadio.Checked) golDarah = "AB";
        if (GolDarahARadio.Checked) golDarah = "A";
        if (GolDarahBRadio.Checked) golDarah = "B";
        if (GolDarahORadio.Checked) golDarah = "O";

        var siswaRiwayat = new SiswaRiwayatModel
        {
            SiswaId = siswaId,
            GolDarah = golDarah,
            SakitPernahDiderita = SakitDideritaText.Text,
            KelainanJasmani = KelainanJasmaniText.Text,
            TinggiBadan = (int)TinggiBadanNumeric.Value,
            BeratBadan = (int)BeratBadanNumeric.Value,
            PendidikanSebelumnya = PendidikanSebelumText.Text,
            TglIjazah = TglIjazahDatePicker.Value,
            NoIjazah = NoIjazahText.Text,
            LamaBelajar = LamaBelajarText.Text,
            PindahanDari = PindahanDariText.Text,
            AlasanPindah = AlasanPindahText.Text,
            KelasPenerimaan = KelasPenerimaanText.Text,
            KompetensiKeahlian = KompetensiText.Text,
            TglDiterima = TglDiterimaDatePicker.Value,
        };

        var dataDiDb = _siswaRiwayatDal.GetData(siswaId);
        if (dataDiDb is null)
            _siswaRiwayatDal.Insert(siswaRiwayat);
        else
            _siswaRiwayatDal.Update(siswaRiwayat);

    }

    private void SaveSiswaPrestasi(int siswaId)
    {
        var siswaPrestasi = new SiswaPrestasiModel
        {
            SiswaId = siswaId,
            Seni = SeniText.Text,
            Olahraga = OlahRagaText.Text,
            Kemasyarakatan = KemasyarakatanText.Text,
            BakatLainnya = BakatLainnyaText.Text,
            CitaCita = CitaCitaText.Text,
        };

        var datadiDb = _siswaPrestasiDal.GetData(siswaId);
        if (datadiDb is null)
            _siswaPrestasiDal.Insert(siswaPrestasi);
        else
            _siswaPrestasiDal.Update(siswaPrestasi);
    }

    private void SaveSiswaBeasiswa(int siswaId)
    {
        var listBeasiswa = new List<SiswaBeasiswaModel>();
        _siswaBeasiswaDal.Delete(siswaId);
        foreach(DataGridViewRow row in BeasiswaGrid.Rows)
        {
            var newItem = new SiswaBeasiswaModel
            {
                SiswaId = siswaId,
                NoUrut = listBeasiswa.Count + 1,
                Kelas = row.Cells["Kelas"].Value.ToString() ?? string.Empty,
                Tahun = row.Cells["Tahun"].Value.ToString() ?? string.Empty,
                PenyediaBeasiswa = row.Cells["PenyandangDana"].Value.ToString() ?? string.Empty
            };
            listBeasiswa.Add(newItem);
        }
        _siswaBeasiswaDal.Insert(listBeasiswa);
    }

    private void SaveSiswaWali(int siswaId)
    {
        var ayah = new SiswaWaliModel
        {
            SiswaId = siswaId,
            JenisWali = 0,
            NamaLengkap = NamaLengkapAyahText.Text,
            TempatLahir = TempatLahirAyahText.Text,
            TglLahir = TglLahirAyahDatePicker.Value,
            Kewarganegaraan = WniAyahRadio.Checked ? 0 : 1,
            Pendidikan = PendidikanAyahText.Text,
            Pekerjaan = PekerjaanAyahText.Text,
            Penghasilan = PenghasilanAyahNumeric.Value,
            Nik = NikAyahText.Text,
            NoKk = NoKkAyahText.Text
        };
        var ibu = new SiswaWaliModel
        {
            SiswaId = siswaId,
            JenisWali = 1,
            NamaLengkap = NamaLengkapIbuText.Text,
            TempatLahir = TempatLahirIbuText.Text,
            TglLahir = TglLahirIbuDatePicker.Value,
            Kewarganegaraan = WniIbuRadio.Checked ? 0 : 1,
            Pendidikan = PendidikanIbuText.Text,
            Pekerjaan = PekerjaanIbuText.Text,
            Penghasilan = PenghasilanIbuNumeric.Value,
            Nik = NikIbuText.Text,
            NoKk = NoKkIbuText.Text
        };
        var wali = new SiswaWaliModel
        {
            SiswaId = siswaId,
            JenisWali = 2,
            NamaLengkap = NamaLengkapWaliText.Text,
            TempatLahir = TempatLahirWaliText.Text,
            TglLahir = TglLahirWaliDatePicker.Value,
            Kewarganegaraan = WniWaliRadio.Checked ? 0 : 1,
            Pendidikan = PendidikanWaliText.Text,
            Pekerjaan = PekerjaanWaliText.Text,
            Penghasilan = PenghasilanWaliNumeric.Value,
            Nik = NikWaliText.Text,
            NoKk = NoKkWaliText.Text
        };
        var listWali = new List<SiswaWaliModel>
        {
            ayah,
            ibu,
            wali
        };

        _siswaWaliDal.Delete(siswaId);
        _siswaWaliDal.Insert(listWali);
    }

    private void NewButton_Click(object? sender, EventArgs e)
    {
        //  jika masih ada data baru, konfirmasikan ke user
        var siswaId = SiswaIdText.Text;
        var siswaName = NamaLengkapText.Text;
        if (siswaId == string.Empty && siswaName != string.Empty)
        {
            var result = MessageBox.Show("Buat data baru??", "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (result != DialogResult.Yes)
                return;
        }

        ClearInput();
        SiswaTabControl.SelectedTab = PersonalTabPage;
        NamaLengkapText.Focus();
    }

    private void RefreshButton_Click(object? sender, EventArgs e)
    {
        RefreshListData();
    }

    private void ClearInput()
    {
        //  Personal
        SiswaIdText.Clear();
        NikSiswaText.Clear();
        NamaLengkapText.Clear();
        PanggilanText.Clear();
        TempatLahirText.Clear();
        TglLahirDatePicker.Value = new DateTime(3000, 1, 1);
        AgamaCombo.SelectedIndex = 0;
        WargaNegaraText.Clear();
        AnakKeNumeric.Value = 0;
        JumSaudaraKandungNumeric.Value = 0;
        JumSaudaraAngkatNumeric.Value = 0;
        JumSaudaraTiriNumeric.Value = 0;
        KeberadaanOrtuCombo.SelectedIndex = 0;
        BahasaText.Clear();
        AlamatSiswaText.Clear();
        NomorHpSiswaText.Clear();
        StatusTinggalCombo.SelectedIndex = 0;
        JarakSekolahNumeric.Value = 0;
        TransportasiText.Clear();

        //  Riwayat
        SakitDideritaText.Clear();
        KelainanJasmaniText.Clear();
        TinggiBadanNumeric.Value = 0;
        BeratBadanNumeric.Value = 0;
        PendidikanSebelumText.Clear();
        TglIjazahDatePicker.Value = new DateTime(3000, 1, 1);
        NoIjazahText.Clear();
        LamaBelajarText.Clear();
        PindahanDariText.Clear();
        AlasanPindahText.Clear();
        KelasPenerimaanText .Clear();
        KompetensiText.Clear();
        TglDiterimaDatePicker.Value = new DateTime(3000, 1, 1);

        //  Prestasi
        SeniText.Clear();
        OlahRagaText.Clear();
        KemasyarakatanText .Clear();
        BakatLainnyaText .Clear();
        CitaCitaText .Clear();
        BeasiswaGrid.DataSource = new List<BeasiswaDto>();

        //  Wali
        //      ayah
        NamaLengkapAyahText.Clear();
        TempatLahirAyahText.Clear();
        TglLahirAyahDatePicker.Value = new DateTime(3000, 1, 1);
        WniAyahRadio.Checked = true;
        PendidikanAyahText.Clear();
        PekerjaanAyahText.Clear();
        PenghasilanAyahNumeric.Value = 0;
        NikAyahText.Clear();
        NoKkAyahText.Clear();
        //      ibu
        NamaLengkapIbuText.Clear();
        TempatLahirIbuText.Clear();
        TglLahirIbuDatePicker.Value = new DateTime(3000, 1, 1);
        WniIbuRadio.Checked = true;
        PendidikanIbuText.Clear();
        PekerjaanIbuText.Clear();
        PenghasilanIbuNumeric.Value = 0;
        NikIbuText.Clear();
        NoKkIbuText.Clear();
        //      wali
        NamaLengkapWaliText.Clear();
        TempatLahirWaliText.Clear();
        TglLahirWaliDatePicker.Value = new DateTime(3000, 1, 1);
        WniWaliRadio.Checked = true;
        PendidikanWaliText.Clear();
        PekerjaanWaliText.Clear();
        PenghasilanWaliNumeric.Value = 0;
        NikWaliText.Clear();
        NoKkWaliText.Clear();
    }

    private void RefreshListData()
    {
        var listData = _siswaDal.ListData() ?? new List<SiswaModel>();
        var dataSource = listData
            .Select(x => new ListSiswaDto
            {
                SiswaId = x.SiswaId,
                Nama = x.NamaLengkap,
                TglLahir = x.TanggalLahir,
                Gender = x.Gender == 0 ? "Pria" : "Wanita",
                Alamat = x.AlamatSiswa
            })
            .ToList();
        ListSiswaGrid.DataSource = dataSource;
        ListSiswaGrid.Refresh();
    }
}

public class ListSiswaDto
{
    public int SiswaId { get; set; }
    public string Nama { get; set; }
    public DateTime TglLahir { get; set; }
    public string Gender { get; set; }
    public string Alamat { get; set; }
}

public class BeasiswaDto
{
    public int No { get; set; }
    public string Tahun { get; set; }
    public string Kelas { get; set; }
    public string PenyandangDana { get; set; }
}
