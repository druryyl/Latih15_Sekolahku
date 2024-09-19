using Latih15_Sekolahku.MataPelajaran;
using System.Data;
using System.Windows.Forms;

namespace Latih15_Sekolahku.Mapel;

public partial class MapelListForm : Form
{
    private readonly MapelDal _mapelDal;
    public int MapelId { get; private set; } = 0;
    public string MapelName { get; private set; } = "";

    public MapelListForm()
    {
        InitializeComponent();
        KeyPreview = true;

        _mapelDal = new MapelDal();
        var listMapel = _mapelDal.ListData()?.ToList()
            ?? new List<MapelModel>();
        ListDataGrid.DataSource = listMapel
            .Select(x => new
            {
                ID = x.MapelId,
                Mapel = x.MapelName
            }).ToList();

        ListDataGrid.CellDoubleClick += ListDataGrid_CellDoubleClick;
        ListDataGrid.KeyDown += ListDataGrid_KeyDown;
        this.KeyDown += ThisForm_KeyDown;
    }

    private void ThisForm_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }
    }

    private void ListDataGrid_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && ListDataGrid.CurrentRow != null)
        {
            // Prevents 'Enter' from moving to the next row
            e.Handled = true;

            // Access the selected row
            DataGridViewRow selectedRow = ListDataGrid.CurrentRow;
            // Do something with the selected row
            MapelId = Convert.ToInt32(selectedRow.Cells[0].Value);
            MapelName = selectedRow?.Cells[1].Value.ToString() ?? string.Empty;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void ListDataGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow selectedRow = ListDataGrid.Rows[e.RowIndex];
        MapelId = Convert.ToInt32(selectedRow.Cells[0].Value);
        MapelName = selectedRow?.Cells[1].Value.ToString() ?? string.Empty;
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
