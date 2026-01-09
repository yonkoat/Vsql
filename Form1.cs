using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web;
using System.Windows.Forms;
using Vsql.Connection;

namespace Vsql
{
    public partial class Form1 : Form
    {
        SqlConnectionManager connectionManager = null;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Освобождаем ресурсы при закрытии формы
            connectionManager?.Dispose();
            connectionManager = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private static string OpenFile()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"C:\Проекты\";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    string fileContent = File.ReadAllText(filePath);

                    return fileContent;
                }
            }
            return null;
        }

        private void ConnectInit_Click(object sender, EventArgs e)
        {
            connectionManager?.Dispose();


            connectionManager = new SqlConnectionManager(ConnectionStringBox.Text);
            connectionManager.OpenConnection();
        }

        private void InitDisconnect_Click(object sender, EventArgs e)
        {
            if(connectionManager == null)
            {
                MessageBox.Show("No connection to begin wtih");
                return;
            }
            connectionManager.CloseConnection();
            connectionManager?.Dispose();

            connectionManager = null;
        }

        private void GetTableBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectionManager == null)
                {
                    MessageBox.Show("Connect to your database first. Then get tables");
                    return;
                }
                
                 string sql = QueryInputBox.Text;
                 //add parameter handling


                 DataTable dataTable = connectionManager.GetDataTable(sql);

                 DataTableGrid.DataSource = dataTable;

                 DataTableGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                 DataTableGrid.AutoResizeColumns();
                

            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
