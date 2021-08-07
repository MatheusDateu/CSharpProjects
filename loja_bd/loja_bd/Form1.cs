using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loja_bd
{
    public partial class FormDesign : Form
    {
        public FormDesign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection
            {
                ConnectionString = Properties.Settings.Default.CST
            };
            /*Criando conexao nome con,
             * Recuperando junto às propriedades, após digitar o Default observe que aparecerá
             * uma lista de opções e nesta lista deve aparecer o nome que escolhermos nas
             * Propriedades/Configurações do projeto anteriormente. No caso CS */
            try
            {
                con.Open();
                con.Close();

                MessageBox.Show("A conexão foi realizada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Falha na conexão= {0}", ex.Message));

                /*Abriu e fechou a conexão
                 * Exibir mensagem se a conexão foi realizada com sucesso.
                 * caso dê algum erro ele irá direto para o catch e exibirá
                 * a mensagem de falha */
            }
        }
    }
}
