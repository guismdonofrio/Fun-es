namespace Funções
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.gdbOperadores = new System.Windows.Forms.GroupBox();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbResto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gdbOperadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 268);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(60, 27);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Cacular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(117, 268);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 27);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(255, 336);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 27);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(93, 52);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(67, 20);
            this.txtN1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expressão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(248, 52);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(67, 20);
            this.txtN2.TabIndex = 8;
            // 
            // txtExpressao
            // 
            this.txtExpressao.Location = new System.Drawing.Point(93, 309);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(84, 20);
            this.txtExpressao.TabIndex = 9;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(93, 343);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(84, 20);
            this.txtResultado.TabIndex = 10;
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(5, 24);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(61, 17);
            this.rdbSoma.TabIndex = 11;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Soma +";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // gdbOperadores
            // 
            this.gdbOperadores.Controls.Add(this.rdbResto);
            this.gdbOperadores.Controls.Add(this.rdbDivisao);
            this.gdbOperadores.Controls.Add(this.rdbMultiplicacao);
            this.gdbOperadores.Controls.Add(this.rdbSubtracao);
            this.gdbOperadores.Controls.Add(this.rdbSoma);
            this.gdbOperadores.Location = new System.Drawing.Point(117, 90);
            this.gdbOperadores.Name = "gdbOperadores";
            this.gdbOperadores.Size = new System.Drawing.Size(110, 149);
            this.gdbOperadores.TabIndex = 12;
            this.gdbOperadores.TabStop = false;
            this.gdbOperadores.Text = "Operadores";
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(5, 47);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(80, 17);
            this.rdbSubtracao.TabIndex = 12;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração -";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(5, 70);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(94, 17);
            this.rdbMultiplicacao.TabIndex = 13;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação *";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(5, 93);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(68, 17);
            this.rdbDivisao.TabIndex = 14;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão /";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbResto
            // 
            this.rdbResto.AutoSize = true;
            this.rdbResto.Location = new System.Drawing.Point(5, 116);
            this.rdbResto.Name = "rdbResto";
            this.rdbResto.Size = new System.Drawing.Size(64, 17);
            this.rdbResto.TabIndex = 13;
            this.rdbResto.TabStop = true;
            this.rdbResto.Text = "Resto %";
            this.rdbResto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 385);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gdbOperadores);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtExpressao);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Atividade";
            this.gdbOperadores.ResumeLayout(false);
            this.gdbOperadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdbSoma;
        private System.Windows.Forms.GroupBox gdbOperadores;
        private System.Windows.Forms.RadioButton rdbResto;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.Label label5;
    }
}

