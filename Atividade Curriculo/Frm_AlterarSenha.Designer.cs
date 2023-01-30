namespace Atividade_Curriculo
{
    partial class Frm_AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AlterarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_NomeDoUsuario = new System.Windows.Forms.Label();
            this.txt_NomeDoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_SenhaNova = new System.Windows.Forms.Label();
            this.txt_senhaNova = new System.Windows.Forms.TextBox();
            this.chk_mostrarenhanova = new System.Windows.Forms.CheckBox();
            this.lbl_SenhaAntiga = new System.Windows.Forms.Label();
            this.txt_SenhaAntiga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-7, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 39);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confrimar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_NomeDoUsuario
            // 
            this.lbl_NomeDoUsuario.AutoSize = true;
            this.lbl_NomeDoUsuario.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeDoUsuario.Location = new System.Drawing.Point(98, 58);
            this.lbl_NomeDoUsuario.Name = "lbl_NomeDoUsuario";
            this.lbl_NomeDoUsuario.Size = new System.Drawing.Size(132, 17);
            this.lbl_NomeDoUsuario.TabIndex = 3;
            this.lbl_NomeDoUsuario.Text = "Nome De Usuário";
            // 
            // txt_NomeDoUsuario
            // 
            this.txt_NomeDoUsuario.Location = new System.Drawing.Point(21, 90);
            this.txt_NomeDoUsuario.Name = "txt_NomeDoUsuario";
            this.txt_NomeDoUsuario.Size = new System.Drawing.Size(280, 23);
            this.txt_NomeDoUsuario.TabIndex = 1;
            // 
            // lbl_SenhaNova
            // 
            this.lbl_SenhaNova.AutoSize = true;
            this.lbl_SenhaNova.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SenhaNova.Location = new System.Drawing.Point(110, 213);
            this.lbl_SenhaNova.Name = "lbl_SenhaNova";
            this.lbl_SenhaNova.Size = new System.Drawing.Size(92, 17);
            this.lbl_SenhaNova.TabIndex = 6;
            this.lbl_SenhaNova.Text = "Senha Nova";
            // 
            // txt_senhaNova
            // 
            this.txt_senhaNova.Location = new System.Drawing.Point(21, 248);
            this.txt_senhaNova.MaxLength = 15;
            this.txt_senhaNova.Name = "txt_senhaNova";
            this.txt_senhaNova.PasswordChar = '*';
            this.txt_senhaNova.Size = new System.Drawing.Size(280, 23);
            this.txt_senhaNova.TabIndex = 3;
            // 
            // chk_mostrarenhanova
            // 
            this.chk_mostrarenhanova.AutoSize = true;
            this.chk_mostrarenhanova.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_mostrarenhanova.Location = new System.Drawing.Point(12, 294);
            this.chk_mostrarenhanova.Name = "chk_mostrarenhanova";
            this.chk_mostrarenhanova.Size = new System.Drawing.Size(107, 19);
            this.chk_mostrarenhanova.TabIndex = 74;
            this.chk_mostrarenhanova.Text = "Mostrar Senha";
            this.chk_mostrarenhanova.UseVisualStyleBackColor = true;
            this.chk_mostrarenhanova.CheckedChanged += new System.EventHandler(this.chk_mostrarenhanova_CheckedChanged);
            // 
            // lbl_SenhaAntiga
            // 
            this.lbl_SenhaAntiga.AutoSize = true;
            this.lbl_SenhaAntiga.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SenhaAntiga.Location = new System.Drawing.Point(110, 132);
            this.lbl_SenhaAntiga.Name = "lbl_SenhaAntiga";
            this.lbl_SenhaAntiga.Size = new System.Drawing.Size(101, 17);
            this.lbl_SenhaAntiga.TabIndex = 10;
            this.lbl_SenhaAntiga.Text = "Senha Antiga";
            // 
            // txt_SenhaAntiga
            // 
            this.txt_SenhaAntiga.Location = new System.Drawing.Point(21, 168);
            this.txt_SenhaAntiga.MaxLength = 15;
            this.txt_SenhaAntiga.Name = "txt_SenhaAntiga";
            this.txt_SenhaAntiga.PasswordChar = '*';
            this.txt_SenhaAntiga.Size = new System.Drawing.Size(280, 23);
            this.txt_SenhaAntiga.TabIndex = 2;
            // 
            // Frm_AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 435);
            this.Controls.Add(this.txt_SenhaAntiga);
            this.Controls.Add(this.lbl_SenhaAntiga);
            this.Controls.Add(this.chk_mostrarenhanova);
            this.Controls.Add(this.txt_senhaNova);
            this.Controls.Add(this.lbl_SenhaNova);
            this.Controls.Add(this.txt_NomeDoUsuario);
            this.Controls.Add(this.lbl_NomeDoUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AlterarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label lbl_NomeDoUsuario;
        private TextBox txt_NomeDoUsuario;
        private Label lbl_SenhaNova;
        private TextBox txt_senhaNova;
        private CheckBox chk_mostrarenhanova;
        private Label lbl_SenhaAntiga;
        private TextBox txt_SenhaAntiga;
    }
}