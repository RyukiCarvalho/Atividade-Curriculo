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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PromeiroAcesso));
            label1 = new Label();
            btn_criar = new Button();
            txt_primeirouser = new TextBox();
            lbl_primeiroUser = new Label();
            lbl_senhaP = new Label();
            txt_senhap = new TextBox();
            lbl_confirmarSenha = new Label();
            txt_Confrimarsenha = new TextBox();
            label5 = new Label();
            chk_Mostrarsenha = new CheckBox();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-10, -1);
            label1.Name = "label1";
            label1.Size = new Size(816, 43);
            label1.TabIndex = 0;
            label1.Text = "Criar Usuário";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_criar
            // 
            btn_criar.BackColor = SystemColors.ControlLight;
            btn_criar.Location = new Point(700, 204);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(85, 34);
            btn_criar.TabIndex = 4;
            btn_criar.Text = "Criar Usuario";
            btn_criar.UseVisualStyleBackColor = false;
            btn_criar.Click += btn_criar_Click;
            // 
            // txt_primeirouser
            // 
            txt_primeirouser.Location = new Point(179, 71);
            txt_primeirouser.MaxLength = 100;
            txt_primeirouser.Name = "txt_primeirouser";
            txt_primeirouser.Size = new Size(606, 23);
            txt_primeirouser.TabIndex = 1;
            // 
            // lbl_primeiroUser
            // 
            lbl_primeiroUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_primeiroUser.Location = new Point(30, 71);
            lbl_primeiroUser.Name = "lbl_primeiroUser";
            lbl_primeiroUser.Size = new Size(143, 25);
            lbl_primeiroUser.TabIndex = 3;
            lbl_primeiroUser.Text = "Nome de Usuário";
            // 
            // lbl_senhaP
            // 
            lbl_senhaP.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senhaP.Location = new Point(64, 144);
            lbl_senhaP.Name = "lbl_senhaP";
            lbl_senhaP.Size = new Size(72, 25);
            lbl_senhaP.TabIndex = 4;
            lbl_senhaP.Text = "Senha:";
            // 
            // txt_senhap
            // 
            txt_senhap.Location = new Point(179, 144);
            txt_senhap.MaxLength = 15;
            txt_senhap.Name = "txt_senhap";
            txt_senhap.PasswordChar = '*';
            txt_senhap.Size = new Size(198, 23);
            txt_senhap.TabIndex = 2;
            // 
            // lbl_confirmarSenha
            // 
            lbl_confirmarSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirmarSenha.Location = new Point(394, 144);
            lbl_confirmarSenha.Name = "lbl_confirmarSenha";
            lbl_confirmarSenha.Size = new Size(148, 25);
            lbl_confirmarSenha.TabIndex = 6;
            lbl_confirmarSenha.Text = "Confrimar Senha:";
            // 
            // txt_Confrimarsenha
            // 
            txt_Confrimarsenha.Location = new Point(557, 144);
            txt_Confrimarsenha.MaxLength = 15;
            txt_Confrimarsenha.Name = "txt_Confrimarsenha";
            txt_Confrimarsenha.PasswordChar = '*';
            txt_Confrimarsenha.Size = new Size(228, 23);
            txt_Confrimarsenha.TabIndex = 3;
            txt_Confrimarsenha.KeyDown += txt_Confrimarsenha_KeyDown;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSeaGreen;
            label5.Location = new Point(-10, 254);
            label5.Name = "label5";
            label5.Size = new Size(816, 43);
            label5.TabIndex = 0;
            // 
            // chk_Mostrarsenha
            // 
            chk_Mostrarsenha.AutoSize = true;
            chk_Mostrarsenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chk_Mostrarsenha.Location = new Point(64, 193);
            chk_Mostrarsenha.Name = "chk_Mostrarsenha";
            chk_Mostrarsenha.Size = new Size(130, 24);
            chk_Mostrarsenha.TabIndex = 7;
            chk_Mostrarsenha.Text = "Mostrar Senha";
            chk_Mostrarsenha.UseVisualStyleBackColor = true;
            chk_Mostrarsenha.CheckedChanged += chk_Mostrarsenha_CheckedChanged;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = SystemColors.ControlLight;
            btn_limpar.Location = new Point(586, 204);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(78, 34);
            btn_limpar.TabIndex = 8;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // Frm_PromeiroAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 295);
            Controls.Add(btn_limpar);
            Controls.Add(chk_Mostrarsenha);
            Controls.Add(label5);
            Controls.Add(txt_Confrimarsenha);
            Controls.Add(lbl_confirmarSenha);
            Controls.Add(txt_senhap);
            Controls.Add(lbl_senhaP);
            Controls.Add(lbl_primeiroUser);
            Controls.Add(txt_primeirouser);
            Controls.Add(btn_criar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_PromeiroAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_PromeiroAcesso";
            ResumeLayout(false);
            PerformLayout();
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