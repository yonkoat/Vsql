using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Vsql
{
    public partial class Form1 : Form
    {
        private SqlConnection SqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            SqlConnection.Open();

            if(SqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Conection is now opened!");
            }
        }

        private static string OpenFile()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"C:\Проекты\";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.FileName;
                    string fileName = Path.GetFileName(filePath) ;
                    string fileContent = File.ReadAllText(filePath);

                    return fileContent;
                }
            }
            return null;
        }

        private void SearchFile_Click(object sender, EventArgs e)
        {
            ContentOutputBox.Text = OpenFile();
        }

        private void FileSavedToDir_Click(object sender, EventArgs e)
        {

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {

        }
    }
}
