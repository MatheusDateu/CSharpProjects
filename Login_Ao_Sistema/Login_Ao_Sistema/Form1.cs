using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Ao_Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUser.Text;
            senha = txtSenha.Text;
            if (usuario == "Admin" && senha == "Admin")
            {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;
                /*Declaração da variável e atribuição
                 * Condição - Se o usuário e senha forem iguais a Admin,
                 * Será chamado o Form2.
                 * Ou seja, ele terá acesso ao sistema, somente se o usuário e senha estiver correto
                 */
            }
        }
    }
}
