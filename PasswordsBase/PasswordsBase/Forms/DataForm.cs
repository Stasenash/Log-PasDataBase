using System;
using System.Windows.Forms;

namespace PasswordsBase
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            personNameLabel.Text = Autorization.Login;
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
