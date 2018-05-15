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
    public partial class Exercicio06 : Form
    {
        /* 6.Desenvolver um algoritmo que solicite quatro notas e apresente a média ao final.

            Exemplo:

            Nota 01:​ 9,75
            Nota 02: ​10,00
            Nota 03:​ 4,42
            Nota 04:​ 5,00
            Média:​ 7,2925 */

        public Exercicio06()
        {
            InitializeComponent();
        }

        double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
        double media = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();
            string textao = string.Format("Nota 1: {0}\r\nNota 2: {1}\r\nNota 3: {2}\r\nNota 4: {3}\r\n\nMédia: {0}",
                                            nota1, nota2, nota3, nota4, media);

            txtMedia.Text = textao;
        }

        private void ArmazenarInformacao()
        {
            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
                if (nota1 <= 0)
                {
                    MessageBox.Show("Nota 1 deve ser maior que 0");
                    txtNota1.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nota 1 deve conter somente números");
                txtNota1.Focus();
                return;
            }

            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
                if (nota2 <= 0)
                {
                    MessageBox.Show("Nota 2 deve ser maior que 0");
                    txtNota2.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nota 2 deve conter somente números");
                txtNota2.Focus();
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);
                if (nota3 <= 0)
                {
                    MessageBox.Show("Nota 3 deve ser maior que 0");
                    txtNota3.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nota 3 deve conter somente números");
                txtNota3.Focus();
                return;
            }

            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);
                if (nota4 <= 0)
                {
                    MessageBox.Show("Nota 4 deve ser maior que 0");
                    txtNota4.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nota 4 deve conter somente números");
                txtNota4.Focus();
                return;
            }

            media = (nota1 + nota2 + nota3 + nota4) / 4;
             
        }
    }
}
