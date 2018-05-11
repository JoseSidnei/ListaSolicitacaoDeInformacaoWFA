namespace ListaSolicitacaoDeInformacaoWFA
{
    partial class Exercicio02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuantidadeLitrosPorDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidadePorDia = new System.Windows.Forms.TextBox();
            this.txtQuantidadeDeAnosConsumidos = new System.Windows.Forms.TextBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbQuantidadeConsumidaPorAno = new System.Windows.Forms.RadioButton();
            this.rbValorTotal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtQuantidadeLitrosPorDia
            // 
            this.txtQuantidadeLitrosPorDia.AutoSize = true;
            this.txtQuantidadeLitrosPorDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeLitrosPorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeLitrosPorDia.Location = new System.Drawing.Point(12, 27);
            this.txtQuantidadeLitrosPorDia.Name = "txtQuantidadeLitrosPorDia";
            this.txtQuantidadeLitrosPorDia.Size = new System.Drawing.Size(233, 22);
            this.txtQuantidadeLitrosPorDia.TabIndex = 0;
            this.txtQuantidadeLitrosPorDia.Text = "Quantidade de litros por dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de anos consumidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor por Litro";
            // 
            // txtQuantidadePorDia
            // 
            this.txtQuantidadePorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadePorDia.Location = new System.Drawing.Point(12, 52);
            this.txtQuantidadePorDia.Name = "txtQuantidadePorDia";
            this.txtQuantidadePorDia.Size = new System.Drawing.Size(162, 22);
            this.txtQuantidadePorDia.TabIndex = 4;
            // 
            // txtQuantidadeDeAnosConsumidos
            // 
            this.txtQuantidadeDeAnosConsumidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDeAnosConsumidos.Location = new System.Drawing.Point(12, 126);
            this.txtQuantidadeDeAnosConsumidos.Name = "txtQuantidadeDeAnosConsumidos";
            this.txtQuantidadeDeAnosConsumidos.Size = new System.Drawing.Size(162, 22);
            this.txtQuantidadeDeAnosConsumidos.TabIndex = 5;
            // 
            // mtbValor
            // 
            this.mtbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValor.Location = new System.Drawing.Point(13, 199);
            this.mtbValor.Mask = "990.00";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(44, 22);
            this.mtbValor.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 71);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbQuantidadeConsumidaPorAno
            // 
            this.rbQuantidadeConsumidaPorAno.AutoSize = true;
            this.rbQuantidadeConsumidaPorAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuantidadeConsumidaPorAno.Location = new System.Drawing.Point(381, 31);
            this.rbQuantidadeConsumidaPorAno.Name = "rbQuantidadeConsumidaPorAno";
            this.rbQuantidadeConsumidaPorAno.Size = new System.Drawing.Size(277, 24);
            this.rbQuantidadeConsumidaPorAno.TabIndex = 12;
            this.rbQuantidadeConsumidaPorAno.TabStop = true;
            this.rbQuantidadeConsumidaPorAno.Text = "Quantidade consumida por ano";
            this.rbQuantidadeConsumidaPorAno.UseVisualStyleBackColor = true;
            // 
            // rbValorTotal
            // 
            this.rbValorTotal.AutoSize = true;
            this.rbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbValorTotal.Location = new System.Drawing.Point(381, 105);
            this.rbValorTotal.Name = "rbValorTotal";
            this.rbValorTotal.Size = new System.Drawing.Size(110, 24);
            this.rbValorTotal.TabIndex = 13;
            this.rbValorTotal.TabStop = true;
            this.rbValorTotal.Text = "Valor total";
            this.rbValorTotal.UseVisualStyleBackColor = true;
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 460);
            this.Controls.Add(this.rbValorTotal);
            this.Controls.Add(this.rbQuantidadeConsumidaPorAno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.txtQuantidadeDeAnosConsumidos);
            this.Controls.Add(this.txtQuantidadePorDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidadeLitrosPorDia);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtQuantidadeLitrosPorDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadePorDia;
        private System.Windows.Forms.TextBox txtQuantidadeDeAnosConsumidos;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbQuantidadeConsumidaPorAno;
        private System.Windows.Forms.RadioButton rbValorTotal;
    }
}