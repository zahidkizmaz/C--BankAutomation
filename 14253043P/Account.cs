using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253043P
{
    class Account
    {
        List<Account> accounts;
        int clientNumber;
        int overdraft;
        int balance;
        int id;
        Client client;
        int createEffectedRows;
        int updateEffectedRows;
        int deleteEffectedRows;

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");

        public Account() {   }

        public Account(Client client, int overdraft, int balance)
        {
            this.client = client;
            this.Overdraft = overdraft;
            this.Balance = balance;
        }

        public List<Account> getAccounts (Client client)
        { 
            int i = 0;
            accounts = new List<Account>();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select c.id , c.clientName , c.clientSurname, a.overdraft,a.balance, a.id from ClientTBL c,AccountsTBL a where c.id = " + client.Id  + " and c.id = a.clientID";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                accounts.Add(new Account(client,((int)reader.GetDecimal(3)),(int)reader.GetDecimal(4)));
                accounts[i].Id = reader.GetInt32(5);
                i++;
            }
            reader.Close();
            conn.Close();
            return accounts;
        }

        public bool registerNewAccount(Account newAccount)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "insert into AccountsTBL(clientID,overdraft,balance,avaliableBalances) values (" + newAccount.client.Id +"," + newAccount.Overdraft +"," + newAccount.Balance + "," + (newAccount.Overdraft + newAccount.Balance)  +")";
                createEffectedRows = command.ExecuteNonQuery();
                conn.Close();
                if (createEffectedRows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show("Database Error\n" + exc.ToString(),"Erro" );
                return false;
            }
          
        }

        public bool DeleteAccount()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "delete from AccountsTBL where id = " + Id + " and avaliableBalances = 0";
                deleteEffectedRows = command.ExecuteNonQuery();
                if (deleteEffectedRows == 1)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }               
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database Error", "Error");
                return false;
            }
        }
        /*
        public void WithdrawMoney(int amount)
        {
            try
            {
                int avaliableBalance = Balance + Overdraft;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;

                if (amount <= avaliableBalance)
                {
                    if (amount <= Balance)
                    {
                        command.CommandText = "update AccountsTBL set balance = balance - " + amount + " where id = " + Id + "";
                        UpdateEffectedRows = command.ExecuteNonQuery();

                    }
                    else if (amount > Balance)
                    {
                        command.CommandText = "update AccountsTBL set balance = 0 where id = " + Id + "";
                        UpdateEffectedRows = command.ExecuteNonQuery();
                        amount = amount - balance;
                        command.CommandText = "update AccountsTBL set balance = overdraft - " + amount + " where id = " + Id + "";
                        UpdateEffectedRows = command.ExecuteNonQuery();

                    }
                    command.CommandText = "update AccountsTBL set avaliableBalances = overdraft + balance where id = " + Id + "";
                    UpdateEffectedRows = command.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You dont have enough money in the account for this withdraw.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database withdraw error!! ", "Error");
            }
        }
        */
        public override string ToString()
        {
            return "Account Number: " + Id + "  Overdraft Amount: " + Overdraft + "  Balance Amount: " + Balance;
        }

        public int ClientNumber
        {
            get
            {
                return clientNumber;
            }

            set
            {
                clientNumber = value;
            }
        }

        public int Overdraft
        {
            get
            {
                return overdraft;
            }

            set
            {
                overdraft = value;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
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

        public int UpdateEffectedRows
        {
            get
            {
                return updateEffectedRows;
            }

            set
            {
                updateEffectedRows = value;
            }
        }
    }
}
