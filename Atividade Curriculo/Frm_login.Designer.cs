namespace Atividade_Curriculo
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            lbl_senha = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_usuario = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btn_entrar = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            chk_Mostrasenha = new CheckBox();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(54, 149);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(61, 21);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(133, 85);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(218, 23);
            txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(133, 149);
            txt_senha.MaxLength = 15;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(218, 23);
            txt_senha.TabIndex = 2;
            txt_senha.KeyDown += txt_senha_KeyDown;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-4, -1);
            label1.Name = "label1";
            label1.Size = new Size(441, 41);
            label1.TabIndex = 4;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            label2.ForeColor = Color.DarkSeaGreen;
            label2.Location = new Point(-4, 19);
            label2.Name = "label2";
            label2.Size = new Size(33, 447);
            label2.TabIndex = 5;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.Location = new Point(54, 83);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(73, 21);
            lbl_usuario.TabIndex = 11;
            lbl_usuario.Text = "Usuário:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(166, 287);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 12;
            label8.Text = "Crie seu Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(353, 207);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(72, 23);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkSeaGreen;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(150, 338);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(201, 19);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crie seu primeiro acesso";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkSeaGreen;
            label3.ForeColor = Color.DarkSeaGreen;
            label3.Location = new Point(22, 263);
            label3.Name = "label3";
            label3.Size = new Size(415, 10);
            label3.TabIndex = 6;
            // 
            // chk_Mostrasenha
            // 
            chk_Mostrasenha.AutoSize = true;
            chk_Mostrasenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chk_Mostrasenha.Location = new Point(133, 178);
            chk_Mostrasenha.Name = "chk_Mostrasenha";
            chk_Mostrasenha.Size = new Size(107, 19);
            chk_Mostrasenha.TabIndex = 4;
            chk_Mostrasenha.Text = "Mostrar Senha";
            chk_Mostrasenha.UseVisualStyleBackColor = true;
            chk_Mostrasenha.CheckedChanged += chk_Mostrasenha_CheckedChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DarkSeaGreen;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.Black;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(54, 233);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(84, 19);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Alterar Senha";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkSeaGreen;
            label4.ForeColor = Color.DarkSeaGreen;
            label4.Location = new Point(12, 404);
            label4.Name = "label4";
            label4.Size = new Size(425, 33);
            label4.TabIndex = 21;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 426);
            Controls.Add(label4);
            Controls.Add(linkLabel2);
            Controls.Add(chk_Mostrasenha);
            Controls.Add(linkLabel1);
            Controls.Add(btn_entrar);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lbl_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_senha);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_senha;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label label1;
        private Label label2;
        private Label lbl_usuario;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btn_entrar;
        private LinkLabel linkLabel1;
        private Label label3;
        private CheckBox chk_Mostrasenha;
        private LinkLabel linkLabel2;
        private Label label4;
        private ColorDialog colorDialog1;
    }
}