namespace CityLibraryInfoSystem
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
            comboBox_TablesName = new ComboBox();
            flowLayoutPanel_Left = new FlowLayoutPanel();
            dataGridView_Table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Table).BeginInit();
            SuspendLayout();
            // 
            // comboBox_TablesName
            // 
            comboBox_TablesName.Dock = DockStyle.Right;
            comboBox_TablesName.FormattingEnabled = true;
            comboBox_TablesName.Location = new Point(202, 0);
            comboBox_TablesName.Name = "comboBox_TablesName";
            comboBox_TablesName.Size = new Size(482, 39);
            comboBox_TablesName.TabIndex = 1;
            comboBox_TablesName.SelectedIndexChanged += comboBox_TablesName_SelectedIndexChanged;
            // 
            // flowLayoutPanel_Left
            // 
            flowLayoutPanel_Left.Dock = DockStyle.Left;
            flowLayoutPanel_Left.Location = new Point(0, 0);
            flowLayoutPanel_Left.Name = "flowLayoutPanel_Left";
            flowLayoutPanel_Left.Size = new Size(196, 465);
            flowLayoutPanel_Left.TabIndex = 0;
            // 
            // dataGridView_Table
            // 
            dataGridView_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Table.Location = new Point(202, 45);
            dataGridView_Table.Name = "dataGridView_Table";
            dataGridView_Table.Size = new Size(482, 420);
            dataGridView_Table.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 465);
            Controls.Add(dataGridView_Table);
            Controls.Add(flowLayoutPanel_Left);
            Controls.Add(comboBox_TablesName);
            Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(8, 7, 8, 7);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CityLibraryInfoSystem";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_TablesName;
        private FlowLayoutPanel flowLayoutPanel_Left;
        private DataGridView dataGridView_Table;
    }
}