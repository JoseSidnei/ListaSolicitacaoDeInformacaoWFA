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
    public partial class Exercicio08 : Form
    {
        /* 8.Desenvolver um algoritmo que solicite a conta de luz, conta de água, valor da NET,
               valor da Vivo, valor da Oi, valor do IPTU, valor do IPVA e o valor do seguro do carro
               e apresentar as seguintes informações:
         
             ● Valor das contas de Telefone;
             ● Valor dos impostos;
             ● Valor do restante das contas;
             ● Valor Total de todas as contas. */

        public Exercicio08()
        {
            InitializeComponent();
        }

        double contaDeLuz = 0, contaDeAgua = 0, valorDaNET = 0, valorDaVivo = 0, valorDaOi = 0,
               valordoIPTU = 0, valorDoIPVA = 0, valorDoSeguroDoCarro = 0;
            

        private void ArmazenarInformacao()
        {
            try
            {
                contaDeLuz = Convert.ToDouble(txtContaDeLuz.Text);            
            }
            catch
            {
                MessageBox.Show("Conta de luz deve conter somente números !");
                txtContaDeLuz.Focus();
                return;
            }

            try
            {
                contaDeAgua = Convert.ToDouble(txtContaDeAgua.Text);
            }
            catch
            {
                MessageBox.Show("conta de água deve contwr somente Números !");
                txtContaDeAgua.Focus();
                return;
            }

            try
            {
                valorDaNET = Convert.ToDouble(txtValorDaNet.Text);           
            }
            catch
            {
                MessageBox.Show("Valor da net deve conter somente números !");
                txtValorDaNet.Focus();
                return;
            }

            try
            {
                valorDaVivo = Convert.ToDouble(txtValorDaVivo.Text);           
            }
            catch
            {
                MessageBox.Show("Valor da ViVo deve conter somente números !");
                txtValorDaOi.Focus();
                return;
            }

            try
            {
                valorDaOi = Convert.ToDouble(txtValorDaOi.Text);
            }
            catch
            {
                MessageBox.Show("ValorTotalDeTodasAsContas da txtValorDaOi deve conter somente números ! ");
                txtValorDaVivo.Focus();
                return;
            }

            try
            {
                valordoIPTU = Convert.ToDouble(txtValorDoIPTU.Text);            
            }
            catch
            {
                MessageBox.Show("Valor do IPTU deve conter somente números !");
                txtValorDoIPTU.Focus();
                return;
            }

            try
            {
                valorDoIPVA = Convert.ToDouble(txtValorDoIPVA.Text);
            }
            catch
            {
                MessageBox.Show("Valor do IPVA deve conter somente números !");
                txtValorDoIPVA.Focus();
                return;
            }

            try
            {
                valorDoSeguroDoCarro = Convert.ToDouble(txtValorDoSeguroDoCarro.Text);
            }
            catch
            {
                MessageBox.Show("Valor do seguro do carro deve conter somente números !");
                txtValorDoSeguroDoCarro.Focus();
                return;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rbValorDasContasDeTelefone.Checked)
            {
                ValorDasContasDeTelefone();
            }
            else if (rbValorDosImpostos.Checked)
            {
                ValorDosImpostos();
            }
            else if (rbValorDoRestanteDascontas.Checked)
            {
                ValorDoRestanteDasContas();
            }
            else if (rbValorTotalDeTodasAsContas.Checked)
            {
                ValorTotalDeTodasAsContas();
            }
            else
            {
                MessageBox.Show("Nenhuma das opções selecionadas ! ");
            }
        }

        public void ValorDasContasDeTelefone()
        {
            ArmazenarInformacao();
            double valorContasDetelefone = (valorDaNET + valorDaVivo + valorDaOi);
            MessageBox.Show("Valor total das Contas de Telefone: R$ " + valorContasDetelefone);
        }

        public void ValorDosImpostos()
        {
            ArmazenarInformacao();
            double valorDosImpostos = valordoIPTU + valorDoIPVA;
            MessageBox.Show("Valor dos Impostos: R$ " + valorDosImpostos);
        }

        public void ValorDoRestanteDasContas()
        {
            ArmazenarInformacao();
            double valorDoRestanteDasContas = contaDeLuz + contaDeAgua + valorDoSeguroDoCarro;
            MessageBox.Show("Valor do restante das contas: R$ " + valorDoRestanteDasContas);
        }

        public void ValorTotalDeTodasAsContas()
        {
            ArmazenarInformacao();
            double valorTotalDSeTodasAsContas = contaDeLuz + contaDeAgua + valorDaNET + valorDaVivo + valorDaOi +
                   valordoIPTU + valorDoIPVA + valorDoSeguroDoCarro;
            MessageBox.Show("Valor Total de Todas as Contas: R$ " + valorTotalDSeTodasAsContas);
        }
    }
}
