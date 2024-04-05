using MySql.Data.MySqlClient;

namespace CityLibraryInfoSystem
{
    public partial class MainForm : Form
    {
        public Form? ConnectionToDatabase;

        public MainForm()
        {
            InitializeComponent();
            Resize += MainForm_Resize;
        }

        private void MainForm_Resize(object? sender, EventArgs e)
        {
            comboBox_TablesName.Size = new Size(ClientSize.Width - 200, 39);
        }

        public MainForm(Form form)
        {
            InitializeComponent();
            ConnectionToDatabase = form;
            ConnectionToDatabase.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BasicDatabaseValues.ActiveDatabase.Open();
            AddTableNames();
            DisplayTable();
        }

        private void AddTableNames()
        {
            comboBox_TablesName.DataSource = BasicDatabaseValues.ActiveDatabase.GetTableNames();
            comboBox_TablesName.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionToDatabase?.Close();
        }

        private void comboBox_TablesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void DisplayTable()
        {
;            dataGridView_Table.DataSource = null;
            dataGridView_Table.DataSource = BasicDatabaseValues.ActiveDatabase.GetTable(comboBox_TablesName.SelectedItem.ToString()!);
        }
    }
}
