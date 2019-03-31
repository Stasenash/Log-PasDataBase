using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PasswordsBase
{
    public partial class DataForm : Form
    {
        private void InitializeLists()
        {
            LessonsList.Items.Clear();
            TimeList.Items.Clear();
            var array = File.ReadAllLines($"{Autorization.Login}.txt");

            foreach (var e in array)
            {
                if (e == "") continue;
                var line = e.Split('&');
                LessonsList.Items.Add(line[0]);
                TimeList.Items.Add(line[1]);
            }
        }

        public DataForm()
        {
            InitializeComponent();
            personNameLabel.Text = Autorization.Login;
            InitializeLists();
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

        private void addLTBtn_Click(object sender, EventArgs e)
        {
            var aform = new AddLP();
            aform.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            InitializeLists();
        }
    }
}
