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
