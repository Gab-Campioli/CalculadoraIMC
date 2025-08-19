namespace CalculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAlt = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInf = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMostrarClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(18, 84);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 24);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(18, 121);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(58, 24);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // txbPeso
            // 
            this.txbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPeso.Location = new System.Drawing.Point(82, 79);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(137, 29);
            this.txbPeso.TabIndex = 2;
            this.txbPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPeso_KeyDown);
            // 
            // txbAlt
            // 
            this.txbAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAlt.Location = new System.Drawing.Point(82, 116);
            this.txbAlt.Name = "txbAlt";
            this.txbAlt.Size = new System.Drawing.Size(137, 29);
            this.txbAlt.TabIndex = 3;
            this.txbAlt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAlt_KeyDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(113, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(69, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "IMC";
            // 
            // lblInf
            // 
            this.lblInf.AutoSize = true;
            this.lblInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInf.Location = new System.Drawing.Point(18, 45);
            this.lblInf.Name = "lblInf";
            this.lblInf.Size = new System.Drawing.Size(252, 24);
            this.lblInf.TabIndex = 5;
            this.lblInf.Text = "Insira aqui suas informações:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(22, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(197, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(82, 237);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(137, 29);
            this.txbResultado.TabIndex = 7;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(33, 242);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(43, 24);
            this.lblIMC.TabIndex = 8;
            this.lblIMC.Text = "IMC";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(78, 293);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(118, 24);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Classificação";
            // 
            // lblMostrarClass
            // 
            this.lblMostrarClass.AutoSize = true;
            this.lblMostrarClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarClass.Location = new System.Drawing.Point(90, 326);
            this.lblMostrarClass.Name = "lblMostrarClass";
            this.lblMostrarClass.Size = new System.Drawing.Size(0, 24);
            this.lblMostrarClass.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 383);
            this.Controls.Add(this.lblMostrarClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblInf);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbAlt);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAlt;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInf;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMostrarClass;
    }
}

