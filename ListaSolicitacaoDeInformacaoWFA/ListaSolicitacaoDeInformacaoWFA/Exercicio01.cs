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
    public partial class Exercicio01 : Form
    {
        // 1. Solicite um número para o usuário e apresente ao final seu antecessor e o sucessor.

        public Exercicio01()
        {
            InitializeComponent();
        }

        private void btSucessorAntecessor_Click(object sender, EventArgs e)
        {
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Número  deve conter somente números reais");
                txtNumero.Focus();
                return;
            }

            double antecessor = (numero - 1);
            double sucesssor = (numero + 1);
            MessageBox.Show("Antecessor: " + antecessor + " Sucessor: " + sucesssor);
            
        }

       
    }
}
