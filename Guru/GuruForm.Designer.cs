﻿namespace Latih15_Sekolahku.Guru
{
    partial class GuruForm
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
            ListDataGrid = new DataGridView();
            panel1 = new Panel();
            TahunLulusText = new TextBox();
            label8 = new Label();
            KotaText = new TextBox();
            label7 = new Label();
            InstansiPendidikanText = new TextBox();
            label6 = new Label();
            JurusanText = new TextBox();
            label5 = new Label();
            TingkatPendidikanCombo = new ComboBox();
            label4 = new Label();
            TglLahirDate = new DateTimePicker();
            label3 = new Label();
            PhotoPic = new PictureBox();
            GuruNameText = new TextBox();
            label2 = new Label();
            GuruIdText = new TextBox();
            label1 = new Label();
            MapelGrid = new DataGridView();
            NewButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MapelGrid).BeginInit();
            SuspendLayout();
            // 
            // ListDataGrid
            // 
            ListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListDataGrid.Location = new Point(12, 12);
            ListDataGrid.Name = "ListDataGrid";
            ListDataGrid.RowTemplate.Height = 25;
            ListDataGrid.Size = new Size(341, 409);
            ListDataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TahunLulusText);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(KotaText);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(InstansiPendidikanText);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(JurusanText);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TingkatPendidikanCombo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TglLahirDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PhotoPic);
            panel1.Controls.Add(GuruNameText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(GuruIdText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(359, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 285);
            panel1.TabIndex = 1;
            // 
            // TahunLulusText
            // 
            TahunLulusText.BorderStyle = BorderStyle.FixedSingle;
            TahunLulusText.Location = new Point(12, 250);
            TahunLulusText.Name = "TahunLulusText";
            TahunLulusText.Size = new Size(176, 23);
            TahunLulusText.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 232);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 16;
            label8.Text = "Tahun Lulus";
            // 
            // KotaText
            // 
            KotaText.BorderStyle = BorderStyle.FixedSingle;
            KotaText.Location = new Point(204, 250);
            KotaText.Name = "KotaText";
            KotaText.Size = new Size(176, 23);
            KotaText.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 232);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 13;
            label7.Text = "Kota";
            // 
            // InstansiPendidikanText
            // 
            InstansiPendidikanText.BorderStyle = BorderStyle.FixedSingle;
            InstansiPendidikanText.Location = new Point(204, 206);
            InstansiPendidikanText.Name = "InstansiPendidikanText";
            InstansiPendidikanText.Size = new Size(176, 23);
            InstansiPendidikanText.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 188);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 11;
            label6.Text = "Instansi Pendidikan";
            // 
            // JurusanText
            // 
            JurusanText.BorderStyle = BorderStyle.FixedSingle;
            JurusanText.Location = new Point(12, 206);
            JurusanText.Name = "JurusanText";
            JurusanText.Size = new Size(176, 23);
            JurusanText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 9;
            label5.Text = "Jurusan Pendidikan";
            // 
            // TingkatPendidikanCombo
            // 
            TingkatPendidikanCombo.FormattingEnabled = true;
            TingkatPendidikanCombo.Location = new Point(12, 162);
            TingkatPendidikanCombo.Name = "TingkatPendidikanCombo";
            TingkatPendidikanCombo.Size = new Size(176, 23);
            TingkatPendidikanCombo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Tingkat Pendidikan";
            // 
            // TglLahirDate
            // 
            TglLahirDate.Location = new Point(12, 118);
            TglLahirDate.Name = "TglLahirDate";
            TglLahirDate.Size = new Size(176, 23);
            TglLahirDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Tgl Lahir";
            // 
            // PhotoPic
            // 
            PhotoPic.BorderStyle = BorderStyle.FixedSingle;
            PhotoPic.Location = new Point(204, 12);
            PhotoPic.Name = "PhotoPic";
            PhotoPic.Size = new Size(176, 173);
            PhotoPic.TabIndex = 4;
            PhotoPic.TabStop = false;
            // 
            // GuruNameText
            // 
            GuruNameText.BorderStyle = BorderStyle.FixedSingle;
            GuruNameText.Location = new Point(12, 74);
            GuruNameText.Name = "GuruNameText";
            GuruNameText.Size = new Size(176, 23);
            GuruNameText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // GuruIdText
            // 
            GuruIdText.BorderStyle = BorderStyle.FixedSingle;
            GuruIdText.Location = new Point(12, 30);
            GuruIdText.Name = "GuruIdText";
            GuruIdText.Size = new Size(96, 23);
            GuruIdText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Guru ID";
            // 
            // MapelGrid
            // 
            MapelGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MapelGrid.Location = new Point(359, 303);
            MapelGrid.Name = "MapelGrid";
            MapelGrid.RowTemplate.Height = 25;
            MapelGrid.Size = new Size(405, 89);
            MapelGrid.TabIndex = 16;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(359, 398);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 17;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(608, 398);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(689, 398);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // GuruForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(776, 429);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(MapelGrid);
            Controls.Add(panel1);
            Controls.Add(ListDataGrid);
            Name = "GuruForm";
            Text = "GuruForm";
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)MapelGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListDataGrid;
        private Panel panel1;
        private DateTimePicker TglLahirDate;
        private Label label3;
        private PictureBox PhotoPic;
        private TextBox GuruNameText;
        private Label label2;
        private TextBox GuruIdText;
        private Label label1;
        private TextBox KotaText;
        private Label label7;
        private TextBox InstansiPendidikanText;
        private Label label6;
        private TextBox JurusanText;
        private Label label5;
        private ComboBox TingkatPendidikanCombo;
        private Label label4;
        private TextBox TahunLulusText;
        private Label label8;
        private DataGridView MapelGrid;
        private Button NewButton;
        private Button SaveButton;
        private Button DeleteButton;
    }
}