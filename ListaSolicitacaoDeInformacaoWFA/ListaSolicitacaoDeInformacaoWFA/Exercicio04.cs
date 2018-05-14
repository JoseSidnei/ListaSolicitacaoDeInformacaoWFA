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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        /* 4.Imprimir a tabuada do número que o usuário informar.
            Exemplo: Número: 2
            2 x 0 = 0
            2 x 1 = 2
            2 x 2 = 4
            2 x 3 = 6
            2 x 4 = 8
            2 x 5 = 10
            2 x 6 = 12
            2 x 7 = 14
            2 x 8 = 16
            2 x 9 = 18
            2 x 10 = 20 */

        int numero = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string textao = "";
              
            for (int i = 0; i < 11; i++)
            {
                ArmazenarInformacao();
                double tabuada = numero * i;
                textao = textao + string.Format("{0} x {1} = {2}\r\n", numero , i, tabuada); 
            }

            

           txtResultado.Text = textao;
        }

        private void ArmazenarInformacao()
        {
            numero = Convert.ToInt32(txtNumero.Text);
            
        }       
    }
}
