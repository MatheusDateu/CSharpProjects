using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_De_Repetição_DO_While
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
            do
            {
                c = c + 1;
                lblNumero.Text = Convert.ToString(c);
                lblNumero.Refresh();
            }
            while (c < 10000);
            /*Sempre executa pois a condição só aparece no final
             * Só é utilizado quando é necessário testar a condição depois.
             */
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
