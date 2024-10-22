using Latih15_Sekolahku.DataIndukSiswa.Dal;
using Latih15_Sekolahku.Guru;
using Latih15_Sekolahku.Kelas;
using System.ComponentModel;

namespace Latih15_Sekolahku.KelasSiswa;

public partial class KelasSiswaForm : Form
{
    private readonly KelasSiswaDal _kelasSiswaDal;
    private readonly KelasSiswaDetilDal _kelasSiswaDetilDal;
    private readonly SiswaDal _siswaDal;
    private readonly GuruDal _guruDal;
    private readonly KelasDal _kelasDal;
    private BindingList<SiswaDto> _allSiswaList = new();
    private BindingList<SiswaDto> _kelasSiswaList = new();
    private BindingSource _allSiswaBinding = new();
    private BindingSource _kelasSiswaBinding = new();
    
    public KelasSiswaForm()
    {
        InitializeComponent();

        _kelasSiswaDal = new KelasSiswaDal();
        _kelasSiswaDetilDal = new KelasSiswaDetilDal();
        _siswaDal = new SiswaDal();
        _guruDal = new GuruDal();
        _kelasDal = new KelasDal();
        _allSiswaBinding.DataSource = _allSiswaList;
        _kelasSiswaBinding.DataSource = _kelasSiswaList;

        AllSiswaGrid.DataSource = _allSiswaBinding;
        KelasSiswaGrid.DataSource = _kelasSiswaBinding;


        InitComboBox();
        RegisterControlEvent();
    }

    private void RegisterControlEvent()
    {
        KelasCombo.SelectedIndexChanged += KelasCombo_SelectedIndexChanged;

        AllSiswaGrid.CellDoubleClick += AllSiswaGrid_CellDoubleClick;
        KelasSiswaGrid.CellDoubleClick += KelasSiswaGrid_CellDoubleClick;
    }

    private void KelasSiswaGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        var grid = sender as DataGridView;
        var kelasId = (int)KelasCombo.SelectedValue;
        var siswaId = (int)grid.CurrentRow.Cells["SiswaId"].Value;
        
        _kelasSiswaDetilDal.Delete(kelasId, siswaId);
        var removedItem = _kelasSiswaList.FirstOrDefault(x => x.SiswaId == siswaId);
        _kelasSiswaList.Remove(removedItem);
        KelasSiswaGrid.Refresh();
        ListAvailableSiswa();
    }

    private void AllSiswaGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        var grid = sender as DataGridView;
        var kelasId = (int)KelasCombo.SelectedValue;
        var kelasSiswa = _kelasSiswaDal.GetData(kelasId);
        if (kelasSiswa is null)
            CreateNewKelasSiswa();

        var siswaId = (int)grid.CurrentRow.Cells["SiswaId"].Value;
        var siswaName = grid.CurrentRow.Cells["SiswaName"].Value.ToString();
        var newDetil = new KelasSiswaDetilModel
        {
            KelasId = kelasId,
            SiswaId = siswaId
        };
        _kelasSiswaDetilDal.Insert(newDetil);
        _kelasSiswaList.Add(new SiswaDto(siswaId, siswaName ?? string.Empty));
        KelasSiswaGrid.Refresh();
        ListAvailableSiswa();
    }

    private void CreateNewKelasSiswa()
    {
        var newKelasSiswa = new KelasSiswaModel
        {
            KelasId = (int)KelasCombo.SelectedValue,
            TahunAjaran = TahunAjaranText.Text,
            WaliKelasId = (int)WaliKelasCombo.SelectedIndex
        };
        _kelasSiswaDal.Insert(newKelasSiswa);
    }
    private void KelasCombo_SelectedIndexChanged(object? sender, EventArgs e)
    {
        LoadKelas();
    }

    private void LoadKelas()
    {
        if (KelasCombo.SelectedIndex == -1) 
        {
            ClearForm();
            return;
        }

        var selectedKelasId = (int)KelasCombo.SelectedValue;
        var kelasSiswa = _kelasSiswaDal.GetData(selectedKelasId);
        if (kelasSiswa == null)
        {
            ClearForm();
            return;
        }
        TahunAjaranText.Text = kelasSiswa.TahunAjaran;
        WaliKelasCombo.SelectedValue = kelasSiswa.KelasId;

        var kelasSiswaList = _kelasSiswaDetilDal.ListData(kelasSiswa.KelasId)?.ToList()
            ?? new();
        _kelasSiswaList.Clear();
        var listSiswaTemp = kelasSiswaList
            .Select(x => new SiswaDto(x.SiswaId, x.SiswaName))?.ToList() ?? new();
        foreach(var item in listSiswaTemp )
        {
            _kelasSiswaList.Add(item);
        }
        ListAvailableSiswa();
    }

    private void ClearForm()
    {
        //KelasCombo.SelectedIndex = -1;
        TahunAjaranText.Clear();
        WaliKelasCombo.SelectedIndex = -1;
        _allSiswaList.Clear();
        _kelasSiswaList.Clear();

        ListAvailableSiswa();
        AllSiswaGrid.Refresh();
    }

    private void ListAvailableSiswa()
    {
        var allSiswa = _siswaDal.ListData()?.ToList()
            ?? new();
        var siswaInKelas = _kelasSiswaDetilDal.ListData()?.ToList() 
            ?? new() ;
        var siswaIdInKelas = siswaInKelas.Select(x => x.SiswaId)?.ToList() 
            ?? new() ;

        allSiswa.RemoveAll(x => siswaIdInKelas.Contains(x.SiswaId));

        _allSiswaList.Clear();
        var listSiswaTemp = allSiswa.Select(x => new SiswaDto(x.SiswaId, x.NamaLengkap))?.ToList() ?? new();
        foreach (var item in listSiswaTemp)
        {
            _allSiswaList.Add(item);
        }

        AllSiswaGrid.Refresh();
    }

    private void InitComboBox()
    {
        var listKelas = _kelasDal.ListData();
        KelasCombo.DataSource = listKelas;
        KelasCombo.SelectedIndex = 0;
        KelasCombo.DisplayMember = "KelasName";
        KelasCombo.ValueMember = "KelasId";

        var listGuru = _guruDal.ListData();
        WaliKelasCombo.DataSource = listGuru;
        WaliKelasCombo.SelectedIndex = 0;
        WaliKelasCombo.DisplayMember = "GuruName";
        WaliKelasCombo.ValueMember = "GuruId";
    }
}

public class SiswaDto
{
    public SiswaDto()
    {
    }
    public SiswaDto(int id, string name) => (SiswaId, SiswaName) = (id, name);

    public int SiswaId { get; set; }
    public string SiswaName { get; set; }
}
