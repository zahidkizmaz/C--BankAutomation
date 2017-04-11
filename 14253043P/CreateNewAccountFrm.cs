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
    public partial class CreateNewAccountFrm : Form
    {
        SqlConnection conn;
        Account account;
        public CreateNewAccountFrm()
        {
            InitializeComponent();
        }

        private void CreateNewAccountFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClient.Items.Clear();
                conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select id, clientName, clientSurname from ClientTBL";
                SqlDataReader reader = command.ExecuteReader();              
                while (reader.Read())
                {
                    //cmbClient.Items.Add("Client Nu: " + reader.GetInt32(0) + "  Name:  " + reader.GetString(1) + "  " + reader.GetString(2));
                    cmbClient.Items.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Error");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                if (cmbClient.SelectedIndex == -1 || !(int.TryParse(txtbxBalance.Text, out result)) || !(int.TryParse(txtbxOverdraft.Text,out result)))
                {
                    MessageBox.Show("Please fill all ares correctly!..", "Error", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else
                {
                    account = new Account(((Client)cmbClient.SelectedItem), int.Parse(txtbxOverdraft.Text), int.Parse(txtbxBalance.Text));
                    if (account.registerNewAccount(account))
                    {
                        MessageBox.Show("Account created successfully!!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Please correct the values", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("Accoun couldnt created \n" + exc.ToString(),"Error");
            }
            
        }
    }
}
