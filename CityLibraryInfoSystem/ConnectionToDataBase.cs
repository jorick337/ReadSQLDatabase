namespace CityLibraryInfoSystem
{
    public partial class ConnectionToDataBase : Form
    {

        public ConnectionToDataBase()
        {
            InitializeComponent();
        }

        private void MergeData()
        {
            string link = "";

            if (CheckingForValueNull())
            {
                label_HelpText.Text = "��������� ��� ����";
            }
            else
            {
                link = "server=" + textBox_ServerName.Text + ";";
                link += "user=" + textBox_NameUser.Text + ";";
                link += "database=" + textBox_NameDatabase.Text + ";";
                link += "password=" + textBox_PasswordUser.Text + ";";
            }

            BasicDatabaseValues.LoadDatabase(link);
        }

        private bool CheckingForValueNull()
        {
            if (textBox_NameDatabase.Text == null || textBox_PasswordUser.Text == null || textBox_NameUser == null || textBox_ServerName == null)
            {
                return true;
            }
            else return false;
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            MergeData();

            MainForm MainForm = new MainForm(this);
            MainForm.Show();
        }

        private void textBox_ServerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
