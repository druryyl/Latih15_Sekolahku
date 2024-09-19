using Latih15_Sekolahku.Guru;
using Latih15_Sekolahku.Jurusan;
using Latih15_Sekolahku.Kelas;
using Latih15_Sekolahku.Mapel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latih15_Sekolahku.Helpers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataIndukSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SiswaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new JurusanForm();
            form.MdiParent = this;
            form.Show();
        }

        private void kelasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new KelasForm();
            form.MdiParent = this;
            form.Show();
        }

        private void guruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GuruForm();
            form.MdiParent = this;
            form.Show();

        }

        private void mataPelajaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MapelForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
