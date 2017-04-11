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
    public partial class ClientUpdateFrm : Form
    {
        Client client;
        int id;
        public ClientUpdateFrm()
        {
            InitializeComponent();
        }
        public ClientUpdateFrm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ClientUpdateFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Client();
                client.UpdateClient(id, txtbxCUpdateName.Text, txtbxCUpdateSurname.Text, txtbxCUpdateAdress.Text, txtbxCUpdatePhone.Text, txtbxCUpdateMail.Text);
                MessageBox.Show("You have successfully updated the client that has client No: " + id, "Update is Successfull" );
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Client number couldnt find int the database, please make sure that you got the right number.", "Client Number Couldnt Found!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
           
        }
    }
}
