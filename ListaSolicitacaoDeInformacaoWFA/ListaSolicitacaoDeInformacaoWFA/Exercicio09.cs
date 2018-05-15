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
    public partial class Exercicio09 : Form
    {
        /* 9. Solicite dois números e inverta os valores destas variáveis.

             Exemplo:
             número 1: 29
             número 2: 32
             Após a inversão a variável número 1 terá o valor 32 e a variável número 2 terá o valor 29. */

        public Exercicio09()
        {
            InitializeComponent();
        }

        int numero1 = 0, numero2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";
            ArmazenarNumeros();
            texto = texto + string.Format("Primeiro número: {0}\r\nSegundo número: {1}", numero2, numero1);
            txtResultado.Text = texto;
        }

        private void ArmazenarNumeros()
        {
            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);
            }
            catch
            {
                MessageBox.Show("Número 1 deve conter apenas números !");
            }

            try
            {
                numero2 = Convert.ToInt32(txtNumero2.Text);
            }
            catch
            {
                MessageBox.Show("Número 2 deve conter apenas números !");
            }
        }
    }
}
