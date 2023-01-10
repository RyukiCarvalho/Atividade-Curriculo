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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_SenhaAtual = new System.Windows.Forms.Label();
            this.txt_NomeDoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_SenhaNova = new System.Windows.Forms.Label();
            this.txt_senhaNova = new System.Windows.Forms.TextBox();
            this.chk_mostrarenhanova = new System.Windows.Forms.CheckBox();
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
            this.label2.Location = new System.Drawing.Point(-7, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 39);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confrimar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_SenhaAtual
            // 
            this.lbl_SenhaAtual.AutoSize = true;
            this.lbl_SenhaAtual.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SenhaAtual.Location = new System.Drawing.Point(89, 59);
            this.lbl_SenhaAtual.Name = "lbl_SenhaAtual";
            this.lbl_SenhaAtual.Size = new System.Drawing.Size(132, 17);
            this.lbl_SenhaAtual.TabIndex = 3;
            this.lbl_SenhaAtual.Text = "Nome De Usuário";
            // 
            // txt_NomeDoUsuario
            // 
            this.txt_NomeDoUsuario.Location = new System.Drawing.Point(21, 90);
            this.txt_NomeDoUsuario.Name = "txt_NomeDoUsuario";
            this.txt_NomeDoUsuario.Size = new System.Drawing.Size(280, 23);
            this.txt_NomeDoUsuario.TabIndex = 4;
            // 
            // lbl_SenhaNova
            // 
            this.lbl_SenhaNova.AutoSize = true;
            this.lbl_SenhaNova.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SenhaNova.Location = new System.Drawing.Point(110, 139);
            this.lbl_SenhaNova.Name = "lbl_SenhaNova";
            this.lbl_SenhaNova.Size = new System.Drawing.Size(92, 17);
            this.lbl_SenhaNova.TabIndex = 6;
            this.lbl_SenhaNova.Text = "Senha Nova";
            // 
            // txt_senhaNova
            // 
            this.txt_senhaNova.Location = new System.Drawing.Point(21, 177);
            this.txt_senhaNova.MaxLength = 15;
            this.txt_senhaNova.Name = "txt_senhaNova";
            this.txt_senhaNova.PasswordChar = '*';
            this.txt_senhaNova.Size = new System.Drawing.Size(280, 23);
            this.txt_senhaNova.TabIndex = 8;
            // 
            // chk_mostrarenhanova
            // 
            this.chk_mostrarenhanova.AutoSize = true;
            this.chk_mostrarenhanova.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_mostrarenhanova.Location = new System.Drawing.Point(28, 217);
            this.chk_mostrarenhanova.Name = "chk_mostrarenhanova";
            this.chk_mostrarenhanova.Size = new System.Drawing.Size(107, 19);
            this.chk_mostrarenhanova.TabIndex = 9;
            this.chk_mostrarenhanova.Text = "Mostrar Senha";
            this.chk_mostrarenhanova.UseVisualStyleBackColor = true;
            this.chk_mostrarenhanova.CheckedChanged += new System.EventHandler(this.chk_mostrarenhanova_CheckedChanged);
            // 
            // Frm_AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 368);
            this.Controls.Add(this.chk_mostrarenhanova);
            this.Controls.Add(this.txt_senhaNova);
            this.Controls.Add(this.lbl_SenhaNova);
            this.Controls.Add(this.txt_NomeDoUsuario);
            this.Controls.Add(this.lbl_SenhaAtual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private Label lbl_SenhaAtual;
        private TextBox txt_NomeDoUsuario;
        private Label lbl_SenhaNova;
        private TextBox txt_senhaNova;
        private CheckBox chk_mostrarenhanova;
    }
}