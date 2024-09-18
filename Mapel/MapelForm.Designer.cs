namespace Latih15_Sekolahku.Mapel
{
    partial class MapelForm
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
            ListGrid = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            MapelIdText = new TextBox();
            MapelNameText = new TextBox();
            label2 = new Label();
            NewButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ListGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListGrid
            // 
            ListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListGrid.Location = new Point(12, 12);
            ListGrid.Name = "ListGrid";
            ListGrid.RowTemplate.Height = 25;
            ListGrid.Size = new Size(293, 218);
            ListGrid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(MapelNameText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MapelIdText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(311, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 189);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Mapel ID";
            // 
            // MapelIdText
            // 
            MapelIdText.BorderStyle = BorderStyle.FixedSingle;
            MapelIdText.Location = new Point(12, 30);
            MapelIdText.Name = "MapelIdText";
            MapelIdText.Size = new Size(86, 23);
            MapelIdText.TabIndex = 1;
            // 
            // MapelNameText
            // 
            MapelNameText.BorderStyle = BorderStyle.FixedSingle;
            MapelNameText.Location = new Point(12, 74);
            MapelNameText.Name = "MapelNameText";
            MapelNameText.Size = new Size(209, 23);
            MapelNameText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Mapel Name";
            // 
            // NewButton
            // 
            NewButton.Location = new Point(312, 207);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 4;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(393, 207);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(474, 207);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MapelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(561, 242);
            Controls.Add(DeleteButton);
            Controls.Add(panel1);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(ListGrid);
            Name = "MapelForm";
            Text = "MapelForm";
            ((System.ComponentModel.ISupportInitialize)ListGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListGrid;
        private Panel panel1;
        private Label label1;
        private TextBox MapelNameText;
        private Label label2;
        private TextBox MapelIdText;
        private Button NewButton;
        private Button SaveButton;
        private Button DeleteButton;
    }
}