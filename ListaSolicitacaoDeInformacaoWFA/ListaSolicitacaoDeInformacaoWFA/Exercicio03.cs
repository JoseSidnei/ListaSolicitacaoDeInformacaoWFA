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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        /* 3.Solicitar dois números inteiros e apresentar:
             a.A soma dos valores;
             b.A subtração dos valores;
             c.A multiplicação dos valores
             d.A divisão dos valores;
             e.O produto dos valores. */

        int numero1 = 0, numero2 = 0;
        private void btCalcular_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();
            if (rbSoma.Checked)
            {
                Soma();
            }
            else if (rbSubtracao.Checked)
            {
                Subtracao();
            }
            else if (rbMultiplicacao.Checked)
            {
                Multiplicacao();
            }
            else if (rbDivisao.Checked)
            {
                Divisao();
            }
            else if (rbProduto.Checked)
            {
                Produto();
            }
            else
            {
                MessageBox.Show("Nenhuma das opções selecionadas ");
            }
        
        }
      
        private void ArmazenarInformacao()
        {
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
        }

        public void Soma()
        {
            double soma = numero1 + numero2;
            MessageBox.Show("A soma dos números é: " + soma);
        }

        public void Subtracao()
        {
            double subtracao = numero1 - numero2;
            MessageBox.Show("A subtração dos números é: " + subtracao);
        }

        public void Multiplicacao()
        {
            double multiplicacao = numero1 * numero2;
            MessageBox.Show("A Multiplicação dos números é: " + multiplicacao);
        }

        public void Divisao()
        {
            double divisao = numero1 / numero2;
            MessageBox.Show("A divisão dos números é: " + divisao);
        }

        public void Produto()
        {
            double produtoValoresPrimeiro = numero1 * numero1;
            double produtoValoresSegundo = numero2 * numero2;
            MessageBox.Show("O produto do número 1 é: " + produtoValoresPrimeiro +
                "\r\nO produto do número 2 é: " + produtoValoresSegundo);
        }

    }
}
