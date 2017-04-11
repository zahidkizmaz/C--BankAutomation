using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253043P
{
    class User
    {
        String name;
        String password;
        int createEffectedRows;
        int deleteEffectedRows;
        int updateEffectedRows;
        int updateID;
        SqlConnection conn;

        public User()
        {

        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void CreateUser(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            if (Name == null || Password == null)
            {
                System.Windows.Forms.MessageBox.Show("User name and password cant be empty","Please Fill All The Blanks", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Hand);
            }
            else
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "insert into UserTBL values('" + Name + "','" + Password + "')";
                CreateEffectedRows = command.ExecuteNonQuery();
                command.CommandText = "select id from UserTBL where userName = '" + Name + "'";
                conn.Close();
            }
            
        }

        public void DeleteUser(string name)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "delete UserTBL where userName = '" + name + "'";
            DeleteEffectedRows = command.ExecuteNonQuery();
            conn.Close();

        }

        public void UpdateUser(string name, string password,int id)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "update UserTBL set userName = '" + name + "', userPassword = '" + password + "' where id = "+ id + "";
            UpdateEffectedRows = command.ExecuteNonQuery();
            conn.Close();
        }

        public void getAllUsers(List<User> users)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select userName, userPassword from UserTBL";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User(reader.GetString(0).Trim().ToLower(), reader.GetString(1)));
            }
            reader.Close();
            conn.Close();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Trim().Length == 0 || value.Trim() == "")
                {
                    value = null;
                }
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (value.Trim().Length == 0 || value.Trim() == "")
                {
                    value = null;
                }
                password = value;
            }
        }

        public int CreateEffectedRows
        {
            get
            {
                return createEffectedRows;
            }

            set
            {
                createEffectedRows = value;
            }
        }

        public int DeleteEffectedRows
        {
            get
            {
                return deleteEffectedRows;
            }

            set
            {
                deleteEffectedRows = value;
            }
        }

        public int UpdateID
        {
            get
            {
                return updateID;
            }

            set
            {
                updateID = value;
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
