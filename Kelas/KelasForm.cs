using Latih15_Sekolahku.Jurusan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latih15_Sekolahku.Kelas
{
    public partial class KelasForm : Form
    {
        private readonly KelasDal _kelasDal;
        private readonly JurusanDal _jurusanDal;

        public KelasForm()
        {
            InitializeComponent();

            _kelasDal = new KelasDal();
            _jurusanDal = new JurusanDal();

            InitComboBox();
            RegisterControlEvent();
            RefreshListData();
        }

        private void RefreshListData()
        {
            var listKelas = _kelasDal.ListData();
            var datasource = listKelas
                .Select(x => new
                {
                    Id = x.KelasId,
                    Name = x.KelasName,
                }).ToList();
            ListDataGrid.DataSource = datasource;
        }

        private void RegisterControlEvent()
        {
            NewButton.Click += NewButton_Click;
            SaveButton.Click += SaveButton_Click;
            DeleteButton.Click += DeletButton_Click;

            Tingkat10Radio.Click += TingkatRadio_Click;
            Tingkat11Radio.Click += TingkatRadio_Click;
            Tingkat12Radio.Click += TingkatRadio_Click;

            JurusanComboBox.SelectedValueChanged += JurusanComboBox_SelectedValueChanged;
            FlagText.Validated += FlagText_Validated;

            ListDataGrid.RowEnter += ListDataGrid_RowEnter;
        }

        private void ListDataGrid_RowEnter(object? sender, DataGridViewCellEventArgs e)
        {
            var kelasId = Convert.ToInt16(ListDataGrid.Rows[e.RowIndex].Cells[0].Value);
            var kelas = _kelasDal.GetData(kelasId);
            if (kelas is null)
            {
                ClearInput();
                return;
            }

            KelasIdText.Text = kelasId.ToString();
            KelasNameText.Text = kelas?.KelasName ?? string.Empty;
            JurusanComboBox.SelectedValue = kelas?.JurusanId ?? 1;
            FlagText.Text = kelas?.Flag ?? string.Empty;

            if (kelas?.Tingkat == 10) Tingkat10Radio.Checked = true;
            else if (kelas?.Tingkat == 11) Tingkat11Radio.Checked = true;
            else if (kelas?.Tingkat == 12) Tingkat12Radio.Checked = true;
        }

        private void FlagText_Validated(object? sender, EventArgs e)
        {
            SetKelasName();
        }

        private void JurusanComboBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            SetKelasName();
        }

        private void TingkatRadio_Click(object? sender, EventArgs e)
        {
            SetKelasName();
        }

        private void DeletButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            var kelasId = SaveKelas();
            RefreshListData();
            ClearInput();
        }

        private int SaveKelas()
        {
            var kelasId = KelasIdText.Text == string.Empty ? 0
                : int.Parse(KelasIdText.Text);
            var kelas = new KelasModel
            {
                KelasId = kelasId,
                KelasName = KelasNameText.Text,
                JurusanId = Convert.ToInt16(JurusanComboBox.SelectedValue),
                Flag = FlagText.Text,
                Tingkat = Tingkat10Radio.Checked ? 10
                    : Tingkat11Radio.Checked ? 11
                    : 12
            };
            if (kelas.KelasId == 0)
                kelasId = _kelasDal.Insert(kelas);
            else
                _kelasDal.Update(kelas);
            return kelasId;
        }

        private void SetKelasName()
        {
            var tingkat = Tingkat10Radio.Checked ? 10
                : Tingkat11Radio.Checked ? 11
                : 12;
            
            var jurusanId = Convert.ToInt16(JurusanComboBox.SelectedValue);
            var jurusan = _jurusanDal.GetData(jurusanId)
                ?? new JurusanModel { Code = "X"};  
            var jurusanCode = jurusan.Code;
            var flag = FlagText.Text;
            KelasNameText.Text = $"Kelas {tingkat} {jurusanCode}-{flag}";
        }

        private void NewButton_Click(object? sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            KelasIdText.Clear();
            KelasNameText.Clear();
            FlagText.Clear();
            JurusanComboBox.SelectedIndex = 0;
            Tingkat10Radio.Checked = false;
            Tingkat11Radio.Checked = false;
            Tingkat12Radio.Checked = false;
        }

        private void InitComboBox()
        {
            var listJurusan = _jurusanDal.ListData();
            JurusanComboBox.DataSource = listJurusan;
            JurusanComboBox.ValueMember = "JurusanId";
            JurusanComboBox.DisplayMember = "JurusanName";
        }
    }
}
