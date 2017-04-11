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
    public partial class RegisterClientFrm : Form
    {
        Client c;

        public RegisterClientFrm()
        {
            InitializeComponent();
        }

        private void btnCRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxCName.Text.Trim().Length == 0 || txtbxCSurname.Text.Trim().Length == 0 || txtbxCPhone.Text.Trim().Length == 0 || txtbxCMail.Text.Trim().Length == 0 || txtbxCAdress.Text.Trim().Length == 0)
                {
                    MessageBox.Show("All areas must be filled correctly", "Error", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else
                {
                    c = new Client(txtbxCName.Text, txtbxCSurname.Text, txtbxCAdress.Text, txtbxCPhone.Text, txtbxCMail.Text);
                    if (c.CreateEffectedRows == 1)
                    {
                        System.Windows.Forms.MessageBox.Show("Client registered successfully", "Congratulations");
                        this.Hide();
                        this.Dispose();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Client hasnt registered.", "Error");
                    }
                }
                
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Database Collapsed..", "Error");
            }
        }
    }
}
