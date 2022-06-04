using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_II_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonRegister_Click(object sender, EventArgs e) //Register button click
        {
            //kullanici bilgisi bos birakilirsa kullanicidan doldurmasi isteniyor
            if (string.IsNullOrEmpty(textUsername.Text))  
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textNameSurname.Text))
            {
                MessageBox.Show("Please enter your full name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNameSurname.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textPhoneNumber.Text))
            {
                MessageBox.Show("Please enter your phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPhoneNumber.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textAddress.Text))
            {
                MessageBox.Show("Please enter your address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAddress.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textCity.Text))
            {
                MessageBox.Show("Please enter your city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCity.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textCountry.Text))
            {
                MessageBox.Show("Please enter your country", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCountry.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Please enter your email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEmail.Focus();
                return;
            }


            IUserRepository repository = new UserRepository();
            // kullanici bilgilerini dolduruyoruz user objesi icin
            bool result = await repository.Insert(new User() 
            {
                Username = textUsername.Text,
                Password = textPassword.Text,
                Fullname = textNameSurname.Text,
                PhoneNumber = textPhoneNumber.Text,
                Address = textAddress.Text,
                City = textCity.Text,
                Country = textCountry.Text,
                Email = textEmail.Text
            });

            if (result)
            {
                MessageBox.Show("Successfully Signed In", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Sign In", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
