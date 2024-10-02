using Latih15_Sekolahku.Mapel;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace Latih15_Sekolahku.Guru;

public partial class GuruForm : Form
{
    private readonly GuruDal _guruDal;
    private readonly GuruMapelDal _guruMapelDal;
    private readonly MapelDal _mapelDal;

    private readonly BindingSource _listMapelBinding;
    private readonly BindingList<MapelDto> _listMapel;

    public GuruForm()
    {
        InitializeComponent();

        _guruDal = new GuruDal();
        _guruMapelDal = new GuruMapelDal();
        _mapelDal = new MapelDal();
        _listMapel = new BindingList<MapelDto>();
        _listMapelBinding = new BindingSource()
        {
            DataSource = _listMapel
        };

        RegisterControlEvent();
        InitCombo();
        InitGrid();
        RefreshListData();
    }

    private void RefreshListData()
    {
        var listData = _guruDal.ListData() ?? new List<GuruModel>();
        var dataSource = listData
            .Select(x => new GuruDto
            {
                Id = x.GuruId,
                Name = x.GuruName,
                Pendidikan = $"{x.TingkatPendidikan} - {x.JurusanPendidikan}",
            })
            .ToList();
        ListDataGrid.DataSource = dataSource;
        ListDataGrid.Refresh();
    }

    private void InitGrid()
    {
        MapelGrid.DataSource = _listMapelBinding;
        MapelGrid.Columns["Id"].Width = 30;
        MapelGrid.Columns["Mapel"].Width = 200;
    }

    private void InitCombo()
    {
        TingkatPendidikanCombo.Items.Clear();
        TingkatPendidikanCombo.Items.Add("-");
        TingkatPendidikanCombo.Items.Add("D3");
        TingkatPendidikanCombo.Items.Add("S1");
        TingkatPendidikanCombo.Items.Add("S2");
        TingkatPendidikanCombo.Items.Add("S3");
        TingkatPendidikanCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        TingkatPendidikanCombo.SelectedIndex = 0;
    }

    private void RegisterControlEvent()
    {
        NewButton.Click += NewButton_Click;
        SaveButton.Click += SaveButton_Click;
        DeleteButton.Click += DeletButton_Click;

        ListDataGrid.RowEnter += ListDataGrid_RowEnter;
        MapelGrid.KeyDown += MapelGrid_KeyDown;
        MapelGrid.CellValidated += MapelGrid_CellValidated;
    }

    private void MapelGrid_CellValidated(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var grid = (DataGridView)sender;
        switch (grid.CurrentCell.OwningColumn.Name)
        {
            case "Id":
                var mapel = _mapelDal.GetData(Convert.ToInt16(grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                if (mapel == null)
                {
                    _listMapel[e.RowIndex].Mapel = "";
                    return;
                }
                _listMapel[e.RowIndex].Id = mapel.MapelId;
                _listMapel[e.RowIndex].Mapel= mapel.MapelName;
                break;
        }
    }

    private void MapelGrid_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F1)
        {
            DataGridViewRow currentRow = MapelGrid.CurrentRow;

            using var mapelListForm = new MapelListForm();
            if (mapelListForm.ShowDialog() == DialogResult.OK)
            {
                var mapelId = mapelListForm.MapelId;
                var mapelName = mapelListForm.MapelName;
                //_listMapel[MapelGrid.CurrentCell.RowIndex].Id = mapelId;
                //_listMapel[MapelGrid.CurrentCell.RowIndex].Mapel = mapelName;

                MapelGrid.BeginEdit(true);
                currentRow.Cells["Id"].Value = mapelId;
                currentRow.Cells["Mapel"].Value = mapelName;
                MapelGrid.EndEdit(DataGridViewDataErrorContexts.Commit);

                //MapelGrid.InvalidateRow(currentRow.Index);
                //MapelGrid.NotifyCurrentCellDirty(true);
                //MapelGrid.EndEdit();

            }
        }
    }

    private void ListDataGrid_RowEnter(object? sender, DataGridViewCellEventArgs e)
    {
        var guruId = ListDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        LoadData(Convert.ToInt16(guruId));
    }

    private void LoadData(int guruId)
    {
        var guru = _guruDal.GetData(guruId);
        if (guru == null)
        {
            ClearInput();
            return;
        }
        GuruIdText.Text = guru.GuruId.ToString();
        GuruNameText.Text = guru.GuruName;
        TglLahirDate.Value = guru.TglLahir;
        TingkatPendidikanCombo.SelectedItem = guru.TingkatPendidikan;
        JurusanText.Text = guru.JurusanPendidikan;
        TahunLulusText.Text = guru.TahunLulus;
        InstansiPendidikanText.Text = guru.InstansiPendidikan;
        KotaText.Text = guru.KotaPendidikan;

        var listMapel = _guruMapelDal.ListData(guruId)?.ToList()
            ?? new List<GuruMapelModel>();
        _listMapel.Clear();
        listMapel.ForEach(x => _listMapel.Add(new MapelDto
        {
            Id = x.MapelId,
            Mapel= x.MapelName
        }));
    }

    private void DeletButton_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        SaveGuru();
        RefreshListData();
        ClearInput();
    }

    private int SaveGuru()
    {
        var guruId = GuruIdText.Text == string.Empty ? 0
            : int.Parse(GuruIdText.Text);

        var guru = new GuruModel
        {
            GuruId = guruId,
            GuruName = GuruNameText.Text,
            TglLahir = TglLahirDate.Value,
            TingkatPendidikan = TingkatPendidikanCombo.SelectedItem.ToString() ?? string.Empty,
            JurusanPendidikan = JurusanText.Text,
            TahunLulus = TahunLulusText.Text,
            InstansiPendidikan = InstansiPendidikanText.Text,
            KotaPendidikan = KotaText.Text,

            ListMapel = _listMapel.Select(x => new GuruMapelModel
            {
                GuruId = guruId,
                MapelId = x.Id,
            }).ToList()
        };

        if (guru.GuruId == 0) 
            guru.GuruId = _guruDal.Insert(guru);
        else
            _guruDal.Update(guru);

        foreach (var item in guru.ListMapel)
            item.GuruId = guru.GuruId;

        _guruMapelDal.Delete(guru.GuruId);
        _guruMapelDal.Insert(guru.ListMapel);

        return guruId;
    }

    private void NewButton_Click(object? sender, EventArgs e)
    {
        ClearInput();
    }

    public void ClearInput()
    {
        GuruIdText.Clear();
        GuruNameText.Clear();
        TglLahirDate.Value = new DateTime(3000, 1, 1);
        TingkatPendidikanCombo.SelectedIndex = 0;
        JurusanText.Clear();
        TahunLulusText.Clear();
        InstansiPendidikanText.Clear();
        KotaText.Clear();

        _listMapel.Clear();
    }
}

public class GuruDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pendidikan { get; set; }
}

public class MapelDto
{
    public int Id { get; set; }
    public string Mapel { get; set; }
}


