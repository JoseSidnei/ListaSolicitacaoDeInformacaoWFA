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
    public partial class Exercicio02 : Form
    {
        // 2. Calcule a quantidade de litros de água ingeridos em determinado período e o valor
        // pago.Para tal deve - se solicitar ao usuário a média da quantidade de litros ingeridos
        // por dia, a quantidade de anos e o valor pago pela água.

        // Exemplo:

        // Quantidade de litros: 3
        // Quantidade de anos consumidos: 17
        // Valor por Litro: R$ 9.75
        // Quantidade de Litros consumidos: 18.615 L
        // Valor Total Pago: R$ 181.496, 25


        public Exercicio02()
        {
            InitializeComponent();
        }

        int quantidadePorDia = 0, quantidadePorAno = 0;
        double valortTotal = 0, quantidadeLitros = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformacoes();
            if (rbQuantidadeConsumidaPorAno.Checked)
            {
                QuantidadeConsumidaPorAno();
            }

           
        }

        private void ArmazenarInformacoes()
        {
            quantidadePorDia = Convert.ToInt32(txtQuantidadePorDia.Text);
            quantidadePorAno = Convert.ToInt32(txtQuantidadeDeAnosConsumidos.Text);
        }

        public void QuantidadeConsumidaPorAno()
        {
            quantidadeLitros = quantidadePorDia = (quantidadePorDia * 365) * (quantidadePorAno);
           MessageBox.Show("Quantidade de Litros consumido: " + quantidadeLitros);
        }
    }
}
