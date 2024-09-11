namespace Latih15_Sekolahku.Kelas
{
    partial class KelasForm
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
            FlagText = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            JurusanComboBox = new ComboBox();
            Tingkat12Radio = new RadioButton();
            Tingkat11Radio = new RadioButton();
            Tingkat10Radio = new RadioButton();
            label3 = new Label();
            KelasNameText = new TextBox();
            label2 = new Label();
            KelasIdText = new TextBox();
            label1 = new Label();
            NewButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListDataGrid
            // 
            ListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListDataGrid.Location = new Point(12, 12);
            ListDataGrid.Name = "ListDataGrid";
            ListDataGrid.RowTemplate.Height = 25;
            ListDataGrid.Size = new Size(288, 307);
            ListDataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(FlagText);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(JurusanComboBox);
            panel1.Controls.Add(Tingkat12Radio);
            panel1.Controls.Add(Tingkat11Radio);
            panel1.Controls.Add(Tingkat10Radio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(KelasNameText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(KelasIdText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(312, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 278);
            panel1.TabIndex = 1;
            // 
            // FlagText
            // 
            FlagText.BorderStyle = BorderStyle.FixedSingle;
            FlagText.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FlagText.Location = new Point(12, 202);
            FlagText.Name = "FlagText";
            FlagText.Size = new Size(35, 22);
            FlagText.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "Flag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Jurusan";
            // 
            // JurusanComboBox
            // 
            JurusanComboBox.FormattingEnabled = true;
            JurusanComboBox.Location = new Point(12, 158);
            JurusanComboBox.Name = "JurusanComboBox";
            JurusanComboBox.Size = new Size(213, 23);
            JurusanComboBox.TabIndex = 8;
            // 
            // Tingkat12Radio
            // 
            Tingkat12Radio.AutoSize = true;
            Tingkat12Radio.Location = new Point(107, 118);
            Tingkat12Radio.Name = "Tingkat12Radio";
            Tingkat12Radio.Size = new Size(37, 19);
            Tingkat12Radio.TabIndex = 7;
            Tingkat12Radio.TabStop = true;
            Tingkat12Radio.Text = "12";
            Tingkat12Radio.UseVisualStyleBackColor = true;
            // 
            // Tingkat11Radio
            // 
            Tingkat11Radio.AutoSize = true;
            Tingkat11Radio.Location = new Point(64, 118);
            Tingkat11Radio.Name = "Tingkat11Radio";
            Tingkat11Radio.Size = new Size(37, 19);
            Tingkat11Radio.TabIndex = 6;
            Tingkat11Radio.TabStop = true;
            Tingkat11Radio.Text = "11";
            Tingkat11Radio.UseVisualStyleBackColor = true;
            // 
            // Tingkat10Radio
            // 
            Tingkat10Radio.AutoSize = true;
            Tingkat10Radio.Location = new Point(12, 118);
            Tingkat10Radio.Name = "Tingkat10Radio";
            Tingkat10Radio.Size = new Size(37, 19);
            Tingkat10Radio.TabIndex = 5;
            Tingkat10Radio.TabStop = true;
            Tingkat10Radio.Text = "10";
            Tingkat10Radio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Tingkat";
            // 
            // KelasNameText
            // 
            KelasNameText.BorderStyle = BorderStyle.FixedSingle;
            KelasNameText.Location = new Point(12, 74);
            KelasNameText.Name = "KelasNameText";
            KelasNameText.ReadOnly = true;
            KelasNameText.Size = new Size(213, 23);
            KelasNameText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Kelas Name";
            // 
            // KelasIdText
            // 
            KelasIdText.BorderStyle = BorderStyle.FixedSingle;
            KelasIdText.Location = new Point(12, 30);
            KelasIdText.Name = "KelasIdText";
            KelasIdText.ReadOnly = true;
            KelasIdText.Size = new Size(213, 23);
            KelasIdText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Kelas ID";
            // 
            // NewButton
            // 
            NewButton.Location = new Point(312, 296);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 2;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(393, 296);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(474, 296);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // KelasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(561, 331);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(panel1);
            Controls.Add(ListDataGrid);
            Name = "KelasForm";
            Text = "KelasForm";
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListDataGrid;
        private Panel panel1;
        private Label label3;
        private TextBox KelasNameText;
        private Label label2;
        private TextBox KelasIdText;
        private Label label1;
        private Label label4;
        private ComboBox JurusanComboBox;
        private RadioButton Tingkat12Radio;
        private RadioButton Tingkat11Radio;
        private RadioButton Tingkat10Radio;
        private MaskedTextBox FlagText;
        private Label label5;
        private Button NewButton;
        private Button SaveButton;
        private Button DeleteButton;
    }
}