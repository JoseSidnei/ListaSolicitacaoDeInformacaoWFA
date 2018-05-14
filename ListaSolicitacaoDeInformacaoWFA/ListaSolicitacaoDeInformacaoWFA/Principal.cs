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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btExercício1_Click(object sender, EventArgs e)
        {
            Exercicio01 exercicio01 = new Exercicio01();
            exercicio01.Show();
        }

        private void btExercício2_Click(object sender, EventArgs e)
        {
            Exercicio02 exercicio02 = new Exercicio02();
            exercicio02.Show();
        }

        private void btExercício3_Click(object sender, EventArgs e)
        {
            Exercicio03 exercicio03 = new Exercicio03();
            exercicio03.Show();
        }

        private void btExercício4_Click(object sender, EventArgs e)
        {
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Show();
        }

        private void btExercício5_Click(object sender, EventArgs e)
        {
            Exercicio05 exercicio05 = new Exercicio05();
            exercicio05.Show();
        }

      
    }
}
