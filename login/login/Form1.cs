using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            if (bxusuario.Text == "wallace" && bxsenha.Text == "monica")
            {

            }
            else
            {
                MessageBox.Show("usuario e senha incorretos !!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
