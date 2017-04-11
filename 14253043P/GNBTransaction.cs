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
    public partial class GNBTransaction : Form
    {
        SqlConnection conn;
        Client client;
        Account account;
        List<Account> accounts = new List<Account>();
        public GNBTransaction()
        {
            InitializeComponent();
        }

        private void GNBTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                cmbGNBClient.Items.Clear();
                conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select id, clientName, clientSurname from ClientTBL";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbGNBClient.Items.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Error");
            }

        }

        private void cmbGNBClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            client = new Client();
            account = new Account();
            cmbGNBAccount.SelectedIndex = -1;
            cmbGNBAccount.Items.Clear();
            accounts = account.getAccounts((Client)(cmbGNBClient.SelectedItem));
            cmbGNBAccount.Items.AddRange(accounts.ToArray());
        }

        private void btnGetTransactionTable_Click(object sender, EventArgs e)
        {
            AccountTransactionData datafrm = new AccountTransactionData(((Account)cmbGNBAccount.SelectedItem).Id,dateTimePicker1.Value.Date,dateTimePicker2.Value.Date);
            datafrm.ShowDialog();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are deleting "+ ((Account)cmbGNBAccount.SelectedItem).Id + " numbered account. Are you sure ? ","Deleting Account",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (((Account)cmbGNBAccount.SelectedItem).DeleteAccount())
                {
                    MessageBox.Show("Delete is successful.", "Congratulations.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Couldnt delete this account. For deleting transaction account balances must be zero!! ", "Warning");
                }
            }
            else
            {
                
            }

        }
    }
}
