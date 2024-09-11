namespace Latih15_Sekolahku.Jurusan
{
    partial class JurusanForm
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
            CodeText = new MaskedTextBox();
            label3 = new Label();
            JurusanNameText = new TextBox();
            label2 = new Label();
            JurusanIdText = new TextBox();
            label1 = new Label();
            NewButton = new Button();
            SaveButton = new Button();
            DeletButton = new Button();
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
            ListDataGrid.Size = new Size(281, 227);
            ListDataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CodeText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(JurusanNameText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(JurusanIdText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(299, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 198);
            panel1.TabIndex = 1;
            // 
            // CodeText
            // 
            CodeText.BorderStyle = BorderStyle.FixedSingle;
            CodeText.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CodeText.Location = new Point(12, 118);
            CodeText.Name = "CodeText";
            CodeText.Size = new Size(35, 22);
            CodeText.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Code";
            // 
            // JurusanNameText
            // 
            JurusanNameText.BorderStyle = BorderStyle.FixedSingle;
            JurusanNameText.Location = new Point(12, 74);
            JurusanNameText.Name = "JurusanNameText";
            JurusanNameText.Size = new Size(167, 23);
            JurusanNameText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Jurusan Name";
            // 
            // JurusanIdText
            // 
            JurusanIdText.BorderStyle = BorderStyle.FixedSingle;
            JurusanIdText.Location = new Point(12, 30);
            JurusanIdText.Name = "JurusanIdText";
            JurusanIdText.ReadOnly = true;
            JurusanIdText.Size = new Size(167, 23);
            JurusanIdText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Jurusan ID";
            // 
            // NewButton
            // 
            NewButton.Location = new Point(298, 216);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(59, 23);
            NewButton.TabIndex = 2;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(363, 217);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(59, 23);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeletButton
            // 
            DeletButton.Location = new Point(428, 216);
            DeletButton.Name = "DeletButton";
            DeletButton.Size = new Size(59, 23);
            DeletButton.TabIndex = 4;
            DeletButton.Text = "Delete";
            DeletButton.UseVisualStyleBackColor = true;
            // 
            // JurusanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(502, 252);
            Controls.Add(DeletButton);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(panel1);
            Controls.Add(ListDataGrid);
            Name = "JurusanForm";
            Text = "JurusanForm";
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListDataGrid;
        private Panel panel1;
        private TextBox JurusanNameText;
        private Label label2;
        private TextBox JurusanIdText;
        private Label label1;
        private Button NewButton;
        private Button SaveButton;
        private Button DeletButton;
        private Label label3;
        private MaskedTextBox CodeText;
    }
}