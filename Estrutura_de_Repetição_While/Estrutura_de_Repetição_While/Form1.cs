using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_de_Repetição_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 1000)
            {
                c = c + 1;
                lblNumero.Text = Convert.ToString(c);
                lblNumero.Refresh();

                /*Declaração de variável c, inicializada com zero.
                 * *Condição: enquanto o c for menor que 1000 será executado o laço
                 * *Incremento
                 * *Refresh é utilizado para que haja variação de números.
                 */
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNumero.Text = "";
        }
    }
}
