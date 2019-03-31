using System.Windows.Forms;
using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace PasswordsBase
{
    public partial class RegistrationForm : Form
    {
        SqlConnection sqlConnection;
        private bool same = false;
        public RegistrationForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = true;
            confirmPasLabel.Visible = false;
            if (passwordTB.Text != "")
            {
                if (passwordTB.Text == confirmPasTB.Text)
                {
                    confirmPasLabel.ForeColor = Color.Green;
                    confirmPasLabel.Text = "passwords are the same";
                    confirmPasLabel.Visible = true;
                    same = true;
                }
                else
                {
                    confirmPasLabel.ForeColor = Color.Red;
                    confirmPasLabel.Text = "passwords are not the same";
                    confirmPasLabel.Visible = true;
                    same = false;
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.Show();
        }

        private async void Registration_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "" || passwordTB.Text == "null")
            {
                confirmPasLabel.ForeColor = Color.Red;
                confirmPasLabel.Text = "login or password is empty";
                confirmPasLabel.Visible = true;
            }
            else if (same)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stasi\source\repos\PasswordsBase\PasswordsBase\AutorizationBase.mdf;Integrated Security=True";
                sqlConnection = new SqlConnection(connectionString);
                await sqlConnection.OpenAsync();
                File.Create($"{loginTB.Text}.txt");
                var path = $"{loginTB.Text}.txt";
                SqlCommand command = new SqlCommand("INSERT INTO [AutorizationTable] (Login, Password, [File])VALUES(@Login, @Password, @File)", sqlConnection);
                command.Parameters.AddWithValue("Login", loginTB.Text);
                command.Parameters.AddWithValue("Password", Encoder.Encode(passwordTB.Text));
                command.Parameters.AddWithValue("File", path.ToString());
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("You've signed up!", "Done!", MessageBoxButtons.OK);
            }
        }
    }
}
