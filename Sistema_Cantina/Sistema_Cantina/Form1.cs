using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;
        /*Declaração de 3 arrays para armazenas 10 produtos,
         * e seus respectivos códigos e valores.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text.Length == 5)
            {
                lstCaixa.Items.Add(txtProduto.Text);
                txtProduto.Text = "";
                txtProduto.Focus();
            }
            /*Inicia com uma condição, se o usuário digitar um código com 5 caracteres (length), esse
             * código é adicionado ao listbox.
             * A propriedade length retorna a quantidade de caracteres.
             * Após o conteúdo ser enviado para o ListBox, o txtbox será limpo e o Focus posiciona
             * o cursor para o TextBox para uma nova digitação
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
        /*Ao entrar no form load será chamado o método*/
        private void carregarArray()
        /*Criação do Método para ser chamado quadno necessário, isso evita repetir várias vezes o mesmo códiogo*/
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot_Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
            /*Códigos, Produtos, Valores referentes aos arrays que foram declarados*/
        }
    }
}
