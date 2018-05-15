namespace ListaSolicitacaoDeInformacaoWFA
{
    partial class Exercicio07
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPiramide = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(252, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Pirâmide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPiramide
            // 
            this.txtPiramide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiramide.Location = new System.Drawing.Point(252, 81);
            this.txtPiramide.Multiline = true;
            this.txtPiramide.Name = "txtPiramide";
            this.txtPiramide.ReadOnly = true;
            this.txtPiramide.Size = new System.Drawing.Size(266, 350);
            this.txtPiramide.TabIndex = 1;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 452);
            this.Controls.Add(this.txtPiramide);
            this.Controls.Add(this.button1);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPiramide;
    }
}