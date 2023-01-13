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
            this.lbl_Curriculo = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_DataNasc = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Msk_DataNasc = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Grb_Dados_Pessoais = new System.Windows.Forms.GroupBox();
            this.Txt_cep = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Lbl_Uf = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairo = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Lbl_Outras_Informações = new System.Windows.Forms.Label();
            this.Lbl_Qualificaçôes = new System.Windows.Forms.Label();
            this.Grp_Qualificaçôes = new System.Windows.Forms.GroupBox();
            this.Txt_Curso4 = new System.Windows.Forms.TextBox();
            this.Txt_SiteQUali4 = new System.Windows.Forms.TextBox();
            this.Txt_Curso3 = new System.Windows.Forms.TextBox();
            this.Txt_Curso2 = new System.Windows.Forms.TextBox();
            this.Txt_SiteQUali3 = new System.Windows.Forms.TextBox();
            this.Txt_SiteQUali2 = new System.Windows.Forms.TextBox();
            this.Txt_Curso = new System.Windows.Forms.TextBox();
            this.Lbl_Curso = new System.Windows.Forms.Label();
            this.Txt_SiteQUali = new System.Windows.Forms.TextBox();
            this.Lbl_CiteQuali = new System.Windows.Forms.Label();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.Tls_salvar = new System.Windows.Forms.ToolStripButton();
            this.Tls_limpar = new System.Windows.Forms.ToolStripButton();
            this.Tls_Duvidas = new System.Windows.Forms.ToolStripButton();
            this.Tls_excluir = new System.Windows.Forms.ToolStripButton();
            this.Tls_Alterar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DG_Curriculo = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_InformeBlog = new System.Windows.Forms.TextBox();
            this.Lbl_InformeBlog = new System.Windows.Forms.Label();
            this.Cmb_Blog = new System.Windows.Forms.ComboBox();
            this.Lbl_Blog = new System.Windows.Forms.Label();
            this.Msk_Remuneração = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Remuneração = new System.Windows.Forms.Label();
            this.Cmb_remoto = new System.Windows.Forms.ComboBox();
            this.Lbl_Trabalhoremoto = new System.Windows.Forms.Label();
            this.Cmb_Emprego = new System.Windows.Forms.ComboBox();
            this.Lbl_PrimeiroEmprego = new System.Windows.Forms.Label();
            this.Grb_Dados_Pessoais.SuspendLayout();
            this.Grp_Qualificaçôes.SuspendLayout();
            this.Tls_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Curriculo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Curriculo
            // 
            resources.ApplyResources(this.lbl_Curriculo, "lbl_Curriculo");
            this.lbl_Curriculo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_Curriculo.Name = "lbl_Curriculo";
            // 
            // Lbl_Nome
            // 
            resources.ApplyResources(this.Lbl_Nome, "Lbl_Nome");
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Click += new System.EventHandler(this.Lbl_Nome_Click);
            // 
            // Txt_Nome
            // 
            resources.ApplyResources(this.Txt_Nome, "Txt_Nome");
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Click += new System.EventHandler(this.Txt_Nome_Click);
            this.Txt_Nome.TextChanged += new System.EventHandler(this.Txt_Nome_TextChanged);
            // 
            // Lbl_DataNasc
            // 
            resources.ApplyResources(this.Lbl_DataNasc, "Lbl_DataNasc");
            this.Lbl_DataNasc.Name = "Lbl_DataNasc";
            // 
            // Lbl_Email
            // 
            resources.ApplyResources(this.Lbl_Email, "Lbl_Email");
            this.Lbl_Email.Name = "Lbl_Email";
            // 
            // Txt_Email
            // 
            resources.ApplyResources(this.Txt_Email, "Txt_Email");
            this.Txt_Email.Name = "Txt_Email";
            // 
            // Lbl_Telefone
            // 
            resources.ApplyResources(this.Lbl_Telefone, "Lbl_Telefone");
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            // 
            // Msk_DataNasc
            // 
            resources.ApplyResources(this.Msk_DataNasc, "Msk_DataNasc");
            this.Msk_DataNasc.Name = "Msk_DataNasc";
            this.Msk_DataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // Lbl_Logradouro
            // 
            resources.ApplyResources(this.Lbl_Logradouro, "Lbl_Logradouro");
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Logradouro
            // 
            resources.ApplyResources(this.Txt_Logradouro, "Txt_Logradouro");
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            // 
            // Grb_Dados_Pessoais
            // 
            this.Grb_Dados_Pessoais.BackColor = System.Drawing.SystemColors.Control;
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_cep);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Id);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Id);
            this.Grb_Dados_Pessoais.Controls.Add(this.Cmb_Estados);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Telefone);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Uf);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Cidade);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Cidade);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Bairro);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Bairo);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Numero);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Numero);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Cep);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Logradouro);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Logradouro);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Nome);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Nome);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Telefone);
            this.Grb_Dados_Pessoais.Controls.Add(this.Msk_DataNasc);
            this.Grb_Dados_Pessoais.Controls.Add(this.Txt_Email);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_DataNasc);
            this.Grb_Dados_Pessoais.Controls.Add(this.Lbl_Email);
            resources.ApplyResources(this.Grb_Dados_Pessoais, "Grb_Dados_Pessoais");
            this.Grb_Dados_Pessoais.Name = "Grb_Dados_Pessoais";
            this.Grb_Dados_Pessoais.TabStop = false;
            // 
            // Txt_cep
            // 
            resources.ApplyResources(this.Txt_cep, "Txt_cep");
            this.Txt_cep.Name = "Txt_cep";
            // 
            // Txt_Id
            // 
            resources.ApplyResources(this.Txt_Id, "Txt_Id");
            this.Txt_Id.Name = "Txt_Id";
            // 
            // Lbl_Id
            // 
            resources.ApplyResources(this.Lbl_Id, "Lbl_Id");
            this.Lbl_Id.Name = "Lbl_Id";
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            resources.ApplyResources(this.Cmb_Estados, "Cmb_Estados");
            this.Cmb_Estados.Items.AddRange(new object[] {
            resources.GetString("Cmb_Estados.Items"),
            resources.GetString("Cmb_Estados.Items1")});
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.SelectedIndexChanged += new System.EventHandler(this.Cmb_Estados_SelectedIndexChanged);
            // 
            // Txt_Telefone
            // 
            resources.ApplyResources(this.Txt_Telefone, "Txt_Telefone");
            this.Txt_Telefone.Name = "Txt_Telefone";
            // 
            // Lbl_Uf
            // 
            resources.ApplyResources(this.Lbl_Uf, "Lbl_Uf");
            this.Lbl_Uf.Name = "Lbl_Uf";
            // 
            // Txt_Cidade
            // 
            resources.ApplyResources(this.Txt_Cidade, "Txt_Cidade");
            this.Txt_Cidade.Name = "Txt_Cidade";
            // 
            // Lbl_Cidade
            // 
            resources.ApplyResources(this.Lbl_Cidade, "Lbl_Cidade");
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            // 
            // Txt_Bairro
            // 
            resources.ApplyResources(this.Txt_Bairro, "Txt_Bairro");
            this.Txt_Bairro.Name = "Txt_Bairro";
            // 
            // Lbl_Bairo
            // 
            resources.ApplyResources(this.Lbl_Bairo, "Lbl_Bairo");
            this.Lbl_Bairo.Name = "Lbl_Bairo";
            // 
            // Txt_Numero
            // 
            resources.ApplyResources(this.Txt_Numero, "Txt_Numero");
            this.Txt_Numero.Name = "Txt_Numero";
            // 
            // Lbl_Numero
            // 
            resources.ApplyResources(this.Lbl_Numero, "Lbl_Numero");
            this.Lbl_Numero.Name = "Lbl_Numero";
            // 
            // Lbl_Cep
            // 
            resources.ApplyResources(this.Lbl_Cep, "Lbl_Cep");
            this.Lbl_Cep.Name = "Lbl_Cep";
            // 
            // Lbl_Outras_Informações
            // 
            resources.ApplyResources(this.Lbl_Outras_Informações, "Lbl_Outras_Informações");
            this.Lbl_Outras_Informações.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Lbl_Outras_Informações.Name = "Lbl_Outras_Informações";
            this.Lbl_Outras_Informações.Click += new System.EventHandler(this.Lbl_Outras_Informações_Click);
            // 
            // Lbl_Qualificaçôes
            // 
            resources.ApplyResources(this.Lbl_Qualificaçôes, "Lbl_Qualificaçôes");
            this.Lbl_Qualificaçôes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Lbl_Qualificaçôes.Name = "Lbl_Qualificaçôes";
            this.Lbl_Qualificaçôes.Click += new System.EventHandler(this.Lbl_Qualificaçôes_Click);
            // 
            // Grp_Qualificaçôes
            // 
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_Curso4);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_SiteQUali4);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_Curso3);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_Curso2);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_SiteQUali3);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_SiteQUali2);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_Curso);
            this.Grp_Qualificaçôes.Controls.Add(this.Lbl_Curso);
            this.Grp_Qualificaçôes.Controls.Add(this.Txt_SiteQUali);
            this.Grp_Qualificaçôes.Controls.Add(this.Lbl_CiteQuali);
            resources.ApplyResources(this.Grp_Qualificaçôes, "Grp_Qualificaçôes");
            this.Grp_Qualificaçôes.Name = "Grp_Qualificaçôes";
            this.Grp_Qualificaçôes.TabStop = false;
            // 
            // Txt_Curso4
            // 
            resources.ApplyResources(this.Txt_Curso4, "Txt_Curso4");
            this.Txt_Curso4.Name = "Txt_Curso4";
            // 
            // Txt_SiteQUali4
            // 
            resources.ApplyResources(this.Txt_SiteQUali4, "Txt_SiteQUali4");
            this.Txt_SiteQUali4.Name = "Txt_SiteQUali4";
            // 
            // Txt_Curso3
            // 
            resources.ApplyResources(this.Txt_Curso3, "Txt_Curso3");
            this.Txt_Curso3.Name = "Txt_Curso3";
            // 
            // Txt_Curso2
            // 
            resources.ApplyResources(this.Txt_Curso2, "Txt_Curso2");
            this.Txt_Curso2.Name = "Txt_Curso2";
            // 
            // Txt_SiteQUali3
            // 
            resources.ApplyResources(this.Txt_SiteQUali3, "Txt_SiteQUali3");
            this.Txt_SiteQUali3.Name = "Txt_SiteQUali3";
            // 
            // Txt_SiteQUali2
            // 
            resources.ApplyResources(this.Txt_SiteQUali2, "Txt_SiteQUali2");
            this.Txt_SiteQUali2.Name = "Txt_SiteQUali2";
            // 
            // Txt_Curso
            // 
            resources.ApplyResources(this.Txt_Curso, "Txt_Curso");
            this.Txt_Curso.Name = "Txt_Curso";
            // 
            // Lbl_Curso
            // 
            resources.ApplyResources(this.Lbl_Curso, "Lbl_Curso");
            this.Lbl_Curso.Name = "Lbl_Curso";
            // 
            // Txt_SiteQUali
            // 
            resources.ApplyResources(this.Txt_SiteQUali, "Txt_SiteQUali");
            this.Txt_SiteQUali.Name = "Txt_SiteQUali";
            // 
            // Lbl_CiteQuali
            // 
            resources.ApplyResources(this.Lbl_CiteQuali, "Lbl_CiteQuali");
            this.Lbl_CiteQuali.Name = "Lbl_CiteQuali";
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tls_salvar,
            this.Tls_limpar,
            this.Tls_Duvidas,
            this.Tls_excluir,
            this.Tls_Alterar});
            resources.ApplyResources(this.Tls_Principal, "Tls_Principal");
            this.Tls_Principal.Name = "Tls_Principal";
            // 
            // Tls_salvar
            // 
            this.Tls_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Tls_salvar, "Tls_salvar");
            this.Tls_salvar.Name = "Tls_salvar";
            this.Tls_salvar.Click += new System.EventHandler(this.Tls_salvar_Click);
            // 
            // Tls_limpar
            // 
            this.Tls_limpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Tls_limpar, "Tls_limpar");
            this.Tls_limpar.Name = "Tls_limpar";
            this.Tls_limpar.Click += new System.EventHandler(this.Tls_limpar_Click);
            // 
            // Tls_Duvidas
            // 
            this.Tls_Duvidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Tls_Duvidas, "Tls_Duvidas");
            this.Tls_Duvidas.Name = "Tls_Duvidas";
            this.Tls_Duvidas.Click += new System.EventHandler(this.Tls_Duvidas_Click);
            // 
            // Tls_excluir
            // 
            this.Tls_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Tls_excluir, "Tls_excluir");
            this.Tls_excluir.Name = "Tls_excluir";
            this.Tls_excluir.Click += new System.EventHandler(this.Tls_excluir_Click);
            // 
            // Tls_Alterar
            // 
            this.Tls_Alterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Tls_Alterar, "Tls_Alterar");
            this.Tls_Alterar.Name = "Tls_Alterar";
            this.Tls_Alterar.Click += new System.EventHandler(this.Tls_Alterar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // DG_Curriculo
            // 
            this.DG_Curriculo.AllowUserToAddRows = false;
            this.DG_Curriculo.AllowUserToDeleteRows = false;
            this.DG_Curriculo.AllowUserToOrderColumns = true;
            this.DG_Curriculo.BackgroundColor = System.Drawing.Color.Silver;
            this.DG_Curriculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Curriculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buscar,
            this.Id,
            this.Nome});
            this.DG_Curriculo.GridColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.DG_Curriculo, "DG_Curriculo");
            this.DG_Curriculo.Name = "DG_Curriculo";
            this.DG_Curriculo.ReadOnly = true;
            this.DG_Curriculo.RowTemplate.Height = 25;
            this.DG_Curriculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar
            // 
            resources.ApplyResources(this.Buscar, "Buscar");
            this.Buscar.Name = "Buscar";
            this.Buscar.ReadOnly = true;
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // txt_InformeBlog
            // 
            resources.ApplyResources(this.txt_InformeBlog, "txt_InformeBlog");
            this.txt_InformeBlog.Name = "txt_InformeBlog";
            // 
            // Lbl_InformeBlog
            // 
            resources.ApplyResources(this.Lbl_InformeBlog, "Lbl_InformeBlog");
            this.Lbl_InformeBlog.Name = "Lbl_InformeBlog";
            // 
            // Cmb_Blog
            // 
            resources.ApplyResources(this.Cmb_Blog, "Cmb_Blog");
            this.Cmb_Blog.FormattingEnabled = true;
            this.Cmb_Blog.Items.AddRange(new object[] {
            resources.GetString("Cmb_Blog.Items"),
            resources.GetString("Cmb_Blog.Items1")});
            this.Cmb_Blog.Name = "Cmb_Blog";
            // 
            // Lbl_Blog
            // 
            resources.ApplyResources(this.Lbl_Blog, "Lbl_Blog");
            this.Lbl_Blog.Name = "Lbl_Blog";
            // 
            // Msk_Remuneração
            // 
            resources.ApplyResources(this.Msk_Remuneração, "Msk_Remuneração");
            this.Msk_Remuneração.Name = "Msk_Remuneração";
            // 
            // Lbl_Remuneração
            // 
            resources.ApplyResources(this.Lbl_Remuneração, "Lbl_Remuneração");
            this.Lbl_Remuneração.Name = "Lbl_Remuneração";
            // 
            // Cmb_remoto
            // 
            resources.ApplyResources(this.Cmb_remoto, "Cmb_remoto");
            this.Cmb_remoto.FormattingEnabled = true;
            this.Cmb_remoto.Items.AddRange(new object[] {
            resources.GetString("Cmb_remoto.Items"),
            resources.GetString("Cmb_remoto.Items1")});
            this.Cmb_remoto.Name = "Cmb_remoto";
            // 
            // Lbl_Trabalhoremoto
            // 
            resources.ApplyResources(this.Lbl_Trabalhoremoto, "Lbl_Trabalhoremoto");
            this.Lbl_Trabalhoremoto.Name = "Lbl_Trabalhoremoto";
            // 
            // Cmb_Emprego
            // 
            resources.ApplyResources(this.Cmb_Emprego, "Cmb_Emprego");
            this.Cmb_Emprego.FormattingEnabled = true;
            this.Cmb_Emprego.Items.AddRange(new object[] {
            resources.GetString("Cmb_Emprego.Items"),
            resources.GetString("Cmb_Emprego.Items1")});
            this.Cmb_Emprego.Name = "Cmb_Emprego";
            this.Cmb_Emprego.SelectedIndexChanged += new System.EventHandler(this.Cmb_Emprego_SelectedIndexChanged_1);
            // 
            // Lbl_PrimeiroEmprego
            // 
            resources.ApplyResources(this.Lbl_PrimeiroEmprego, "Lbl_PrimeiroEmprego");
            this.Lbl_PrimeiroEmprego.Name = "Lbl_PrimeiroEmprego";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_InformeBlog);
            this.Controls.Add(this.Lbl_InformeBlog);
            this.Controls.Add(this.Cmb_Blog);
            this.Controls.Add(this.Lbl_Blog);
            this.Controls.Add(this.Msk_Remuneração);
            this.Controls.Add(this.Lbl_Remuneração);
            this.Controls.Add(this.Cmb_remoto);
            this.Controls.Add(this.Lbl_Trabalhoremoto);
            this.Controls.Add(this.Cmb_Emprego);
            this.Controls.Add(this.Lbl_PrimeiroEmprego);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Qualificaçôes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Outras_Informações);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Curriculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_Curriculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Grp_Qualificaçôes);
            this.Controls.Add(this.Grb_Dados_Pessoais);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grb_Dados_Pessoais.ResumeLayout(false);
            this.Grb_Dados_Pessoais.PerformLayout();
            this.Grp_Qualificaçôes.ResumeLayout(false);
            this.Grp_Qualificaçôes.PerformLayout();
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Curriculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox Txt_Bairro;
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
        private TextBox Txt_Telefone;
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
        private TextBox Txt_Id;
        private Label Lbl_Id;
        private DataGridViewButtonColumn Buscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private TextBox Txt_cep;
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
    }
}