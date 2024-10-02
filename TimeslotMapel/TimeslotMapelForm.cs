using Latih15_Sekolahku.Guru;
using Latih15_Sekolahku.Kelas;
using Latih15_Sekolahku.Mapel;
using Latih15_Sekolahku.MataPelajaran;
using Latih15_Sekolahku.TimeslotMapel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latih15_Sekolahku.JadwalMapel
{
    public partial class TimeslotMapelForm : Form
    {
        private readonly TimeslotMapelDal _timeslotMapelDal;
        private readonly KelasDal _kelasDal;
        private readonly MapelDal _mapelDal;
        private readonly GuruDal _guruDal;
        private readonly List<string> _listJenisJadwal = new() { "Mapel Umum", "Mapel Khusus" };
        private readonly List<string> _listHari = new() { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };
        
        public TimeslotMapelForm()
        {
            InitializeComponent();
            _timeslotMapelDal = new TimeslotMapelDal();
            _kelasDal = new KelasDal();
            _mapelDal = new MapelDal();
            _guruDal = new GuruDal();

            InitMaskEdit();
            InitCombo();
            RegisterEventHandler();
            RefreshGrid();

        }

        private void RegisterEventHandler()
        {
            NewButton.Click += NewButton_Click;
            SaveButton.Click += SaveButton_Click;
            DeleteButton.Click += DeleteButton_Click;
            KelasCombo.SelectedIndexChanged += KelasCombo_SelectedIndexChanged;
        }

        private void KelasCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            SaveTimeslot();
            RefreshGrid();
            CleanUpForm();
            JamMulaiMaskEdit.Focus();
        }

        private void RefreshGrid()
        {
            RefreshGridUmum();
            RefreshGridKhusus();
        }

        private void RefreshGridKhusus()
        {
            var kelas = Convert.ToInt16(KelasCombo.SelectedValue.ToString());
            var listTimeslot = _timeslotMapelDal.ListData(kelas)
                ?? new List<TimeslotMapelModel>();
            var listUmum = listTimeslot
                .Where(x => x.JenisJadwal == "Mapel Umum")
                .OrderBy(x => x.Hari)
                .ThenBy(x => x.JamMulai)
                .Select(x => new TimeslotDto
                {
                    Hari = x.Hari,
                    Timeslot = $"{x.JamMulai}-{x.JamSelesai}",
                    Mapel = $"{x.MapelName}{x.Keterangan}",
                    Guru = x.GuruName
                })
                .ToList();
            UmumGrid.DataSource = listUmum;
        }

        private void RefreshGridUmum()
        {
            var kelas = Convert.ToInt16(KelasCombo.SelectedValue.ToString());
            var listTimeslot = _timeslotMapelDal.ListData(kelas)
                ?? new List<TimeslotMapelModel>();
            var listKhusus = listTimeslot
                .Where(x => x.JenisJadwal != "Mapel Umum")
                .OrderBy(x => x.Hari)
                .ThenBy(x => x.JamMulai)
                .Select(x => new TimeslotDto
                {
                    Hari = x.Hari,
                    Timeslot = $"{x.JamMulai}-{x.JamSelesai}",
                    Mapel = $"{x.MapelName}{x.Keterangan}",
                    Guru = x.GuruName
                })
                .ToList();
            KhususGrid.DataSource = listKhusus;
        }

        private void CleanUpForm()
        {
            JamMulaiMaskEdit.Text = "00:00";
            JamSelesaiMaskEdit.Text = "00:00";
            MapelCombo.SelectedIndex = 0;
            GuruCombo.SelectedIndex = 0;
            TimeslotIdLabel.Text = string.Empty;
        }

        private int SaveTimeslot()
        {
            var timeslotId = TimeslotIdLabel.Text == string.Empty ? 0
                : Convert.ToInt32(TimeslotIdLabel.Text);

            var timeslot = new TimeslotMapelModel
            {
                TimeslotMapelId = timeslotId,
                KelasId = Convert.ToInt32(KelasCombo.SelectedValue),
                Hari = HariCombo.Text,
                JenisJadwal = JenisJadwalCombo.Text,
                JamMulai = JamMulaiMaskEdit.Text,
                JamSelesai = JamSelesaiMaskEdit.Text,
                MapelId = Convert.ToInt32(MapelCombo.SelectedValue),
                GuruId = Convert.ToInt32(GuruCombo.SelectedValue),
                Keterangan = KeteranganText.Text
            };

            if (timeslot.TimeslotMapelId == 0)
                timeslotId = _timeslotMapelDal.Insert(timeslot);
            else
                _timeslotMapelDal.Update(timeslot);

            TimeslotIdLabel.Text = timeslotId.ToString();

            return timeslotId;
        }

        private void NewButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitCombo()
        {
            var listKelas = _kelasDal.ListData() ?? new List<KelasModel>();
            KelasCombo.Items.Clear();
            KelasCombo.DataSource = listKelas;
            KelasCombo.ValueMember = "KelasId";
            KelasCombo.DisplayMember = "KelasName";

            var listGuru = new List<GuruModel>
            {
                new GuruModel { GuruId = -1, GuruName = "--Pilih Guru--" }
            };
            listGuru.AddRange(_guruDal.ListData()?.ToList() ?? new List<GuruModel>());
            GuruCombo.Items.Clear();
            GuruCombo.DataSource = listGuru;
            GuruCombo.ValueMember = "GuruId";
            GuruCombo.DisplayMember = "GuruName";

            var listMapel = new List<MapelModel>
            {
                new MapelModel { MapelId = -1, MapelName = "--Pilih Mapel--" }
            };
            listMapel.AddRange(_mapelDal.ListData()?.ToList() ?? new List<MapelModel>());

            MapelCombo.Items.Clear();
            MapelCombo.DataSource = listMapel;
            MapelCombo.ValueMember = "MapelId";
            MapelCombo.DisplayMember = "MapelName";

            JenisJadwalCombo.Items.Clear();
            JenisJadwalCombo.DataSource = _listJenisJadwal;
            JenisJadwalCombo.SelectedIndex = 0;

            HariCombo.Items.Clear();
            HariCombo.DataSource = _listHari;
            HariCombo.SelectedIndex = 0;
        }

        private void InitMaskEdit()
        {
            JamMulaiMaskEdit.Mask = "00:00";
            JamMulaiMaskEdit.Font = new Font("Consolas", 10);
            JamSelesaiMaskEdit.Mask = "00:00";
            JamSelesaiMaskEdit.Font = new Font("Consolas", 10);
        }
    }
}

public class TimeslotDto
{
    public string Hari { get; set; }
    public string Timeslot { get; set; }
    public string Mapel { get; set; }
    public string Guru { get; set; }
}