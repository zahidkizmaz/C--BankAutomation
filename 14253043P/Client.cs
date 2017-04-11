using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253043P
{
    class Client
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GoliathNationalBank;Integrated Security=True");

        int id;
        string name;
        string surname;
        string adress;
        string phone;
        string mail;
        int createEffectedRows;
        int updateEffectedRows;

        public Client() { }
        public Client(int id, string name, string surname)
        {
            this.Id = id;
            this.name = name;
            this.surname = surname;
        }

        public Client(string name, string surname, string adress, string phone, string mail)
        {
            this.Name = name;
            this.Surname = surname;
            this.Adress = adress;
            this.Phone = phone;
            this.Mail = mail;
           
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "insert into ClientTBL values('" + Name + "','" + Surname + "','" + Adress + "','" + Phone + "','" + Mail + "')";
            CreateEffectedRows = command.ExecuteNonQuery();
            conn.Close(); 
        }

        public void UpdateClient (int id, string cname, string csname, string cadress, string cphone , string cmail)
        {
            
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            /*
            command.CommandText = "select clientName,clientSurname,clientAdress,clientPhone,clientMail from ClientTBL where id =" + id +"";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cname = reader.GetString(0);
                csname = reader.GetString(1);
                cadress = reader.GetString(2);
                cphone = reader.GetString(3);
                cmail = reader.GetString(4);
            }
            reader.Close();
            */
            command.CommandText = "	update ClientTBL set clientName = '" + cname + "', clientSurname = '" + csname + "', clientAdress = '" + cadress + "', clientPhone = '" + cphone + "',clientMail = '" + cmail + "' where id =" + id + "";
            UpdateEffectedRows = command.ExecuteNonQuery();
            conn.Close();
        }

        public override string ToString()
        {
            return "Client Nu: " + Id + "  Name:  " + Name + "  " + Surname;
        }


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
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
    }
}
