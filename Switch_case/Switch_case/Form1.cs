using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                        MessageBox.Show("Você esolheu Domingo que é o primeiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                case "Segunda":
                        MessageBox.Show("Você escolheu Segunda que é o segundo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                case "Terça":
                        MessageBox.Show("Você escolheu Terça que é o terceiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                case "Quarta":
                        MessageBox.Show("Você escolheu Quarta que é o quarto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                case "Quinta":
                        MessageBox.Show("Você escolheu Quinta que é o quinto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                case "Sexta":
                        MessageBox.Show("Você escolheu Sexta que é o sexto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                case "Sábado":
                        MessageBox.Show("Você escolheu Sábado que é o sétimo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}
