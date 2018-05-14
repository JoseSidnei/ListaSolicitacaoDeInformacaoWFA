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

      
    }
}
