using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14253043P
{
    public partial class UserUpdate : Form
    {
        User usr;
        public int updateID;

        public UserUpdate()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            usr = new User();

            try
            {
                if (txtbxUuserName.Text.Trim().ToLower() == "" || txtbxUuserName.Text.Trim().ToLower().Length == 0
                    || txtbxUPassword.Text == "" || txtbxUPassword.Text.Length == 0)
                {
                    MessageBox.Show("No areas can be empty. Please fill all the areas.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else
                {
                    usr.UpdateUser(txtbxUuserName.Text.Trim().ToLower(), txtbxUPassword.Text, updateID);
                    int effected = usr.UpdateEffectedRows;
                    if (effected == 1)
                    {
                        MessageBox.Show("Update is successful","Congatulations",MessageBoxButtons.OK,MessageBoxIcon.None);

                    }
                    else
                    {
                        MessageBox.Show("Update failed!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("This username has taken before please try another one. ","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
