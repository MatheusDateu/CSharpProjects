using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estrutura_De_Repetição_While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2021;
            while (contador >= 1950)
            {
                cboAnos.Items.Add(contador);
                contador--;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*Declação de variável contador do tipo inteiro, onde
* foi atribuído o valor de 2021 (ano),
* Enqautno o contador for maior ou igual a 1950,
* O contador faz o decremento.
* Ou seja, começa 2021 e vai até 1950.
* Intens são adicionador no contador.
*/
    }
}
