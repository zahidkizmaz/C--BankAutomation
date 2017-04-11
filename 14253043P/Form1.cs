using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14253043P
{
    public partial class HomePage : Form
    {
        ClientHomePage clientHomePage;

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
        List<User> users = new List<User>();
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong happened about our database. " ,"Database Connection Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                clientHomePage = new ClientHomePage();
                Boolean virgin = true;
                User u = new User();
                u.getAllUsers(users);

                foreach (User usr in users)
                {
                    if (txtbxUserName.Text.Trim().ToLower() == usr.Name && txtbxUserPassword.Text == usr.Password)
                    {
                        MessageBox.Show("Welcome " + txtbxUserName.Text, "Goliath National Bank", MessageBoxButtons.OK, MessageBoxIcon.None);
                        cleaningTxtBoxes();
                        clientHomePage.Show();
                        this.Hide();
                        virgin = false;
                        break;
                    }
                }
                if (virgin)
                {
                    MessageBox.Show("Wrong username or password please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("We couldnt handle the users yet. " + exc.ToString() , "Database Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }            
        }


        private void button1_Click(object sender, EventArgs e)
        {          
            try
            {
                User usr = new User();
                usr.CreateUser(txtbxUserName.Text, txtbxUserPassword.Text);
                if (usr.CreateEffectedRows != 0)
                {
                    users.Add(usr);
                    MessageBox.Show("Congratulations " + txtbxUserName.Text + " is created", "Creating a user is succesfull", MessageBoxButtons.OK,MessageBoxIcon.None);
                    cleaningTxtBoxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This username has been used before try another one please!","Username Error", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                User usr = new User();
                usr.getAllUsers(users);
                bool virgin = true;

                foreach (User usrs in users)
                {
                    if (txtbxUserName.Text.Trim().ToLower() == usrs.Name && txtbxUserPassword.Text == usrs.Password)
                    {
                        usrs.DeleteUser(usrs.Name);
                        if (usrs.DeleteEffectedRows == 1)
                        {
                            MessageBox.Show(txtbxUserName.Text + "  is deleted succesfully!", "Congratulations !!", MessageBoxButtons.OK,MessageBoxIcon.None);
                            cleaningTxtBoxes();
                        }
                        virgin = false;
                        break;
                    }
                }
                if (virgin)
                {
                    MessageBox.Show("We couldnt find that user. Please input username and password correctly!", "Username or Password Did Not Match", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something bad happened in the database.. ", "Database Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void cleaningTxtBoxes()
        {
            txtbxUserName.Clear();
            txtbxUserPassword.Clear(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UserUpdate frm = new _14253043P.UserUpdate();
                User usr = new User();
                usr.getAllUsers(users);
                bool virgin = true;
                foreach (User usrs in users)
                {
                    if (txtbxUserName.Text.Trim().ToLower() == usrs.Name && txtbxUserPassword.Text == usrs.Password)
                    {
                        
                        SqlCommand cmmnd = new SqlCommand();
                        cmmnd.Connection = conn;
                        cmmnd.CommandText = "select id from UserTBL where userName = '" + txtbxUserName.Text + "'";
                        SqlDataReader reader = cmmnd.ExecuteReader();
                        while (reader.Read())
                        {
                            frm.updateID = reader.GetInt32(0);
                        }
                        reader.Close();
  
                        frm.ShowDialog();
                        virgin = false;
                        break;
                    }
                }
                if (virgin)
                {
                    MessageBox.Show("We couldnt find that user. Please input username and password correctly!", "Username or Password Did Not Match", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something bad happened in the database..\n " + exp.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
