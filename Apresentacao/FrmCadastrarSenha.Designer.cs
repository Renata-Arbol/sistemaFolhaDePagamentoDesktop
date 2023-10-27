namespace Adicionar_Funcionário
{
    partial class frmCadSenha
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblCriarSenha = new System.Windows.Forms.Label();
            this.txbCriarSenha = new System.Windows.Forms.TextBox();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(401, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(622, 342);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(39, 151);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarSenha.TabIndex = 3;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // lblCriarSenha
            // 
            this.lblCriarSenha.AutoSize = true;
            this.lblCriarSenha.Location = new System.Drawing.Point(39, 89);
            this.lblCriarSenha.Name = "lblCriarSenha";
            this.lblCriarSenha.Size = new System.Drawing.Size(62, 13);
            this.lblCriarSenha.TabIndex = 4;
            this.lblCriarSenha.Text = "Criar Senha";
            // 
            // txbCriarSenha
            // 
            this.txbCriarSenha.Location = new System.Drawing.Point(117, 86);
            this.txbCriarSenha.Name = "txbCriarSenha";
            this.txbCriarSenha.Size = new System.Drawing.Size(100, 20);
            this.txbCriarSenha.TabIndex = 5;
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(155, 151);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.txbConfirmarSenha.TabIndex = 6;
            // 
            // frmCadSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.txbCriarSenha);
            this.Controls.Add(this.lblCriarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCadSenha";
            this.Text = "Cadastrar Senha";
            this.Load += new System.EventHandler(this.lblCadastrarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblCriarSenha;
        private System.Windows.Forms.TextBox txbCriarSenha;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
    }
}