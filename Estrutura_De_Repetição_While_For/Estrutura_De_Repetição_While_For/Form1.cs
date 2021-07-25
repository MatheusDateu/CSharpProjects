using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_De_Repetição_While_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2016; contador >= 1950; contador--)
            {
                cboAno.Items.Add(contador);
            }
        }
        /*Declaração da variável coontador do tipo inteiro
* laço For - Atibuído o valor 2016 e vai até 1950.
* Em seguida os intens são adicionados no Contaor.
*/
        private void btnProxima_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2021; contador >= 1950; contador--)
            {
                cboAno.Items.Add(contador);
            }
        }
        /*Declação da variável contador do tipo inteiro
         * Laço FOR - Atribuído o valor de 2021 (ano), até que o ano seja
         * maior ou igual a 1950, o contador vai fazendo um decremento.
         * Ou seja, começa em 2021 e vai até 1950.
         * En seguida, os itens são adicionados no contador.
         */
    }
}
