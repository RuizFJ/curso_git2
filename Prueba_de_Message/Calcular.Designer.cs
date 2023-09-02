namespace Prueba_de_Message
{
    partial class Calcular
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
            btnCalcular = new Button();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(447, 170);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(194, 111);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(194, 170);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(194, 241);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(161, 23);
            txtResultado.TabIndex = 3;
            // 
            // Calcular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btnCalcular);
            Name = "Calcular";
            Text = "Calcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;
    }
}