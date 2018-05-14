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

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidadeDeLitrosPorDia = 0, quantidadeDeLitrosPorAno = 0;
            double valorlitro = 0;

            quantidadeDeLitrosPorDia = Convert.ToInt32(txtQuantidadePorDia.Text);
            quantidadeDeLitrosPorAno = Convert.ToInt32(txtQuantidadeDeAnosConsumidos.Text);
            valorlitro = Convert.ToDouble(mtbValorPorLitro.Text);
            double quantidadelitros = (quantidadeDeLitrosPorDia * 365 * quantidadeDeLitrosPorAno);
            double valortotalpago = (valorlitro * quantidadelitros);


            string textao = string.Format("Quantidade de Litros consumido: {0} Litros\r\nValor total Pago: R$ {1}\r\n",
                                           quantidadelitros, valortotalpago);
            txtResultado.Text = textao;
        }

        

       

    }
}
