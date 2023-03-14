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

namespace LoginRegister
{
    // structure User
    public struct User
    {
        public int id;
        public string Username;
        public string Email;
        public string Fname;
        public string Lname;
        public string Gender;
        public string Address;
        public string Password;

        public void setUser(int id, string Username, string Email, string Fname, string Lname, string Gender, string Address, string Password)
        {
            this.id = id;
            this.Username = Username;
            this.Email = Email;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Gender = Gender;
            this.Address = Address;
            this.Password = Password;
        }

        public void showUser()
        {
            Console.WriteLine(id);
            Console.WriteLine(Username);
            Console.WriteLine(Email);
            Console.WriteLine(Fname);
            Console.WriteLine(Lname);
        }
    }
    
    public partial class app : Form
    {
        // global variables
        User[] user = new User[10];
        int c = 0;

        public app()
        {
            InitializeComponent();
            lgnPassword.PasswordChar = '*';
            password.PasswordChar = '*';
            confPassword.PasswordChar = '*';
        }

        // validate all user inputs
        public bool isEmpty()
        {
            if (String.IsNullOrEmpty(this.username.Text) == true || 
                String.IsNullOrEmpty(this.email.Text) == true ||
                String.IsNullOrEmpty(this.fname.Text) == true ||
                String.IsNullOrEmpty(this.lname.Text) == true ||
                String.IsNullOrEmpty(this.address.Text) == true ||
                String.IsNullOrEmpty(this.password.Text) == true ||
                String.IsNullOrEmpty(this.confPassword.Text) == true || 
                this.male.Checked == false && 
                this.female.Checked == false && 
                this.other.Checked == false
                )
            {
                return true;
            } else
            {
                return false;
            }
        }

        // check email id
        public bool IsValidEmail(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }

        // check whether user already exists or not
        public bool userExist()
        {
            bool status = false;
            for (int i=0;i<c;i++)
            {
                if (String.Compare(this.username.Text,user[i].Username) == 0 || String.Compare(this.email.Text, user[i].Email) == 0)
                {
                    status = true;
                    break;
                }
            }
            return status;
        }

        // clear all registration form inputs
        public void clearInputs()
        {
            this.username.Clear();
            this.email.Clear();
            this.fname.Clear();
            this.lname.Clear();
            this.address.Clear();
            this.password.Clear();
            this.confPassword.Clear();
            this.male.Checked = false;
            this.female.Checked = false;
            this.other.Checked = false;
        }

        // registration btn click event
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty() == true)
            {
                this.ackRegisterMsg.Text = "Fill all the details.";
            }
            else if (userExist() == true)
            {
                this.ackRegisterMsg.Text = "User already exists. Try Login.";
            }
            else
            {
                // checking gender
                string gender;
                if (this.male.Checked)
                {
                    gender = this.male.Text;
                }
                else if (this.female.Checked)
                {
                    gender = this.female.Text;
                }
                else if (this.other.Checked)
                {
                    gender = this.other.Text;
                }
                else
                {
                    gender = "-";
                }

                // validating email & password and registering the user
                string password;
                if (IsValidEmail(this.email.Text) == false)
                {
                    this.ackRegisterMsg.Text = "Email format didn't matched";
                }
                else if (String.Compare(this.password.Text, this.confPassword.Text) == 0)
                {
                    password = this.password.Text;
                    user[c].setUser(c, this.username.Text, this.email.Text, this.fname.Text, this.lname.Text, gender, this.address.Text, this.password.Text);
                    user[c].showUser();
                    c++;
                    clearInputs();
                    this.ackRegisterMsg.Text = "User registered successfully!!";
                }
                else
                {
                    this.ackRegisterMsg.Text = "Password didn't matched. Try Again.";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tab.SelectedIndex = 1;
        }

        // login btn click event
        private void lgnBtn_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                this.lgnAckBox.Text = "Sorry user dosen't exists.";
            }
            else if (String.IsNullOrEmpty(this.lgnUsername.Text) == true || String.IsNullOrEmpty(this.lgnPassword.Text) == true)
            {
                this.lgnAckBox.Text = "Please enter username & password.";
            }
            else
            {
                for (int i=0;i<c;i++)
                {
                    if (String.Compare(this.lgnUsername.Text,user[i].Username) == 0)
                    {
                        if (String.Compare(this.lgnUsername.Text, user[i].Username) == 0 && String.Compare(this.lgnPassword.Text, user[i].Password) == 0)
                        {
                            this.lgnAckBox.Text = "";
                            MessageBox.Show("Welcome " + lgnUsername);
                            lgnUsername.Clear();
                            lgnPassword.Clear();
                            break;
                        } else
                        {
                            this.lgnAckBox.Text = "Incorrect Password";
                        }    
                    } else
                    {
                        this.lgnAckBox.Text = "Sorry user dosen't exists.";
                    }
                }
            }
        }
    }
}
