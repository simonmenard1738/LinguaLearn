using Newtonsoft.Json;
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

namespace LinguaLearn
{
    public partial class LoginForm : Form
    {
        private Register rg;
        public LoginForm(Register rg = null)
        {
            this.rg = rg;
            InitializeComponent();
            fillUserList(users, UsersPath);
        }
        public static string UsersPath = "..\\..\\usersJSON";
        public static string RecordsPath = "..\\..\\recordsJSON";
        public static List<User> users = new List<User>();
        public static List<Record> records = new List<Record>();

        //The save methods are to put the User or Record objects into their JSON files, 
        //you can use ur own filepath and list of Users/Records

        

        public static void SaveRecords(List<Record> records, string filePath)
        {
            string json = JsonConvert.SerializeObject(records);
            File.WriteAllText(filePath, json);

        }

        //The fill list methods is so to fill the list with whatever was previously in the JSON file.
        // You should put these in the forms Load event
        public static void fillUserList(List<User> users, string filePath)
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string json = File.ReadAllText(filePath);
                List<User> loadedUsers = JsonConvert.DeserializeObject<List<User>>(json);
                users.AddRange(loadedUsers);
            }
        }

        public static void fillRecordsList(List<Record> records, string filePath)
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string json = File.ReadAllText(filePath);
                List<Record> loadedRecords = JsonConvert.DeserializeObject<List<Record>>(json);
                records.AddRange(loadedRecords);
            }
        }


        //The load methods are how you retrieve the User or Record Object from their own JSON files
        public static User LoadUser(string filePath, string username)
        {
            string json = File.ReadAllText(filePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            User user = users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show($"This user does not exist: '{username}'.");
                return null;
            }
            else
            {
                return user;
            }
        }
        


        private void get_btn_Click(object sender, EventArgs e)
        {

            string username = getUname_txtbox.Text;
            User usr = LoadUser(UsersPath, username);
            if (usr != null)
            {
                if (usr.Password == getPword_txtbox.Text)
                {
                    MessageBox.Show($"Welcome, {username}");
                    mainForm a = new mainForm(usr);
                    a.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Incorrect password. Please try again.");
                }   
            }
        }

        private void goRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rg == null)
            {
                rg = new Register(this);

            }

            rg.Show();
            this.Hide();
        }
    }
}
