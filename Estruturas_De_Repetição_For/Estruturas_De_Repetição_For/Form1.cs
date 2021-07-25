using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas_De_Repetição_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < 50; contador++)
            {
                MessageBox.Show("O valor de contador é= " + contador);
                Console.WriteLine("O valor de contador é= " + contador);
                //WriteLine é o comando que pula linha.
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
