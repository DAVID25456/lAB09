using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG02_LAB09_MOSQUITO_LUIS
{
    public partial class Form1 : Form
    {
        //Declaracion de variables globales
        string strUsuario = "Admin";
        string strPassword = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.ToUpper() == strUsuario.ToUpper() && txtpassword.Text == strPassword)
            {
                string a = txtusuario.Text;
                string b = txtpassword.Text;

                MDIParent1 mDI = new MDIParent1();
                mDI.Show();

            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
