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
    public partial class WithdrawMoneyFrm : Form
    {
        SqlConnection conn;
        Client client;
        Account account;
        List<Account> accounts;
        Transaction transaction;
        DateTime time;
        public WithdrawMoneyFrm()
        {
            InitializeComponent();
        }

        private void WithdrawMoneyFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClientList.Items.Clear();
                conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select id, clientName, clientSurname from ClientTBL";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbClientList.Items.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Error");
            }
        }

        private void cmbClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            client = new Client();
            account = new Account();
            cmbAccountList.Items.Clear();
            accounts = account.getAccounts((Client)(cmbClientList.SelectedItem));
            cmbAccountList.Items.AddRange(accounts.ToArray());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            time = new DateTime();
            time = DateTime.Now.Date;
            int result = 0;
            if (cmbAccountList.SelectedIndex == -1 || cmbClientList.SelectedIndex == -1 || !(int.TryParse(txtbxWtihdrawMoney.Text, out result)))
            {
                MessageBox.Show("Pease check your selections and amounts of money.","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {
                transaction = new Transaction(((Account)cmbAccountList.SelectedItem).Id, 2, decimal.Parse(txtbxWtihdrawMoney.Text), time);
                transaction.insertTransaction();
                if (transaction.checkDay((Account)cmbAccountList.SelectedItem,time))
                {
                    transaction.WithdrawMoney(((Account)cmbAccountList.SelectedItem));
                }
                else
                {
                    MessageBox.Show("You reached your maximum amount today. You cant withdraw money over 750 per day..","Withdaw error!!");
                    transaction.deleteTransaction();
                }
                //((Account)cmbAccountList.SelectedItem).WithdrawMoney(int.Parse(txtbxWtihdrawMoney.Text));
                if (((Account)cmbAccountList.SelectedItem).UpdateEffectedRows == 1)
                {
                    MessageBox.Show("Withdraw is successfull!", "Congratulations", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Couldnt withdraw!!","Error");
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            time = new DateTime();
            time = DateTime.Now.Date;
            int result = 0;
            if (cmbAccountList.SelectedIndex == -1 || cmbClientList.SelectedIndex == -1 || !(int.TryParse(txtbxWtihdrawMoney.Text, out result)))
            {
                MessageBox.Show("Pease check your selections and amounts of money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                transaction = new Transaction(((Account)cmbAccountList.SelectedItem).Id, 1, decimal.Parse(txtbxWtihdrawMoney.Text), time);
                transaction.DepositMoney((Account)cmbAccountList.SelectedItem);
                transaction.insertTransaction();
                if (((Account)cmbAccountList.SelectedItem).UpdateEffectedRows == 1)
                {
                    MessageBox.Show("Deposit is successfull!", "Congratulations", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Couldnt deposit!!", "Error");
                }
            }
        }
    }
}
