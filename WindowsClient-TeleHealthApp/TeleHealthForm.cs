using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient_TeleHealthApp
{
    public partial class TeleHealthForm : System.Windows.Forms.Form
    {
        public TeleHealthForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //checking if all the fields are validated

        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            if (Name.Text == string.Empty)
            {
                MessageBox.Show("Name cannot be empty.");
            }
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            if (Email.Text == string.Empty)
            {
                MessageBox.Show("Email cannot be empty.");
            }
            else
            {
                try
                {
                    MailAddress email = new MailAddress(Email.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email format");
                }
            }
        }
    }
}
