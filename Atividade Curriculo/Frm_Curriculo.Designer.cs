namespace Atividade_Curriculo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_Curriculo = new Label();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Lbl_DataNasc = new Label();
            Lbl_Email = new Label();
            Txt_Email = new TextBox();
            Lbl_Telefone = new Label();
            Msk_DataNasc = new MaskedTextBox();
            Lbl_Logradouro = new Label();
            Txt_Logradouro = new TextBox();
            Grb_Dados_Pessoais = new GroupBox();
            msk_Cep = new MaskedTextBox();
            Msk_Telefone = new MaskedTextBox();
            Cmb_Estados = new ComboBox();
            Lbl_Uf = new Label();
            Txt_Cidade = new TextBox();
            Lbl_Cidade = new Label();
            Txt_Bairro = new TextBox();
            Lbl_Bairo = new Label();
            Txt_Numero = new TextBox();
            Lbl_Numero = new Label();
            Lbl_Cep = new Label();
            Lbl_Outras_Informações = new Label();
            Lbl_Qualificaçôes = new Label();
            Grp_Qualificaçôes = new GroupBox();
            Txt_Curso4 = new TextBox();
            Txt_SiteQUali4 = new TextBox();
            Txt_Curso3 = new TextBox();
            Txt_Curso2 = new TextBox();
            Txt_SiteQUali3 = new TextBox();
            Txt_SiteQUali2 = new TextBox();
            Txt_Curso = new TextBox();
            Lbl_Curso = new Label();
            Txt_SiteQUali = new TextBox();
            Lbl_CiteQuali = new Label();
            Tls_Principal = new ToolStrip();
            Tls_salvar = new ToolStripButton();
            Tls_limpar = new ToolStripButton();
            Tls_Duvidas = new ToolStripButton();
            Tls_excluir = new ToolStripButton();
            Tls_Alterar = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            DG_Curriculo = new DataGridView();
            Buscar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            txt_InformeBlog = new TextBox();
            Lbl_InformeBlog = new Label();
            Cmb_Blog = new ComboBox();
            Lbl_Blog = new Label();
            Msk_Remuneração = new MaskedTextBox();
            Lbl_Remuneração = new Label();
            Cmb_remoto = new ComboBox();
            Lbl_Trabalhoremoto = new Label();
            Cmb_Emprego = new ComboBox();
            Lbl_PrimeiroEmprego = new Label();
            groupBox1 = new GroupBox();
            Grb_Dados_Pessoais.SuspendLayout();
            Grp_Qualificaçôes.SuspendLayout();
            Tls_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DG_Curriculo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Curriculo
            // 
            resources.ApplyResources(lbl_Curriculo, "lbl_Curriculo");
            lbl_Curriculo.BackColor = Color.DarkSeaGreen;
            lbl_Curriculo.Name = "lbl_Curriculo";
            // 
            // Lbl_Nome
            // 
            resources.ApplyResources(Lbl_Nome, "Lbl_Nome");
            Lbl_Nome.Name = "Lbl_Nome";
            // 
            // Txt_Nome
            // 
            resources.ApplyResources(Txt_Nome, "Txt_Nome");
            Txt_Nome.Name = "Txt_Nome";
            // 
            // Lbl_DataNasc
            // 
            resources.ApplyResources(Lbl_DataNasc, "Lbl_DataNasc");
            Lbl_DataNasc.Name = "Lbl_DataNasc";
            // 
            // Lbl_Email
            // 
            resources.ApplyResources(Lbl_Email, "Lbl_Email");
            Lbl_Email.Name = "Lbl_Email";
            // 
            // Txt_Email
            // 
            resources.ApplyResources(Txt_Email, "Txt_Email");
            Txt_Email.Name = "Txt_Email";
            // 
            // Lbl_Telefone
            // 
            resources.ApplyResources(Lbl_Telefone, "Lbl_Telefone");
            Lbl_Telefone.Name = "Lbl_Telefone";
            // 
            // Msk_DataNasc
            // 
            resources.ApplyResources(Msk_DataNasc, "Msk_DataNasc");
            Msk_DataNasc.Name = "Msk_DataNasc";
            Msk_DataNasc.ValidatingType = typeof(DateTime);
            // 
            // Lbl_Logradouro
            // 
            resources.ApplyResources(Lbl_Logradouro, "Lbl_Logradouro");
            Lbl_Logradouro.Name = "Lbl_Logradouro";
            // 
            // Txt_Logradouro
            // 
            resources.ApplyResources(Txt_Logradouro, "Txt_Logradouro");
            Txt_Logradouro.Name = "Txt_Logradouro";
            // 
            // Grb_Dados_Pessoais
            // 
            Grb_Dados_Pessoais.BackColor = SystemColors.Control;
            Grb_Dados_Pessoais.Controls.Add(msk_Cep);
            Grb_Dados_Pessoais.Controls.Add(Msk_Telefone);
            Grb_Dados_Pessoais.Controls.Add(Cmb_Estados);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Uf);
            Grb_Dados_Pessoais.Controls.Add(Txt_Cidade);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Cidade);
            Grb_Dados_Pessoais.Controls.Add(Txt_Bairro);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Bairo);
            Grb_Dados_Pessoais.Controls.Add(Txt_Numero);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Numero);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Cep);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Logradouro);
            Grb_Dados_Pessoais.Controls.Add(Txt_Logradouro);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Nome);
            Grb_Dados_Pessoais.Controls.Add(Txt_Nome);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Telefone);
            Grb_Dados_Pessoais.Controls.Add(Msk_DataNasc);
            Grb_Dados_Pessoais.Controls.Add(Txt_Email);
            Grb_Dados_Pessoais.Controls.Add(Lbl_DataNasc);
            Grb_Dados_Pessoais.Controls.Add(Lbl_Email);
            resources.ApplyResources(Grb_Dados_Pessoais, "Grb_Dados_Pessoais");
            Grb_Dados_Pessoais.Name = "Grb_Dados_Pessoais";
            Grb_Dados_Pessoais.TabStop = false;
            // 
            // msk_Cep
            // 
            resources.ApplyResources(msk_Cep, "msk_Cep");
            msk_Cep.Name = "msk_Cep";
            msk_Cep.Leave += msk_Cep_Leave;
            // 
            // Msk_Telefone
            // 
            resources.ApplyResources(Msk_Telefone, "Msk_Telefone");
            Msk_Telefone.Name = "Msk_Telefone";
            // 
            // Cmb_Estados
            // 
            Cmb_Estados.FormattingEnabled = true;
            resources.ApplyResources(Cmb_Estados, "Cmb_Estados");
            Cmb_Estados.Items.AddRange(new object[] { resources.GetString("Cmb_Estados.Items"), resources.GetString("Cmb_Estados.Items1") });
            Cmb_Estados.Name = "Cmb_Estados";
            // 
            // Lbl_Uf
            // 
            resources.ApplyResources(Lbl_Uf, "Lbl_Uf");
            Lbl_Uf.Name = "Lbl_Uf";
            // 
            // Txt_Cidade
            // 
            resources.ApplyResources(Txt_Cidade, "Txt_Cidade");
            Txt_Cidade.Name = "Txt_Cidade";
            // 
            // Lbl_Cidade
            // 
            resources.ApplyResources(Lbl_Cidade, "Lbl_Cidade");
            Lbl_Cidade.Name = "Lbl_Cidade";
            // 
            // Txt_Bairro
            // 
            resources.ApplyResources(Txt_Bairro, "Txt_Bairro");
            Txt_Bairro.Name = "Txt_Bairro";
            // 
            // Lbl_Bairo
            // 
            resources.ApplyResources(Lbl_Bairo, "Lbl_Bairo");
            Lbl_Bairo.Name = "Lbl_Bairo";
            // 
            // Txt_Numero
            // 
            resources.ApplyResources(Txt_Numero, "Txt_Numero");
            Txt_Numero.Name = "Txt_Numero";
            // 
            // Lbl_Numero
            // 
            resources.ApplyResources(Lbl_Numero, "Lbl_Numero");
            Lbl_Numero.Name = "Lbl_Numero";
            // 
            // Lbl_Cep
            // 
            resources.ApplyResources(Lbl_Cep, "Lbl_Cep");
            Lbl_Cep.Name = "Lbl_Cep";
            // 
            // Lbl_Outras_Informações
            // 
            resources.ApplyResources(Lbl_Outras_Informações, "Lbl_Outras_Informações");
            Lbl_Outras_Informações.BackColor = Color.DarkSeaGreen;
            Lbl_Outras_Informações.Name = "Lbl_Outras_Informações";
            // 
            // Lbl_Qualificaçôes
            // 
            resources.ApplyResources(Lbl_Qualificaçôes, "Lbl_Qualificaçôes");
            Lbl_Qualificaçôes.BackColor = Color.DarkSeaGreen;
            Lbl_Qualificaçôes.Name = "Lbl_Qualificaçôes";
            // 
            // Grp_Qualificaçôes
            // 
            Grp_Qualificaçôes.Controls.Add(Txt_Curso4);
            Grp_Qualificaçôes.Controls.Add(Txt_SiteQUali4);
            Grp_Qualificaçôes.Controls.Add(Txt_Curso3);
            Grp_Qualificaçôes.Controls.Add(Txt_Curso2);
            Grp_Qualificaçôes.Controls.Add(Txt_SiteQUali3);
            Grp_Qualificaçôes.Controls.Add(Txt_SiteQUali2);
            Grp_Qualificaçôes.Controls.Add(Txt_Curso);
            Grp_Qualificaçôes.Controls.Add(Lbl_Curso);
            Grp_Qualificaçôes.Controls.Add(Txt_SiteQUali);
            Grp_Qualificaçôes.Controls.Add(Lbl_CiteQuali);
            resources.ApplyResources(Grp_Qualificaçôes, "Grp_Qualificaçôes");
            Grp_Qualificaçôes.Name = "Grp_Qualificaçôes";
            Grp_Qualificaçôes.TabStop = false;
            // 
            // Txt_Curso4
            // 
            resources.ApplyResources(Txt_Curso4, "Txt_Curso4");
            Txt_Curso4.Name = "Txt_Curso4";
            // 
            // Txt_SiteQUali4
            // 
            resources.ApplyResources(Txt_SiteQUali4, "Txt_SiteQUali4");
            Txt_SiteQUali4.Name = "Txt_SiteQUali4";
            // 
            // Txt_Curso3
            // 
            resources.ApplyResources(Txt_Curso3, "Txt_Curso3");
            Txt_Curso3.Name = "Txt_Curso3";
            // 
            // Txt_Curso2
            // 
            resources.ApplyResources(Txt_Curso2, "Txt_Curso2");
            Txt_Curso2.Name = "Txt_Curso2";
            // 
            // Txt_SiteQUali3
            // 
            resources.ApplyResources(Txt_SiteQUali3, "Txt_SiteQUali3");
            Txt_SiteQUali3.Name = "Txt_SiteQUali3";
            // 
            // Txt_SiteQUali2
            // 
            resources.ApplyResources(Txt_SiteQUali2, "Txt_SiteQUali2");
            Txt_SiteQUali2.Name = "Txt_SiteQUali2";
            // 
            // Txt_Curso
            // 
            resources.ApplyResources(Txt_Curso, "Txt_Curso");
            Txt_Curso.Name = "Txt_Curso";
            // 
            // Lbl_Curso
            // 
            resources.ApplyResources(Lbl_Curso, "Lbl_Curso");
            Lbl_Curso.Name = "Lbl_Curso";
            // 
            // Txt_SiteQUali
            // 
            resources.ApplyResources(Txt_SiteQUali, "Txt_SiteQUali");
            Txt_SiteQUali.Name = "Txt_SiteQUali";
            // 
            // Lbl_CiteQuali
            // 
            resources.ApplyResources(Lbl_CiteQuali, "Lbl_CiteQuali");
            Lbl_CiteQuali.Name = "Lbl_CiteQuali";
            // 
            // Tls_Principal
            // 
            Tls_Principal.Items.AddRange(new ToolStripItem[] { Tls_salvar, Tls_limpar, Tls_Duvidas, Tls_excluir, Tls_Alterar });
            resources.ApplyResources(Tls_Principal, "Tls_Principal");
            Tls_Principal.Name = "Tls_Principal";
            // 
            // Tls_salvar
            // 
            Tls_salvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(Tls_salvar, "Tls_salvar");
            Tls_salvar.Name = "Tls_salvar";
            Tls_salvar.Click += Tls_salvar_Click;
            // 
            // Tls_limpar
            // 
            Tls_limpar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(Tls_limpar, "Tls_limpar");
            Tls_limpar.Name = "Tls_limpar";
            Tls_limpar.Click += Tls_limpar_Click;
            // 
            // Tls_Duvidas
            // 
            Tls_Duvidas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(Tls_Duvidas, "Tls_Duvidas");
            Tls_Duvidas.Name = "Tls_Duvidas";
            Tls_Duvidas.Click += Tls_Duvidas_Click;
            // 
            // Tls_excluir
            // 
            Tls_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(Tls_excluir, "Tls_excluir");
            Tls_excluir.Name = "Tls_excluir";
            Tls_excluir.Click += Tls_excluir_Click;
            // 
            // Tls_Alterar
            // 
            Tls_Alterar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(Tls_Alterar, "Tls_Alterar");
            Tls_Alterar.Name = "Tls_Alterar";
            Tls_Alterar.Click += Tls_Alterar_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Name = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkSeaGreen;
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            label4.BackColor = Color.DarkSeaGreen;
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // DG_Curriculo
            // 
            DG_Curriculo.AllowUserToAddRows = false;
            DG_Curriculo.AllowUserToDeleteRows = false;
            DG_Curriculo.AllowUserToOrderColumns = true;
            DG_Curriculo.BackgroundColor = Color.Silver;
            DG_Curriculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Curriculo.Columns.AddRange(new DataGridViewColumn[] { Buscar, Id, Nome });
            DG_Curriculo.GridColor = Color.DarkGray;
            resources.ApplyResources(DG_Curriculo, "DG_Curriculo");
            DG_Curriculo.Name = "DG_Curriculo";
            DG_Curriculo.ReadOnly = true;
            DG_Curriculo.RowTemplate.Height = 25;
            DG_Curriculo.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Buscar
            // 
            resources.ApplyResources(Buscar, "Buscar");
            Buscar.Name = "Buscar";
            Buscar.ReadOnly = true;
            // 
            // Id
            // 
            resources.ApplyResources(Id, "Id");
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // txt_InformeBlog
            // 
            resources.ApplyResources(txt_InformeBlog, "txt_InformeBlog");
            txt_InformeBlog.Name = "txt_InformeBlog";
            // 
            // Lbl_InformeBlog
            // 
            resources.ApplyResources(Lbl_InformeBlog, "Lbl_InformeBlog");
            Lbl_InformeBlog.Name = "Lbl_InformeBlog";
            // 
            // Cmb_Blog
            // 
            resources.ApplyResources(Cmb_Blog, "Cmb_Blog");
            Cmb_Blog.FormattingEnabled = true;
            Cmb_Blog.Items.AddRange(new object[] { resources.GetString("Cmb_Blog.Items"), resources.GetString("Cmb_Blog.Items1") });
            Cmb_Blog.Name = "Cmb_Blog";
            Cmb_Blog.SelectedIndexChanged += Cmb_Blog_SelectedIndexChanged;
            // 
            // Lbl_Blog
            // 
            resources.ApplyResources(Lbl_Blog, "Lbl_Blog");
            Lbl_Blog.Name = "Lbl_Blog";
            // 
            // Msk_Remuneração
            // 
            resources.ApplyResources(Msk_Remuneração, "Msk_Remuneração");
            Msk_Remuneração.Name = "Msk_Remuneração";
            // 
            // Lbl_Remuneração
            // 
            resources.ApplyResources(Lbl_Remuneração, "Lbl_Remuneração");
            Lbl_Remuneração.Name = "Lbl_Remuneração";
            // 
            // Cmb_remoto
            // 
            resources.ApplyResources(Cmb_remoto, "Cmb_remoto");
            Cmb_remoto.FormattingEnabled = true;
            Cmb_remoto.Items.AddRange(new object[] { resources.GetString("Cmb_remoto.Items"), resources.GetString("Cmb_remoto.Items1") });
            Cmb_remoto.Name = "Cmb_remoto";
            // 
            // Lbl_Trabalhoremoto
            // 
            resources.ApplyResources(Lbl_Trabalhoremoto, "Lbl_Trabalhoremoto");
            Lbl_Trabalhoremoto.Name = "Lbl_Trabalhoremoto";
            // 
            // Cmb_Emprego
            // 
            resources.ApplyResources(Cmb_Emprego, "Cmb_Emprego");
            Cmb_Emprego.FormattingEnabled = true;
            Cmb_Emprego.Items.AddRange(new object[] { resources.GetString("Cmb_Emprego.Items"), resources.GetString("Cmb_Emprego.Items1") });
            Cmb_Emprego.Name = "Cmb_Emprego";
            // 
            // Lbl_PrimeiroEmprego
            // 
            resources.ApplyResources(Lbl_PrimeiroEmprego, "Lbl_PrimeiroEmprego");
            Lbl_PrimeiroEmprego.Name = "Lbl_PrimeiroEmprego";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Msk_Remuneração);
            groupBox1.Controls.Add(txt_InformeBlog);
            groupBox1.Controls.Add(Lbl_Remuneração);
            groupBox1.Controls.Add(Lbl_InformeBlog);
            groupBox1.Controls.Add(Lbl_PrimeiroEmprego);
            groupBox1.Controls.Add(Cmb_Blog);
            groupBox1.Controls.Add(Cmb_Emprego);
            groupBox1.Controls.Add(Lbl_Blog);
            groupBox1.Controls.Add(Lbl_Trabalhoremoto);
            groupBox1.Controls.Add(Cmb_remoto);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(Lbl_Qualificaçôes);
            Controls.Add(label4);
            Controls.Add(Lbl_Outras_Informações);
            Controls.Add(label3);
            Controls.Add(lbl_Curriculo);
            Controls.Add(label2);
            Controls.Add(DG_Curriculo);
            Controls.Add(label1);
            Controls.Add(Tls_Principal);
            Controls.Add(Grp_Qualificaçôes);
            Controls.Add(Grb_Dados_Pessoais);
            Name = "Form1";
            Grb_Dados_Pessoais.ResumeLayout(false);
            Grb_Dados_Pessoais.PerformLayout();
            Grp_Qualificaçôes.ResumeLayout(false);
            Grp_Qualificaçôes.PerformLayout();
            Tls_Principal.ResumeLayout(false);
            Tls_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DG_Curriculo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Curriculo;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_DataNasc;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private Label Lbl_Telefone;
        private MaskedTextBox Msk_DataNasc;
        private Label Lbl_Logradouro;
        private TextBox Txt_Logradouro;
        private GroupBox Grb_Dados_Pessoais;
        private Label Lbl_Uf;
        private TextBox Txt_Cidade;
        private Label Lbl_Cidade;
        private Label Lbl_Bairo;
        private TextBox Txt_Numero;
        private Label Lbl_Numero;
        private Label Lbl_Cep;
        private Label Lbl_Outras_Informações;
        private Label Lbl_Qualificaçôes;
        private GroupBox Grp_Qualificaçôes;
        private TextBox Txt_Curso;
        private Label Lbl_Curso;
        private TextBox Txt_SiteQUali;
        private Label Lbl_CiteQuali;
        private ToolStrip Tls_Principal;
        private TextBox Txt_Curso3;
        private TextBox Txt_Curso2;
        private TextBox Txt_SiteQUali3;
        private TextBox Txt_SiteQUali2;
        private TextBox Txt_Curso4;
        private TextBox Txt_SiteQUali4;
        private ComboBox Cmb_Estados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripButton Tls_limpar;
        private ToolStripButton Tls_salvar;
        private ToolStripButton Tls_excluir;
        private ToolStripButton Tls_Duvidas;
        private ToolStripButton Tls_Alterar;
        private PictureBox pictureBox1;
        private DataGridView DG_Curriculo;
        private DataGridViewButtonColumn Buscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private TextBox txt_InformeBlog;
        private Label Lbl_InformeBlog;
        private ComboBox Cmb_Blog;
        private Label Lbl_Blog;
        private MaskedTextBox Msk_Remuneração;
        private Label Lbl_Remuneração;
        private ComboBox Cmb_remoto;
        private Label Lbl_Trabalhoremoto;
        private ComboBox Cmb_Emprego;
        private Label Lbl_PrimeiroEmprego;
        private GroupBox groupBox1;
        private MaskedTextBox Msk_Telefone;
        private MaskedTextBox msk_Cep;
        private TextBox Txt_Bairro;
    }
}