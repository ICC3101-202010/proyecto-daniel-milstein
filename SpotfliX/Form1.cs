using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace SpotfliX
{
    public partial class Form1 : Form
    {
        public bool UserLogIn = false;
        public bool AdminLogIn = false;
        public User thisUser;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserRegBox_TextChanged(object sender, EventArgs e)
        {
           
            bool usertaken = Spotflix.GetUserDB.ContainsKey(UserRegBox.Text);


            if (usertaken == true)
            {
                UserAvailableLabel.Text = "User taken";
                UserAvailableLabel.ForeColor = Color.Red;
            }

            else
            {
                UserAvailableLabel.Text = "User available";
                UserAvailableLabel.ForeColor = Color.Green;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UserRegBox.Text;
            string password = PassRegBox.Text;
            string email = EmailRegBox.Text;
            bool privateAc = PvtRegCheck.Checked;
            bool premium = PremiumCheck.Checked;

            try
            {
                User user = new User(username, email, password, privateAc, premium, false);
                Spotflix.AddUser(user);
                RegErrorLabel.Show();
                panelRegister.Hide();
                panelInicio.Show();
            }
            catch (Exception)
            {
                RegErrorLabel.Text = "Missing or incorrect\nfields";
                RegErrorLabel.Show();
                
            }

            
        }

        private void GoToRegButton_Click(object sender, EventArgs e)
        {
            panelInicio.Hide();
            panelRegister.Show();
        }

        

        private void EmailRegBox_TextChanged(object sender, EventArgs e)
        {
            TextBox emailBox = (TextBox)sender;
            string email = emailBox.Text;

            bool validEmail = RegexUtilities.IsValidEmail(email);


            if (Email2RegBox.Text == "")
            {
                if (validEmail == true)
                {
                    EmailSameLabel.Text = "✔";
                    EmailSameLabel.ForeColor = Color.Green;
                }

                else
                {
                    EmailSameLabel.Text = "✗ Invalid email";
                    EmailSameLabel.ForeColor = Color.Red;
                } 
            }

            else
            {
                if (EmailRegBox.Text == Email2RegBox.Text && validEmail)
                {
                    EmailSameLabel.Text = "✔";
                    EmailSameLabel.ForeColor = Color.Green;
                    EmailSame2Label.Text = "✔";
                    EmailSame2Label.ForeColor = Color.Green;
                }

                else
                {
                    EmailSameLabel.Text = "✗";
                    EmailSameLabel.ForeColor = Color.Red;
                    EmailSame2Label.Text = "✗";
                    EmailSame2Label.ForeColor = Color.Red;
                }
            }

            
        }

        private void Email2RegBox_TextChanged(object sender, EventArgs e)
        {
            TextBox emailBox = (TextBox)sender;
            string email = emailBox.Text;

            bool validEmail = RegexUtilities.IsValidEmail(email);

            if (validEmail == true)
            {
                EmailSame2Label.Text = "✔";
                EmailSame2Label.ForeColor = Color.Green;
            }

            else
            {
                EmailSame2Label.Text = "✗";
                EmailSame2Label.ForeColor = Color.Red;
            }

            if (EmailRegBox.Text == Email2RegBox.Text && validEmail)
            {
                EmailSameLabel.Text = "✔";
                EmailSameLabel.ForeColor = Color.Green;
                EmailSame2Label.Text = "✔";
                EmailSame2Label.ForeColor = Color.Green;
            }

            else
            {
                EmailSameLabel.Text = "✗";
                EmailSameLabel.ForeColor = Color.Red;
                EmailSame2Label.Text = "✗";
                EmailSame2Label.ForeColor = Color.Red;
            }
        }

        private void BackRegButton_Click(object sender, EventArgs e)
        {
            panelRegister.Hide();
            panelInicio.Show();
            UserRegBox.Clear();
            PassRegBox.Clear();
            Pass2RegBox.Clear();
            EmailRegBox.Clear();
            Email2RegBox.Clear();
            RegErrorLabel.Hide();





        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            string password = PassBox.Text;
            
            try
            {
                string activeUser = Spotflix.AdminLogIn(username, password);
                if (activeUser != "")
                {
                    AdminLogIn = true;
                }
                else
                {
                    activeUser = Spotflix.LogIn(username, password);
                    UserLogIn = true;
                }
                thisUser = Spotflix.GetUserDB[activeUser];
                FormMain main = new FormMain();
                main.ActiveUser = thisUser;
                main.Show();
                Hide();
            }

            catch
            {
                
            }

            
        }

        private void PassRegBox_TextChanged(object sender, EventArgs e)
        {

            if (Pass2RegBox.Text != "")
            {
                if (PassRegBox.Text == Pass2RegBox.Text)
                {
                    SamePass2Label.Text = "✔";
                    SamePass2Label.ForeColor = Color.Green;
                    SamePassLabel.Text = "✔";
                    SamePassLabel.ForeColor = Color.Green;
                }

                else
                {
                    SamePassLabel.Text = "✗";
                    SamePassLabel.ForeColor = Color.Red;
                    SamePass2Label.Text = "✗";
                    SamePass2Label.ForeColor = Color.Red;
                } 
            }
        }

        private void Pass2RegBox_TextChanged(object sender, EventArgs e)
        {
            if (PassRegBox.Text == Pass2RegBox.Text)
            {
                SamePass2Label.Text = "✔";
                SamePass2Label.ForeColor = Color.Green;
                SamePassLabel.Text = "✔";
                SamePassLabel.ForeColor = Color.Green;
            }

            else
            {
                SamePassLabel.Text = "✗";
                SamePassLabel.ForeColor = Color.Red;
                SamePass2Label.Text = "✗";
                SamePass2Label.ForeColor = Color.Red;
            }

        }
    }
}
