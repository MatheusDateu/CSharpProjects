using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            if (usuario == "Admin" && senha == "Admin")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário e senha não coincidem", "Erro de autenticação");
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }
    }
}
