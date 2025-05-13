namespace Matrix
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
            this.GrbDados = new System.Windows.Forms.GroupBox();
            this.TxtbSobrenome = new System.Windows.Forms.TextBox();
            this.TxtbAnoDeNasc = new System.Windows.Forms.TextBox();
            this.TxtbNome = new System.Windows.Forms.TextBox();
            this.LblSobrenome = new System.Windows.Forms.Label();
            this.LblAnoDeNasc = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnVerficar = new System.Windows.Forms.Button();
            this.GrbVerificacao = new System.Windows.Forms.GroupBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.PicbVerifacacao = new System.Windows.Forms.PictureBox();
            this.GrbDados.SuspendLayout();
            this.GrbVerificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicbVerifacacao)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDados
            // 
            this.GrbDados.BackColor = System.Drawing.Color.Transparent;
            this.GrbDados.Controls.Add(this.TxtbSobrenome);
            this.GrbDados.Controls.Add(this.TxtbAnoDeNasc);
            this.GrbDados.Controls.Add(this.TxtbNome);
            this.GrbDados.Controls.Add(this.LblSobrenome);
            this.GrbDados.Controls.Add(this.LblAnoDeNasc);
            this.GrbDados.Controls.Add(this.LblNome);
            this.GrbDados.Controls.Add(this.BtnSair);
            this.GrbDados.Controls.Add(this.BtnLimpar);
            this.GrbDados.Controls.Add(this.BtnVerficar);
            this.GrbDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbDados.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbDados.ForeColor = System.Drawing.Color.White;
            this.GrbDados.Location = new System.Drawing.Point(50, 12);
            this.GrbDados.Name = "GrbDados";
            this.GrbDados.Size = new System.Drawing.Size(269, 434);
            this.GrbDados.TabIndex = 0;
            this.GrbDados.TabStop = false;
            this.GrbDados.Text = "Dados";
            // 
            // TxtbSobrenome
            // 
            this.TxtbSobrenome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtbSobrenome.Location = new System.Drawing.Point(5, 174);
            this.TxtbSobrenome.Multiline = true;
            this.TxtbSobrenome.Name = "TxtbSobrenome";
            this.TxtbSobrenome.Size = new System.Drawing.Size(258, 28);
            this.TxtbSobrenome.TabIndex = 8;
            // 
            // TxtbAnoDeNasc
            // 
            this.TxtbAnoDeNasc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtbAnoDeNasc.Location = new System.Drawing.Point(6, 267);
            this.TxtbAnoDeNasc.Multiline = true;
            this.TxtbAnoDeNasc.Name = "TxtbAnoDeNasc";
            this.TxtbAnoDeNasc.Size = new System.Drawing.Size(258, 29);
            this.TxtbAnoDeNasc.TabIndex = 7;
            // 
            // TxtbNome
            // 
            this.TxtbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtbNome.Location = new System.Drawing.Point(6, 84);
            this.TxtbNome.Multiline = true;
            this.TxtbNome.Name = "TxtbNome";
            this.TxtbNome.Size = new System.Drawing.Size(258, 33);
            this.TxtbNome.TabIndex = 6;
            // 
            // LblSobrenome
            // 
            this.LblSobrenome.AutoSize = true;
            this.LblSobrenome.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSobrenome.Location = new System.Drawing.Point(12, 140);
            this.LblSobrenome.Name = "LblSobrenome";
            this.LblSobrenome.Size = new System.Drawing.Size(99, 22);
            this.LblSobrenome.TabIndex = 5;
            this.LblSobrenome.Text = "Sobrenome";
            // 
            // LblAnoDeNasc
            // 
            this.LblAnoDeNasc.AutoSize = true;
            this.LblAnoDeNasc.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnoDeNasc.Location = new System.Drawing.Point(12, 233);
            this.LblAnoDeNasc.Name = "LblAnoDeNasc";
            this.LblAnoDeNasc.Size = new System.Drawing.Size(117, 22);
            this.LblAnoDeNasc.TabIndex = 4;
            this.LblAnoDeNasc.Text = "Ano de Nasc.";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(12, 45);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(57, 22);
            this.LblNome.TabIndex = 3;
            this.LblNome.Text = "Nome";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.Black;
            this.BtnSair.Location = new System.Drawing.Point(5, 389);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(259, 31);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpar.Location = new System.Drawing.Point(6, 356);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(257, 27);
            this.BtnLimpar.TabIndex = 1;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnVerficar
            // 
            this.BtnVerficar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnVerficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerficar.ForeColor = System.Drawing.Color.Black;
            this.BtnVerficar.Location = new System.Drawing.Point(6, 321);
            this.BtnVerficar.Name = "BtnVerficar";
            this.BtnVerficar.Size = new System.Drawing.Size(257, 29);
            this.BtnVerficar.TabIndex = 0;
            this.BtnVerficar.Text = "Verificar";
            this.BtnVerficar.UseVisualStyleBackColor = false;
            this.BtnVerficar.Click += new System.EventHandler(this.BtnVerficar_Click);
            // 
            // GrbVerificacao
            // 
            this.GrbVerificacao.BackColor = System.Drawing.Color.Transparent;
            this.GrbVerificacao.Controls.Add(this.LblResultado);
            this.GrbVerificacao.Controls.Add(this.PicbVerifacacao);
            this.GrbVerificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbVerificacao.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbVerificacao.ForeColor = System.Drawing.Color.White;
            this.GrbVerificacao.Location = new System.Drawing.Point(390, 12);
            this.GrbVerificacao.Name = "GrbVerificacao";
            this.GrbVerificacao.Size = new System.Drawing.Size(288, 434);
            this.GrbVerificacao.TabIndex = 1;
            this.GrbVerificacao.TabStop = false;
            this.GrbVerificacao.Text = "Verificação";
            // 
            // LblResultado
            // 
            this.LblResultado.AllowDrop = true;
            this.LblResultado.AutoSize = true;
            this.LblResultado.BackColor = System.Drawing.Color.Transparent;
            this.LblResultado.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.Color.White;
            this.LblResultado.Location = new System.Drawing.Point(21, 162);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblResultado.Size = new System.Drawing.Size(0, 22);
            this.LblResultado.TabIndex = 9;
            // 
            // PicbVerifacacao
            // 
            this.PicbVerifacacao.Location = new System.Drawing.Point(25, 66);
            this.PicbVerifacacao.Name = "PicbVerifacacao";
            this.PicbVerifacacao.Size = new System.Drawing.Size(68, 51);
            this.PicbVerifacacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbVerifacacao.TabIndex = 0;
            this.PicbVerifacacao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Matrix.Properties.Resources.Fundomatrix;
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.GrbVerificacao);
            this.Controls.Add(this.GrbDados);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Matrix";
            this.GrbDados.ResumeLayout(false);
            this.GrbDados.PerformLayout();
            this.GrbVerificacao.ResumeLayout(false);
            this.GrbVerificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicbVerifacacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDados;
        private System.Windows.Forms.GroupBox GrbVerificacao;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnVerficar;
        private System.Windows.Forms.TextBox TxtbSobrenome;
        private System.Windows.Forms.TextBox TxtbAnoDeNasc;
        private System.Windows.Forms.TextBox TxtbNome;
        private System.Windows.Forms.Label LblSobrenome;
        private System.Windows.Forms.Label LblAnoDeNasc;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.PictureBox PicbVerifacacao;
    }
}

