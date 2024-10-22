namespace Latih15_Sekolahku.KelasSiswa
{
    partial class KelasSiswaForm
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
            panel1 = new Panel();
            WaliKelasCombo = new ComboBox();
            label3 = new Label();
            TahunAjaranText = new TextBox();
            label2 = new Label();
            KelasCombo = new ComboBox();
            label1 = new Label();
            SiswaGrid = new DataGridView();
            SaveButton = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SiswaGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(WaliKelasCombo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TahunAjaranText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(KelasCombo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 397);
            panel1.TabIndex = 0;
            // 
            // WaliKelasCombo
            // 
            WaliKelasCombo.FormattingEnabled = true;
            WaliKelasCombo.Location = new Point(12, 118);
            WaliKelasCombo.Name = "WaliKelasCombo";
            WaliKelasCombo.Size = new Size(223, 23);
            WaliKelasCombo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Wali Kelas";
            // 
            // TahunAjaranText
            // 
            TahunAjaranText.BorderStyle = BorderStyle.FixedSingle;
            TahunAjaranText.Location = new Point(12, 74);
            TahunAjaranText.Name = "TahunAjaranText";
            TahunAjaranText.Size = new Size(223, 23);
            TahunAjaranText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Tahun Ajaran";
            // 
            // KelasCombo
            // 
            KelasCombo.FormattingEnabled = true;
            KelasCombo.Location = new Point(12, 30);
            KelasCombo.Name = "KelasCombo";
            KelasCombo.Size = new Size(223, 23);
            KelasCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Kelas";
            // 
            // SiswaGrid
            // 
            SiswaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SiswaGrid.Location = new Point(270, 43);
            SiswaGrid.Name = "SiswaGrid";
            SiswaGrid.RowTemplate.Height = 25;
            SiswaGrid.Size = new Size(256, 366);
            SiswaGrid.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Cornsilk;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Location = new Point(713, 415);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(532, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(256, 366);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(270, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 4;
            // 
            // KelasSiswaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(SaveButton);
            Controls.Add(SiswaGrid);
            Controls.Add(panel1);
            Name = "KelasSiswaForm";
            Text = "Kelas - Siswa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SiswaGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox WaliKelasCombo;
        private Label label3;
        private TextBox TahunAjaranText;
        private Label label2;
        private ComboBox KelasCombo;
        private Label label1;
        private DataGridView SiswaGrid;
        private Button SaveButton;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}