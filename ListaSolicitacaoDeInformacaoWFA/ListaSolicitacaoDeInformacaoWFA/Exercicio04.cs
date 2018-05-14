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
