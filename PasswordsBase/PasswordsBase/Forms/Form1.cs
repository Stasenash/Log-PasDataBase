using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PasswordsBase
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stasi\source\repos\PasswordsBase\PasswordsBase\AutorizationBase.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [AutorizationTable]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    if (loginTB.Text == Convert.ToString(sqlReader["Login"])
                        && passwordTB.Text == Encoder.Decode(Convert.ToString(sqlReader["Password"])))
                    {
                        Autorization.Login = loginTB.Text;
                        var dform = new DataForm();
                        this.Hide();
                        dform.Show(); 
                    }
                    else
                    {
                        incorrectLabel.Visible = true;
                        //MessageBox.Show("Your login or password is wrong", "Sign In error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var rform = new RegistrationForm();
            this.Hide();
            rform.Show();
        }
    }
}
