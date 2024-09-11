using Latih15_Sekolahku.DataIndukSiswa.Dal;
using Latih15_Sekolahku.DataIndukSiswa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latih15_Sekolahku.Jurusan;

public partial class JurusanForm : Form
{
    private readonly JurusanDal _jurusanDal;

    public JurusanForm()
    {
        InitializeComponent();

        _jurusanDal = new JurusanDal();
        
        InitMaskeditTextBox();
        RegisterControlEvent();
        RefreshListData();
    }

    private void InitMaskeditTextBox()
    {
        CodeText.Mask = "???";
    }

    private void RegisterControlEvent()
    {
        NewButton.Click += NewButton_Click;
        SaveButton.Click += SaveButton_Click;
        DeletButton.Click += DeletButton_Click;

        ListDataGrid.RowEnter += ListDataGrid_RowEnter;
    }

    private void ListDataGrid_RowEnter(object? sender, DataGridViewCellEventArgs e)
    {
        var jurusanId = ListDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        var jurusanName = ListDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        var code = ListDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
        JurusanIdText.Text = jurusanId;
        JurusanNameText.Text = jurusanName;
        CodeText.Text = code;
    }

    private void DeletButton_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        var jurusanId = SaveJurusan();
        JurusanIdText.Text = jurusanId.ToString();
        RefreshListData();
        ClearInput();
    }

    private int SaveJurusan()
    {
        var jurusanId = JurusanIdText.Text == string.Empty ? 0
            : int.Parse(JurusanIdText.Text);
        var jurusan = new JurusanModel
        {
            JurusanId = jurusanId,
            JurusanName = JurusanNameText.Text,
            Code = CodeText.Text
        };

        if (jurusan.JurusanId == 0)
            jurusanId = _jurusanDal.Insert(jurusan);
        else
            _jurusanDal.Update(jurusan);

        return jurusanId;
    }

    private void NewButton_Click(object? sender, EventArgs e)
    {
        ClearInput();
    }

    private void ClearInput()
    {
        JurusanIdText.Clear();
        JurusanNameText.Clear();
        CodeText.Clear();
    }

    private void RefreshListData()
    {
        var listData = _jurusanDal.ListData() ?? new List<JurusanModel>();
        var dataSource1 = listData
            .Select(x => new JurusaDto
            {
                JID = x.JurusanId.ToString(),
                Nama = $"{x.Code} - {x.JurusanName}",
            }).ToList();
        ListDataGrid.DataSource = listData;
        ListDataGrid.AutoResizeColumns();
        //ListDataGrid.Refresh();
    }
}

public class JurusaDto
{
    public string JID { get; set; }
    public string Nama { get; set; }
}