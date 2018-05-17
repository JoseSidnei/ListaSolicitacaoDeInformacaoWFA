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
    public partial class Exercicio11 : Form
    {
        /*   11 Solicite o dia, mês e ano de nascimento e apresente as seguintes informações:

             ● Quantidade de dias vivo;
             ● Quantidade de anos vivo;
             ● Quantidade de meses vivo;
             ● Quantidade de horas vivo;
             ● Quantidade de minutos vivo;
             ● Quantidade de segundos vivo;  */

        public Exercicio11()
        {
            InitializeComponent();
        }

        int diaDeNascimento = 0, anoDeNascimento = 0, mesDeNascimento = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInforacao();           
            double somaAnosVivo = 2018 - anoDeNascimento;
            double somaDiasVivo = (2018 - anoDeNascimento) * 365;
            double somaMesesVivo = (2018 - anoDeNascimento) * 12;
            double somaHorasVivo = (24 * 365) * somaAnosVivo;
            double somaMinutosVivo = 60 * somaHorasVivo;
            double somaSegundosVivo = (3600 * 365) * somaAnosVivo;

            string texto = String.Format("Anos vivo: {1}\r\nDias vivo: {0}\r\nMeses vivo: {2}\r\nHoras vivo: {3}\r\nMinutos vivo: {4}\r\nSegundos vivo: {5}",
             somaDiasVivo, somaAnosVivo, somaMesesVivo, somaHorasVivo, somaMinutosVivo, somaSegundosVivo);
            txtResultado.Text = texto;
        }

        private void ArmazenarInforacao()
        {            
            try
            {
                diaDeNascimento = Convert.ToInt32(txtDiaDeNascimento.Text);
                if (diaDeNascimento <= 0)
                {
                    MessageBox.Show("Dia de nascimento deve ser maior que 0 !");
                    txtDiaDeNascimento.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Dia de nascimento deve conter apenas números inteiros !");
                txtDiaDeNascimento.Focus();
                return;
            }

            try
            {
                mesDeNascimento = Convert.ToInt32(txtMesDeNascimento.Text);
                if (mesDeNascimento <= 0)
                {
                    MessageBox.Show("Mês de nascimento deve ser maior que 0 !");
                     txtMesDeNascimento.Focus();
                     return;
                }
            }
            catch
            {
                MessageBox.Show("Mês de nascimento deve conter apenas números inteiros !");
                txtMesDeNascimento.Focus();
                return;
            }

            try
            {
                anoDeNascimento = Convert.ToInt32(txtAnoDeNascimento.Text);
                txtAnoDeNascimento.Focus();
                return;
            }
            catch
            {
                MessageBox.Show("Ano de nascimento deve conter somente números inteiro !");
                txtAnoDeNascimento.Focus();
                return;
            }

        }






        public string texto { get; set; }

        public object somaHorasVivo { get; set; }
    }
}
