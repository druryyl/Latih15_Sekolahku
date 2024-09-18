using Latih15_Sekolahku.MataPelajaran;
using System.Data;

namespace Latih15_Sekolahku.Mapel;

public partial class MapelForm : Form
{
    private readonly MapelDal _mapelDal;
    public MapelForm()
    {
        InitializeComponent();

        _mapelDal = new MapelDal();

        RegisterControlEvent();
        RefreshListData();
    }

    private void RegisterControlEvent()
    {
        NewButton.Click += NewButton_Click;
        SaveButton.Click += SaveButton_Click;
        DeleteButton.Click += DeletButton_Click;

        ListGrid.RowEnter += ListGrid_RowEnter;
    }

    private void ListGrid_RowEnter(object? sender, DataGridViewCellEventArgs e)
    {
        var mapelId = ListGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        var mapelName = ListGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        MapelIdText.Text = mapelId;
        MapelNameText.Text = mapelName;
    }

    private void DeletButton_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        _ = SaveMapel();
        RefreshListData();
        ClearInput();
    }

    private int SaveMapel()
    {
        var mapelId = MapelIdText.Text == string.Empty ? 0
            : int.Parse(MapelIdText.Text);
        var mapel = new MapelModel
        {
            MapelId = mapelId,
            MapelName = MapelNameText.Text,
        };

        if (mapel.MapelId == 0)
            mapelId = _mapelDal.Insert(mapel);
        else
            _mapelDal.Update(mapel);

        return mapelId;
    }

    private void NewButton_Click(object? sender, EventArgs e)
    {
        ClearInput();
    }

    private void ClearInput()
    {
        MapelIdText.Clear();
        MapelNameText.Clear();
    }

    private void RefreshListData()
    {
        var listData = _mapelDal.ListData() ?? new List<MapelModel>();
        var dataSource1 = listData
            .Select(x => new MapelDto
            {
                ID = x.MapelId.ToString(),
                Nama = x.MapelName,
            }).ToList();
        ListGrid.DataSource = listData;
        ListGrid.AutoResizeColumns();
    }
}

public class MapelDto
{
    public string ID { get; set; }
    public string Nama { get; set; }
}