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
    public partial class Exercicio07 : Form
    {
        /*  7.Desenvolver um algoritmo que apresente a seguinte árvore abaixo:        
  
                  *
                 ***
                *****
               *******
              *********
             ***********             */

        public Exercicio07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textao = @"
                 *   
              * * *    
            * * * * *    
          * * * * * * *    
        * * * * * * * * *    
      * * * * * * * * * * *";
            txtPiramide.Text = textao;
        }
    }
}
