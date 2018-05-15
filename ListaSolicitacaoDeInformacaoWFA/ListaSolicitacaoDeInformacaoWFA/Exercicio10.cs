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
    public partial class Exercicio10 : Form
    {
        /* 10. Solicite o ano de nascimento do usuário e apresente ao final a idade do mesmo. */

        int anoDeNascimento = 0;

        public Exercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarAnoDeNascimento();
            double idade = 2018 - anoDeNascimento;
            MessageBox.Show("Sua idade : " + idade + " Anos");
            
        }

        private void ArmazenarAnoDeNascimento()
        {
            try
            {
                anoDeNascimento = Convert.ToInt32(txtAnoDeNascimento.Text);
            }
            catch
            {
                MessageBox.Show("Ano de nascimento deve conter apenas números inteiros !");
                txtAnoDeNascimento.Focus();
                return;
            }
        }
    }
}
