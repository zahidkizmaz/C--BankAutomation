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
    public partial class AccountTransactionData : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
        int accountID;
        DateTime date1;
        DateTime date2;

        public AccountTransactionData(int accountID, DateTime date1, DateTime date2)
        {
            this.accountID = accountID;
            this.date1 = date1;
            this.date2 = date2;
            InitializeComponent();
        }

        private void AccountTransactionData_Load(object sender, EventArgs e)
        {
            try
            {
                string time1 = String.Format("{0:yyyy}-{1:MM}-{2:dd}", date1, date1, date1);
                string time2 = String.Format("{0:yyyy}-{1:MM}-{2:dd}", date2, date2, date2);
                conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
                conn.Open();
                //SqlCommand command = new SqlCommand();
                //command.Connection = conn;
                //command.CommandText = "select tr.accountID,ty.transactionType, tr.amountofMoney, tr.dateofTransaction from TransactionTBL tr , TransactionTypeTBL ty where tr.accountID = " +  accountID + " and tr.transactionTypeID = ty.id and tr.dateofTransaction >= '2016-06-02' and tr.dateofTransaction <= '2016-06-03'";
                //string datas = "select tr.accountID as 'Account Number',ty.transactionType as 'Type of Transaction', tr.amountofMoney as 'Amount of Money', tr.dateofTransaction as 'Date of Transaction' from TransactionTBL tr , TransactionTypeTBL ty where tr.accountID = " + accountID + " and tr.transactionTypeID = ty.id and tr.dateofTransaction >= '" + time1 + "' and tr.dateofTransaction <= '" + time2 + "'";
                string data = "select tr.accountID as 'Account Number',ty.transactionType as 'Type of Transaction', tr.amountofMoney as 'Amount of Money', tr.dateofTransaction as 'Date of Transaction', receivingAccountID as 'Transferred Account Number' from TransactionTBL tr inner join TransactionTypeTBL ty on tr.transactionTypeID = ty.id left join TransferTBL tf on tf.transactionID = tr.id  where tr.accountID = " + accountID + " and tr.dateofTransaction >= '" + time1 + "' and tr.dateofTransaction <= '" + time2 + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(data, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database error!!! ", "Error");
            }
        }
    }
}
