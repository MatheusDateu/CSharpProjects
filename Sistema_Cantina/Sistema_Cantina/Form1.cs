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
        string[] produtos = new string[6];
        string[] codigo = new string[6];
        double[] valor = new double[6];
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
            if (txtProduto.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtProduto.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                    //Condição, se foi encontrado o produto, ele retorna as informações de acordo com o índice, caso não encontre, aparecerá a mensagem "Produto não encontrado
                }
                else
                {
                    lstCaixa.Items.Add(txtProduto.Text + " -- " + produtos[indice] + "-- R$ " + valor[indice]);
                    //Conteúdo adicionado no ListBox, concatena (+) as informações (código, nome e valor)
                    soma = soma + valor[indice];
                    label3.Text = ("Valor Total R$" + soma);
                    picImagem.ImageLocation = "C:/Imagens/" + codigo[indice] + ".jpg";
                    txtProduto.Text = "";
                    txtProduto.Focus();
                    /*Localização da imagem que deve ser colocada em uma pasta em c: em uma pasta imagens
                     * o textbox será limpo e o Focus posiciona o cursor para o TextBox para uma nova digitação*/
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
        //Ao entrar no form load será chamado o método
        private void carregarArray()
        //Criação do Método para ser chamado quando necessário, isso evita repetir várias vezes o mesmo códiogo
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
            //Códigos, Produtos, Valores referentes aos arrays que foram declarados
        }

        private void lstCaixa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            //Fecha o programa
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
