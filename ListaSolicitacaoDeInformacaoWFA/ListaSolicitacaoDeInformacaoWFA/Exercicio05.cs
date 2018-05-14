using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSolicitacaoDeInformacaoWFA
{
    public partial class Exercicio05 : Form
    {
        /* 5.Solicitar nome do carro, valor do carro, valor de cada parcela e a quantidade de
            meses em que o carro foi financiado, ao final deve ser apresentado:

           a.Nome do carro;
           b.Valor do carro;
           c.Valor de cada parcela;
           d.Quantidade de parcelas;
           e.Valor total do financiamento;
           f.Diferença entre o valor total do financiamento e valor do carro. */

        double valorDoCarro = 0, valorDeCadaParcela = 0;
        int quantidadeDeParcelas = 0;
        

        public Exercicio05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInfrmacao();
            string textao = "";
            double valorTotalDoFinanciamento = valorDeCadaParcela * quantidadeDeParcelas;
            double diferencaDoValorTotal = valorTotalDoFinanciamento - valorDoCarro;

            textao = textao + string.Format("Valor total de financiamento: R$ {0}\r\nDiferença entre o valor total do financiamento e valor do carro: R$ {1}",
            valorTotalDoFinanciamento, diferencaDoValorTotal);

            txtResultado.Text = textao;

        }

        private void ArmazenarInfrmacao()
        {
            string nomeDoCarro = txtNomeDoCarro.Text;
            try
            {
                if (nomeDoCarro.Length <= 2)
                {
                    MessageBox.Show("Nome do carro precisa conter pelo menos 2 caracteres ");
                    txtNomeDoCarro.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nome do carro deve contar somente letras ");
                txtNomeDoCarro.Focus();
                return;
            }

            valorDoCarro = Convert.ToDouble(mtbValorDoCarro.Text);
            valorDeCadaParcela = Convert.ToDouble(mtbValorDeCadaParcela.Text);
            quantidadeDeParcelas = Convert.ToInt32(nudQuantidadeDeParcelas.Text);

        }
    }
}
