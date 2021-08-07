using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_Ao_Sistema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você voltará à tela de login!", "AVISO: você está saindo deste usuário!");
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }
    }
}
