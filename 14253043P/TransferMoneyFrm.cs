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
    public partial class TransferMoneyFrm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
        Client client;
        Account account;
        List<Account> accounts = new List<Account>();
        Transaction transaction;
        DateTime time;
        public TransferMoneyFrm()
        {
            InitializeComponent();
        }

        private void TransferMoneyFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClientsT1.Items.Clear();
                cmbClientsT2.Items.Clear();
                cmbAccountsT1.Items.Clear();
                cmbAccountsT2.Items.Clear();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select id, clientName, clientSurname from ClientTBL";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    cmbClientsT1.Items.Add(client);
                    cmbClientsT2.Items.Add(client);

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Error");
            }
        }

        private void cmbClientsT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            client = new Client();
            account = new Account();
            cmbAccountsT1.Items.Clear();
            accounts = account.getAccounts((Client)(cmbClientsT1.SelectedItem));
            cmbAccountsT1.Items.AddRange(accounts.ToArray());
        }

        private void cmbClientsT2_SelectedIndexChanged(object sender, EventArgs e)
        {
            client = new Client();
            account = new Account();
            cmbAccountsT2.Items.Clear();
            accounts = account.getAccounts((Client)(cmbClientsT2.SelectedItem));
            cmbAccountsT2.Items.AddRange(accounts.ToArray());
            if (((Client)cmbClientsT1.SelectedItem).Id == ((Client)cmbClientsT2.SelectedItem).Id)
            {
                cmbAccountsT2.Items.RemoveAt(cmbAccountsT1.SelectedIndex);
            }
        }

        private void cmbAccountsT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            time = new DateTime();
            time = DateTime.Now.Date;
            int result = 0;
            if (cmbClientsT1.SelectedIndex == -1 || cmbAccountsT1.SelectedIndex == -1 || !(int.TryParse(txtbxTransferMoney.Text, out result))
                || cmbClientsT2.SelectedIndex == -1 || cmbAccountsT2.SelectedIndex == -1)
            {
                MessageBox.Show("Pease check your selections and amounts of money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    transaction = new Transaction(((Account)cmbAccountsT1.SelectedItem).Id, 3, decimal.Parse(txtbxTransferMoney.Text), time);
                    transaction.TransferMoney((Account)cmbAccountsT1.SelectedItem, (Account)cmbAccountsT2.SelectedItem);
                    transaction.insertTransaction();
                    transaction.insertTransferTransaction(transaction.Id, ((Account)cmbAccountsT1.SelectedItem).Id, ((Account)cmbAccountsT2.SelectedItem).Id);
                    if (transaction.InsertEffectedRows == 1)
                    {
                        MessageBox.Show("Transfer is completed..", "Congratulations");
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Transfer error!! ", "Error");
                }
               
            }
        }
    }
}
