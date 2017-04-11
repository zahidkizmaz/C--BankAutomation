using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253043P
{
    class Transaction
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");

        int id;
        int accountID;
        int transactionTypeID;
        decimal amount;
        DateTime date;
        decimal wthdrawAmount;
        int insertEffectedRows;

        public Transaction() {  }

        public Transaction(int accountID, int transactionTypeID, decimal amount, DateTime date)
        {
            this.AccountID = accountID;
            this.TransactionTypeID = transactionTypeID;
            this.Amount = amount;
            this.Date = date;
        }

        public void insertTransaction()
        {
            try
            {
                date = DateTime.Today;
                string time = String.Format("{0:yyyy}-{1:MM}-{2:dd}", date, date, date);
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "	insert into TransactionTBL(accountID,transactionTypeID,amountofMoney,dateofTransaction) values (" + AccountID +"," + TransactionTypeID + "," + Amount +",'" + time + "')";
                InsertEffectedRows = command.ExecuteNonQuery();
                command.CommandText = "select id from TransactionTBL where accountID = " + AccountID + " and transactionTypeID= "+ TransactionTypeID + " and amountofMoney = " +Amount + " and dateofTransaction= '" + time + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id = reader.GetInt32(0);
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database insert error!!", "Error");
            }
        }
        public void deleteTransaction()
        {
            try
            {
                date = DateTime.Today;
                string time = String.Format("{0:yyyy}-{1:MM}-{2:dd}", date, date, date);
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "	delete from TransactionTBL where accountID = " + AccountID + "and transactionTypeID = " + TransactionTypeID + "and amountofMoney = " + Amount + "and dateofTransaction = '" + time + "'";
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database delete error!!", "Error");
            }
        }

        public void insertTransferTransaction(int transactionID, int sendingAccountID,int receivingAccountID)
        {
            try
            {
                date = DateTime.Today;
                string time = String.Format("{0:yyyy}-{1:MM}-{2:dd}", date, date, date);
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "insert into TransferTBL (transactionID, sendingAccountID,receivingAccountID, dateofTransaction) values (" + transactionID +", " + sendingAccountID + ", " + receivingAccountID + ",'" + time +"')";
                InsertEffectedRows = command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show("Database transfer insert error!!\n\n" + exc.ToString(), "Error");
            }

        }

        public bool checkDay(Account acc,DateTime date)
        {
            try
            {
                date = DateTime.Today;
                string time = String.Format("{0:yyyy}-{1:MM}-{2:dd}", date,date,date);
                decimal amount = 0;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select sum(amountofMoney) from TransactionTBL where dateofTransaction = '" + time + "' and transactionTypeID = 2 and accountID = " + acc.Id + "";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    amount = reader.GetDecimal(0);
                }
                reader.Close();
                conn.Close();
                if (amount <= 750)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                //System.Windows.Forms.MessageBox.Show("Database error!!!", "Error");
            }
        }

        public bool TransferMoney(Account acc1, Account acc2)
        {
            if (WithdrawMoney(acc1))
            {
                DepositMoney(acc2);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Transfer Failed.. ","Transfe Error");
                return false;
            }
         
        }

        public bool DepositMoney(Account acc)
        {
            try
            {
                int avaliableBalance = acc.Balance + acc.Overdraft;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "update AccountsTBL set balance = balance + " + amount + " where id = " + acc.Id + "";
                acc.UpdateEffectedRows = command.ExecuteNonQuery();
                command.CommandText = "update AccountsTBL set avaliableBalances = overdraft + balance where id = " + acc.Id + "";
                acc.UpdateEffectedRows = command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database withdraw error!! ", "Error");
                return false;
            }
        }

        public bool WithdrawMoney(Account acc)
        {
            try
            {
                int avaliableBalance = acc.Balance + acc.Overdraft;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;

                if (amount <= avaliableBalance)
                {
                    if (amount <= acc.Balance)
                    {
                        command.CommandText = "update AccountsTBL set balance = balance - " + amount + " where id = " + acc.Id + "";
                        acc.UpdateEffectedRows = command.ExecuteNonQuery();
                    }
                    else if (amount > acc.Balance)
                    {
                        command.CommandText = "update AccountsTBL set balance = 0 where id = " + acc.Id + "";
                        acc.UpdateEffectedRows = command.ExecuteNonQuery();
                        amount = amount - acc.Balance;
                        command.CommandText = "update AccountsTBL set overdraft = (overdraft - " + amount + ") where id = " + acc.Id + "";
                        acc.UpdateEffectedRows = command.ExecuteNonQuery();
                    }
                    command.CommandText = "update AccountsTBL set avaliableBalances = (overdraft + balance) where id = " + acc.Id + "";
                    acc.UpdateEffectedRows = command.ExecuteNonQuery();
                    conn.Close();
                    WthdrawAmount += amount;
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You dont have enough money in the account for this withdraw.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                    return false;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database withdraw error!! ", "Error");
                return false;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int AccountID
        {
            get
            {
                return accountID;
            }

            set
            {
                accountID = value;
            }
        }

        public int TransactionTypeID
        {
            get
            {
                return transactionTypeID;
            }

            set
            {
                transactionTypeID = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public decimal WthdrawAmount
        {
            get
            {
                return wthdrawAmount;
            }

            set
            {
                wthdrawAmount = value;
            }
        }

        public int InsertEffectedRows
        {
            get
            {
                return insertEffectedRows;
            }

            set
            {
                insertEffectedRows = value;
            }
        }
    }
}
