﻿namespace Latih15_Sekolahku.Helpers
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            kesiswaanToolStripMenuItem = new ToolStripMenuItem();
            dataIndukSiswaToolStripMenuItem = new ToolStripMenuItem();
            kelasToolStripMenuItem = new ToolStripMenuItem();
            jurusanToolStripMenuItem = new ToolStripMenuItem();
            kelasToolStripMenuItem1 = new ToolStripMenuItem();
            guruToolStripMenuItem = new ToolStripMenuItem();
            mataPelajaranToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            jadwalMapelToolStripMenuItem = new ToolStripMenuItem();
            kelasSiswaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { kesiswaanToolStripMenuItem, kelasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kesiswaanToolStripMenuItem
            // 
            kesiswaanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataIndukSiswaToolStripMenuItem, kelasSiswaToolStripMenuItem });
            kesiswaanToolStripMenuItem.Name = "kesiswaanToolStripMenuItem";
            kesiswaanToolStripMenuItem.Size = new Size(73, 20);
            kesiswaanToolStripMenuItem.Text = "Kesiswaan";
            // 
            // dataIndukSiswaToolStripMenuItem
            // 
            dataIndukSiswaToolStripMenuItem.Name = "dataIndukSiswaToolStripMenuItem";
            dataIndukSiswaToolStripMenuItem.Size = new Size(180, 22);
            dataIndukSiswaToolStripMenuItem.Text = "Data Induk Siswa ...";
            dataIndukSiswaToolStripMenuItem.Click += dataIndukSiswaToolStripMenuItem_Click;
            // 
            // kelasToolStripMenuItem
            // 
            kelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jurusanToolStripMenuItem, kelasToolStripMenuItem1, guruToolStripMenuItem, mataPelajaranToolStripMenuItem, toolStripMenuItem1, jadwalMapelToolStripMenuItem });
            kelasToolStripMenuItem.Name = "kelasToolStripMenuItem";
            kelasToolStripMenuItem.Size = new Size(78, 20);
            kelasToolStripMenuItem.Text = "Pengajaran";
            // 
            // jurusanToolStripMenuItem
            // 
            jurusanToolStripMenuItem.Name = "jurusanToolStripMenuItem";
            jurusanToolStripMenuItem.Size = new Size(180, 22);
            jurusanToolStripMenuItem.Text = "Jurusan ...";
            jurusanToolStripMenuItem.Click += jurusanToolStripMenuItem_Click;
            // 
            // kelasToolStripMenuItem1
            // 
            kelasToolStripMenuItem1.Name = "kelasToolStripMenuItem1";
            kelasToolStripMenuItem1.Size = new Size(180, 22);
            kelasToolStripMenuItem1.Text = "Kelas ...";
            kelasToolStripMenuItem1.Click += kelasToolStripMenuItem1_Click;
            // 
            // guruToolStripMenuItem
            // 
            guruToolStripMenuItem.Name = "guruToolStripMenuItem";
            guruToolStripMenuItem.Size = new Size(180, 22);
            guruToolStripMenuItem.Text = "Guru ...";
            guruToolStripMenuItem.Click += guruToolStripMenuItem_Click;
            // 
            // mataPelajaranToolStripMenuItem
            // 
            mataPelajaranToolStripMenuItem.Name = "mataPelajaranToolStripMenuItem";
            mataPelajaranToolStripMenuItem.Size = new Size(180, 22);
            mataPelajaranToolStripMenuItem.Text = "Mata Pelajaran ...";
            mataPelajaranToolStripMenuItem.Click += mataPelajaranToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // jadwalMapelToolStripMenuItem
            // 
            jadwalMapelToolStripMenuItem.Name = "jadwalMapelToolStripMenuItem";
            jadwalMapelToolStripMenuItem.Size = new Size(180, 22);
            jadwalMapelToolStripMenuItem.Text = "Jadwal Mapel ...";
            jadwalMapelToolStripMenuItem.Click += jadwalMapelToolStripMenuItem_Click;
            // 
            // kelasSiswaToolStripMenuItem
            // 
            kelasSiswaToolStripMenuItem.Name = "kelasSiswaToolStripMenuItem";
            kelasSiswaToolStripMenuItem.Size = new Size(180, 22);
            kelasSiswaToolStripMenuItem.Text = "Kelas Siswa ...";
            kelasSiswaToolStripMenuItem.Click += kelasSiswaToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kesiswaanToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem;
        private ToolStripMenuItem dataIndukSiswaToolStripMenuItem;
        private ToolStripMenuItem jurusanToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem1;
        private ToolStripMenuItem guruToolStripMenuItem;
        private ToolStripMenuItem mataPelajaranToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem jadwalMapelToolStripMenuItem;
        private ToolStripMenuItem kelasSiswaToolStripMenuItem;
    }
}