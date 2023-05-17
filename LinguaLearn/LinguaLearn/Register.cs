using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinguaLearn
{
    public partial class Register : Form
    {
        public static string UsersPath = "..\\..\\usersJSON";
        public static string RecordsPath = "..\\..\\recordsJSON";
        public static List<User> users = new List<User>();
        public static List<Record> records = new List<Record>();
        bool hasSpecialCharacter = false;
        bool hasUppercaseCharacter = false;
        bool hasNumber= false;
        bool taken = false;

        private LoginForm lg;
        public Register(LoginForm lg = null)
        {
            this.lg = lg;
            InitializeComponent();
            fillUserList(users, UsersPath);
        }

        public static void fillUserList(List<User> users, string filePath)
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string json = File.ReadAllText(filePath);
                List<User> loadedUsers = JsonConvert.DeserializeObject<List<User>>(json);
                users.AddRange(loadedUsers);
            }
        }

        public static void SaveRecords(List<Record> records, string filePath)
        {
            string json = JsonConvert.SerializeObject(records);
            File.WriteAllText(filePath, json);

        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            taken = false;
            hasNumber = false;
            hasSpecialCharacter = false;
            hasUppercaseCharacter = false;

            foreach (char c in pass_txtbox.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    hasSpecialCharacter = true;
                }

                if (char.IsUpper(c))
                {
                    hasUppercaseCharacter = true;
                }
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }

            foreach (User usr in users)
            {
                if (user_textbox.Text == usr.Username)
                {
                    taken = true;
                    break;
                }
            }

            if (!taken)
            {
                if (String.IsNullOrEmpty(user_textbox.Text) || String.IsNullOrEmpty(pass_txtbox.Text))
                {
                    MessageBox.Show("Please enter values in all locations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                if (pass_txtbox.Text.Length < 8)
                {
                    MessageBox.Show("Please enter at least a minimum of 8 characters long.", "Short password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else if (!hasNumber && hasUppercaseCharacter == true && hasSpecialCharacter == true)
                {
                    MessageBox.Show("Please enter at least a minimum of 1 Number.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!hasSpecialCharacter && hasUppercaseCharacter == true && hasNumber == true)
                {
                    MessageBox.Show("Please enter at least a minimum of 1 special character.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (!hasUppercaseCharacter && hasSpecialCharacter == true && hasNumber == true)
                {
                    MessageBox.Show("Please enter at least a minimum of 1 uppercase character.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hasUppercaseCharacter == true && !hasSpecialCharacter && !hasNumber)
                {
                    MessageBox.Show("Please enter  at least  a minimum of 1 Number, and at least a minimum of 1 special character.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!hasUppercaseCharacter && hasSpecialCharacter == true && !hasNumber)
                {
                    MessageBox.Show("Please enter  at least  a minimum of 1 Number and a minimum of 1 uppercase "
                        + "character.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!hasUppercaseCharacter && !hasSpecialCharacter && hasNumber == true)
                {
                    MessageBox.Show("Please enter  at least  a minimum of 1 uppercase "
                        + "character and at least a minimum of 1 special character.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (!hasUppercaseCharacter && !hasSpecialCharacter && !hasNumber)
                {
                    MessageBox.Show("Please enter  at least  a minimum of 1 Number, a minimum of 1 uppercase "
                        + "character and at least a minimum of 1 special character.", "Weak password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User user = new User(user_textbox.Text, pass_txtbox.Text, email_txtbox.Text);
                    users.Add(user);
                    SaveUsers(users, UsersPath);
                    MessageBox.Show("Welcome, " + user_textbox.Text + "! You can now log in.");
                }


            }
            else
            {
                MessageBox.Show("Username already taken. Please try again.");
            }
            user_textbox.Text = "";
            pass_txtbox.Text = "";
            email_txtbox.Text = "";

        }

        public static void SaveUsers(List<User> users, string filePath)
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(filePath, json);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lg == null)
            {
                lg = new LoginForm(this);

            }

            lg.Show();
            this.Hide();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
