using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient_TeleHealthApp.Models;

namespace WindowsClient_TeleHealthApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_ClickAsync(object sender, EventArgs e)
        {
            if (Name.Text == string.Empty || Email.Text == string.Empty)
            {
                MessageBox.Show("Name and Email are required fields.");
            }
            else
            {
                Customer customer = new Customer();
                customer.Name = Name.Text;
                customer.Email = Email.Text;
                customer.Address = Address.Text;
                customer.PostalCode = Postalcode.Text;
                customer.Date = Datetime.Value.Date;
                customer.Response = Response.Text;
                var response = PostCustomer(customer);
            }
        }

        private static async Task<HttpResponseMessage> PostCustomer(Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {
                string baseUrl = ConfigurationManager.AppSettings["BaseURL"].ToString();
                client.BaseAddress = new Uri(baseUrl);
                string requestUri = "/api/customer";
                var json = JsonConvert.SerializeObject(customer); 
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = new HttpResponseMessage();
                try
                {
                    response = await client.PostAsync(requestUri, data);
                    MessageBox.Show("Call Response submitted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not submit. " + ex.Message);
                }
                return response;
            }
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

        private void clearbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = String.Empty;
                }
            }
            Response.Text = string.Empty;
        }
    }
}
