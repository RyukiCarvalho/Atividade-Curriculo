namespace Atividade_Curriculo
{
    partial class Frm_PromeiroAcesso
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_criar = new System.Windows.Forms.Button();
            this.txt_primeirouser = new System.Windows.Forms.TextBox();
            this.lbl_primeiroUser = new System.Windows.Forms.Label();
            this.lbl_senhaP = new System.Windows.Forms.Label();
            this.txt_senhap = new System.Windows.Forms.TextBox();
            this.lbl_confirmarSenha = new System.Windows.Forms.Label();
            this.txt_Confrimarsenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_Mostrarsenha = new System.Windows.Forms.CheckBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-10, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_criar.Location = new System.Drawing.Point(700, 204);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(85, 34);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar Usuario";
            this.btn_criar.UseVisualStyleBackColor = false;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // txt_primeirouser
            // 
            this.txt_primeirouser.Location = new System.Drawing.Point(179, 71);
            this.txt_primeirouser.MaxLength = 100;
            this.txt_primeirouser.Name = "txt_primeirouser";
            this.txt_primeirouser.Size = new System.Drawing.Size(606, 23);
            this.txt_primeirouser.TabIndex = 1;
            this.txt_primeirouser.TextChanged += new System.EventHandler(this.txt_primeirouser_TextChanged);
            // 
            // lbl_primeiroUser
            // 
            this.lbl_primeiroUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_primeiroUser.Location = new System.Drawing.Point(30, 71);
            this.lbl_primeiroUser.Name = "lbl_primeiroUser";
            this.lbl_primeiroUser.Size = new System.Drawing.Size(143, 25);
            this.lbl_primeiroUser.TabIndex = 3;
            this.lbl_primeiroUser.Text = "Nome de Usuário";
            // 
            // lbl_senhaP
            // 
            this.lbl_senhaP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_senhaP.Location = new System.Drawing.Point(64, 144);
            this.lbl_senhaP.Name = "lbl_senhaP";
            this.lbl_senhaP.Size = new System.Drawing.Size(72, 25);
            this.lbl_senhaP.TabIndex = 4;
            this.lbl_senhaP.Text = "Senha:";
            // 
            // txt_senhap
            // 
            this.txt_senhap.Location = new System.Drawing.Point(179, 144);
            this.txt_senhap.MaxLength = 15;
            this.txt_senhap.Name = "txt_senhap";
            this.txt_senhap.PasswordChar = '*';
            this.txt_senhap.Size = new System.Drawing.Size(198, 23);
            this.txt_senhap.TabIndex = 2;
            // 
            // lbl_confirmarSenha
            // 
            this.lbl_confirmarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_confirmarSenha.Location = new System.Drawing.Point(394, 144);
            this.lbl_confirmarSenha.Name = "lbl_confirmarSenha";
            this.lbl_confirmarSenha.Size = new System.Drawing.Size(148, 25);
            this.lbl_confirmarSenha.TabIndex = 6;
            this.lbl_confirmarSenha.Text = "Confrimar Senha:";
            // 
            // txt_Confrimarsenha
            // 
            this.txt_Confrimarsenha.Location = new System.Drawing.Point(557, 144);
            this.txt_Confrimarsenha.MaxLength = 15;
            this.txt_Confrimarsenha.Name = "txt_Confrimarsenha";
            this.txt_Confrimarsenha.PasswordChar = '*';
            this.txt_Confrimarsenha.Size = new System.Drawing.Size(228, 23);
            this.txt_Confrimarsenha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(-10, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(816, 43);
            this.label5.TabIndex = 0;
            // 
            // chk_Mostrarsenha
            // 
            this.chk_Mostrarsenha.AutoSize = true;
            this.chk_Mostrarsenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_Mostrarsenha.Location = new System.Drawing.Point(64, 193);
            this.chk_Mostrarsenha.Name = "chk_Mostrarsenha";
            this.chk_Mostrarsenha.Size = new System.Drawing.Size(130, 24);
            this.chk_Mostrarsenha.TabIndex = 7;
            this.chk_Mostrarsenha.Text = "Mostrar Senha";
            this.chk_Mostrarsenha.UseVisualStyleBackColor = true;
            this.chk_Mostrarsenha.CheckedChanged += new System.EventHandler(this.chk_Mostrarsenha_CheckedChanged);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpar.Location = new System.Drawing.Point(586, 204);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(78, 34);
            this.btn_limpar.TabIndex = 8;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Frm_PromeiroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.chk_Mostrarsenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Confrimarsenha);
            this.Controls.Add(this.lbl_confirmarSenha);
            this.Controls.Add(this.txt_senhap);
            this.Controls.Add(this.lbl_senhaP);
            this.Controls.Add(this.lbl_primeiroUser);
            this.Controls.Add(this.txt_primeirouser);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PromeiroAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PromeiroAcesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_criar;
        private TextBox txt_primeirouser;
        private Label lbl_primeiroUser;
        private Label lbl_senhaP;
        private TextBox txt_senhap;
        private Label lbl_confirmarSenha;
        private TextBox txt_Confrimarsenha;
        private Label label5;
        private CheckBox chk_Mostrarsenha;
        private Button btn_limpar;
    }
}