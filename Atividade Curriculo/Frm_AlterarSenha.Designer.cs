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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lbl_NomeDoUsuario = new Label();
            txt_NomeDoUsuario = new TextBox();
            lbl_SenhaNova = new Label();
            txt_senhaNova = new TextBox();
            chk_mostrarenhanova = new CheckBox();
            lbl_SenhaAntiga = new Label();
            txt_SenhaAntiga = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-7, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 39);
            label1.TabIndex = 0;
            label1.Text = "Alterar Senha";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-7, 397);
            label2.Name = "label2";
            label2.Size = new Size(345, 39);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(110, 336);
            button1.Name = "button1";
            button1.Size = new Size(92, 36);
            button1.TabIndex = 4;
            button1.Text = "Confrimar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_NomeDoUsuario
            // 
            lbl_NomeDoUsuario.AutoSize = true;
            lbl_NomeDoUsuario.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_NomeDoUsuario.Location = new Point(98, 58);
            lbl_NomeDoUsuario.Name = "lbl_NomeDoUsuario";
            lbl_NomeDoUsuario.Size = new Size(132, 17);
            lbl_NomeDoUsuario.TabIndex = 3;
            lbl_NomeDoUsuario.Text = "Nome De Usuário";
            // 
            // txt_NomeDoUsuario
            // 
            txt_NomeDoUsuario.Location = new Point(21, 90);
            txt_NomeDoUsuario.Name = "txt_NomeDoUsuario";
            txt_NomeDoUsuario.Size = new Size(280, 23);
            txt_NomeDoUsuario.TabIndex = 1;
            // 
            // lbl_SenhaNova
            // 
            lbl_SenhaNova.AutoSize = true;
            lbl_SenhaNova.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_SenhaNova.Location = new Point(110, 213);
            lbl_SenhaNova.Name = "lbl_SenhaNova";
            lbl_SenhaNova.Size = new Size(92, 17);
            lbl_SenhaNova.TabIndex = 6;
            lbl_SenhaNova.Text = "Senha Nova";
            // 
            // txt_senhaNova
            // 
            txt_senhaNova.Location = new Point(21, 248);
            txt_senhaNova.MaxLength = 15;
            txt_senhaNova.Name = "txt_senhaNova";
            txt_senhaNova.PasswordChar = '*';
            txt_senhaNova.Size = new Size(280, 23);
            txt_senhaNova.TabIndex = 3;
            txt_senhaNova.KeyDown += txt_senhaNova_KeyDown;
            // 
            // chk_mostrarenhanova
            // 
            chk_mostrarenhanova.AutoSize = true;
            chk_mostrarenhanova.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chk_mostrarenhanova.Location = new Point(12, 294);
            chk_mostrarenhanova.Name = "chk_mostrarenhanova";
            chk_mostrarenhanova.Size = new Size(107, 19);
            chk_mostrarenhanova.TabIndex = 74;
            chk_mostrarenhanova.Text = "Mostrar Senha";
            chk_mostrarenhanova.UseVisualStyleBackColor = true;
            chk_mostrarenhanova.CheckedChanged += chk_mostrarenhanova_CheckedChanged;
            // 
            // lbl_SenhaAntiga
            // 
            lbl_SenhaAntiga.AutoSize = true;
            lbl_SenhaAntiga.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_SenhaAntiga.Location = new Point(110, 132);
            lbl_SenhaAntiga.Name = "lbl_SenhaAntiga";
            lbl_SenhaAntiga.Size = new Size(101, 17);
            lbl_SenhaAntiga.TabIndex = 10;
            lbl_SenhaAntiga.Text = "Senha Antiga";
            // 
            // txt_SenhaAntiga
            // 
            txt_SenhaAntiga.Location = new Point(21, 168);
            txt_SenhaAntiga.MaxLength = 15;
            txt_SenhaAntiga.Name = "txt_SenhaAntiga";
            txt_SenhaAntiga.PasswordChar = '*';
            txt_SenhaAntiga.Size = new Size(280, 23);
            txt_SenhaAntiga.TabIndex = 2;
            // 
            // Frm_AlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 435);
            Controls.Add(txt_SenhaAntiga);
            Controls.Add(lbl_SenhaAntiga);
            Controls.Add(chk_mostrarenhanova);
            Controls.Add(txt_senhaNova);
            Controls.Add(lbl_SenhaNova);
            Controls.Add(txt_NomeDoUsuario);
            Controls.Add(lbl_NomeDoUsuario);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_AlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_AlterarSenha";
            ResumeLayout(false);
            PerformLayout();
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