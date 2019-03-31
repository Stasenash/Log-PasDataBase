using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsBase
{
    public partial class AddLP : Form
    {
        public AddLP()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (lessonTB.Text == "" || timeTB.Text == "")
                emptyLesTime.Visible = true;
            else
            {
                File.AppendAllText($"{Autorization.Login}.txt", $"{Environment.NewLine}{lessonTB.Text}&{timeTB.Text}");
                this.Close();
            }
        }
    }
}
