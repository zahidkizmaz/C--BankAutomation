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
    public partial class ClientHomePage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");

        RegisterClientFrm frm;
        CreateNewAccountFrm accountFrm;
        public ClientHomePage()
        {
            InitializeComponent();
        }

        private void btnNClient_Click(object sender, EventArgs e)
        {
            frm = new RegisterClientFrm();
            frm.ShowDialog();
        }

        private void ClientHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();          
        }

        private void btnUClient_Click(object sender, EventArgs e)
        {
            int resultID = 0;
            if (int.TryParse(txtbxclientUpdateID.Text, out resultID))
            {
                ClientUpdateFrm clientUFRM = new ClientUpdateFrm(resultID);
                clientUFRM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please input the correct client number..", "Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            
        }

        private void btnNAccount_Click(object sender, EventArgs e)
        {
            accountFrm = new CreateNewAccountFrm();
            accountFrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithdrawMoneyFrm frm = new WithdrawMoneyFrm();
            frm.ShowDialog();

        }

        private void btnNTransfer_Click(object sender, EventArgs e)
        {
            TransferMoneyFrm frm = new TransferMoneyFrm();
            frm.ShowDialog();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder str = new StringBuilder();
                DateTime d = dateTimePickerGNB.Value.Date;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select sum(amountofMoney) from TransactionTBL where transactionTypeID = 1 and dateofTransaction = '" + d.ToString("yyyy-MM-dd") + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    decimal depositMoney = reader.GetDecimal(0);
                    str.Append("Total deposited money at " + d.ToShortDateString() + " is: " + depositMoney + "\n");
                }
                reader.Close();
                command.CommandText = "select sum(amountofMoney) from TransactionTBL where transactionTypeID = 2 and dateofTransaction = '" + d.ToString("yyyy-MM-dd") + "'";
                SqlDataReader reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    decimal withdrawMoney = reader2.GetDecimal(0);
                    str.Append("Total withdraw money at " + d.ToShortDateString() + " is: " + withdrawMoney + "\n");
                }
                reader2.Close();
                command.CommandText = "select sum(amountofMoney) from TransactionTBL where transactionTypeID = 3 and dateofTransaction = '" + d.ToString("yyyy-MM-dd") + "'";
                SqlDataReader reader3 = command.ExecuteReader();
                while (reader3.Read())
                {
                    decimal transferMoney = reader3.GetDecimal(0);
                    str.Append("Total transferred money at " + d.ToShortDateString() + " is: " + transferMoney + "\n");
                }
                reader3.Close();
                command.CommandText = "select sum(avaliableBalances) from AccountsTBL";
                SqlDataReader reader4 = command.ExecuteReader();
                while (reader4.Read())
                {
                    decimal sumMoney = reader4.GetDecimal(0);
                    str.Append("Total money in the bank at this moment is: " + sumMoney + "\n");
                }
                reader4.Close();
                conn.Close();

                MessageBox.Show(str.ToString(), d.ToShortDateString() + " Money Flow Table");
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("There has been no transaction record at this date " + dateTimePickerGNB.Value.ToShortDateString(), "No Records Founded!!");
            }
        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {
            GNBTransaction transaction = new GNBTransaction();
            transaction.ShowDialog();
        }
    }
}
