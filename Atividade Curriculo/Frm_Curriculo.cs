using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using Microsoft.VisualBasic;

namespace Atividade_Curriculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            txt_InformeBlog.Enabled = false;

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("AC");
            Cmb_Estados.Items.Add("AL");
            Cmb_Estados.Items.Add("AP");
            Cmb_Estados.Items.Add("AM");
            Cmb_Estados.Items.Add("BA");
            Cmb_Estados.Items.Add("CE");
            Cmb_Estados.Items.Add("DF");
            Cmb_Estados.Items.Add("ES");
            Cmb_Estados.Items.Add("GO");
            Cmb_Estados.Items.Add("MA");
            Cmb_Estados.Items.Add("MT");
            Cmb_Estados.Items.Add("MS");
            Cmb_Estados.Items.Add("MG");
            Cmb_Estados.Items.Add("PA");
            Cmb_Estados.Items.Add("PB");
            Cmb_Estados.Items.Add("PR");
            Cmb_Estados.Items.Add("PE");
            Cmb_Estados.Items.Add("PI");
            Cmb_Estados.Items.Add("RJ");
            Cmb_Estados.Items.Add("RN");
            Cmb_Estados.Items.Add("RS");
            Cmb_Estados.Items.Add("RO");
            Cmb_Estados.Items.Add("RR");
            Cmb_Estados.Items.Add("SC");
            Cmb_Estados.Items.Add("SP");
            Cmb_Estados.Items.Add("SE");
            Cmb_Estados.Items.Add("TO");

            lbl_Curriculo.Text = "Currículo";
            Lbl_Id.Text = "Número indificador";
            Lbl_Nome.Text = "Nome Completo";
            Lbl_DataNasc.Text = "Data De Nascimento:";
            Lbl_Email.Text = "Email:";
            Lbl_Telefone.Text = "Telefone:";
            Lbl_Cep.Text = "CEP:";
            Lbl_Logradouro.Text = "Logradouro:";
            Lbl_Numero.Text = "Numero:";
            Lbl_Bairo.Text = "Bairro:";
            Lbl_Cidade.Text = "Cidade:";
            Lbl_Uf.Text = "UF:";
            Grb_Dados_Pessoais.Text = "Dados Pessoais";
            Lbl_PrimeiroEmprego.Text = "Está se candidatando para o primeiro emprego ?";
            Lbl_Trabalhoremoto.Text = "Tem interesse no trabalho remoto ?";
            Lbl_Remuneração.Text = "Qual a remuneração pretendida ? ";
            Lbl_Blog.Text = "Possui site ou blog ?";
            Lbl_InformeBlog.Text = "Se Tem Informe Aqui";
            Lbl_CiteQuali.Text = " Cite pelo menos 3 ou mais qualidades:";
            Lbl_Curso.Text = " Informe pelo menos um curso realizado:";
            Lbl_Outras_Informações.Text = "Outras informações";
            Lbl_Qualificaçôes.Text = "Qualificações";
            DG_Curriculo.Text = "Buscar Currículos";
            Tls_Principal.Items[0].ToolTipText = "Salvar Currículo";
            Tls_Principal.Items[1].ToolTipText = "Limpando o Currículo selecionado";
            Tls_Principal.Items[2].ToolTipText = "Duvidas entre aqui";
            Tls_Principal.Items[3].ToolTipText = "Excluidno Cliente";
            Tls_Principal.Items[4].ToolTipText = "Alterando Currículo";
            AtualizaArGrid();

            LimparCurriculo();
        }

        private void Cmb_Blog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Blog.Text != "Sim")
            {
                txt_InformeBlog.Enabled = false;
            }
            else
            {
                txt_InformeBlog.Enabled = true;
            }

            if (Cmb_Blog.Text != "Sim")
            {

            }

        }

        private void Tls_salvar_Click(object sender, EventArgs e)
        {
            {
                string Curriculo = "Nome: " + Txt_Nome.Text + "" + "\n"
                  + "Data De Nascimento: " + Msk_DataNasc.Text + "" + "\n"
                  + "Email: " + Txt_Email.Text + "" + "\n"
                  + "Telefone: " + Txt_Telefone.Text + "" + "\n"
                  + "Logradouro: " + Txt_Logradouro.Text + "" + "\n"
                  + "Número: " + Txt_Numero.Text + "" + "\n"
                  + "Cep: " + Txt_cep.Text + "" + "\n"
                  + "Bairro: " + Txt_Bairro.Text + "" + "\n"
                  + "Cidade: " + Txt_Cidade.Text + "" + "\n"
                  + "UF: " + Cmb_Estados.Text + "" + "\n"
                  + "Primeiro Emprego: " + Cmb_Emprego.Text + "" + "\n"
                  + "Interrese em trabalho remoto: " + Cmb_remoto.Text + "" + "\n"
                  + "Remuneração Pretendida: " + Msk_Remuneração.Text + "" + "\n"
                  + "Possui site ou Blog: " + Cmb_Blog.Text + "" + "\n"
                  + "URL: " + txt_InformeBlog.Text + "" + "\n"
                  + "Cursos: " + Txt_Curso.Text + "" + "\n"
                  + "Número indificador: " + Txt_Id.Text + "" + "\n";
                if (Txt_Curso2.Text != "")
                {
                    Curriculo += "Cursos: " + Txt_Curso2.Text + "" + "\n";
                }
                if (Txt_Curso3.Text != "")
                {
                    Curriculo += "Cursos: " + Txt_Curso3.Text + "" + "\n";
                }
                if (Txt_Curso4.Text != "")
                {
                    Curriculo += "Cursos: " + Txt_Curso4.Text + "" + "\n";
                }
                Curriculo += "Qualidade: " + Txt_SiteQUali.Text + "" + "\n";
                if (Txt_SiteQUali2.Text != "")
                {
                    Curriculo += "Qualidade: " + Txt_SiteQUali2.Text + "" + "\n";
                }
                if (Txt_SiteQUali3.Text != "")
                {
                    Curriculo += "Qualidade: " + Txt_SiteQUali3.Text + "" + "\n";
                }
                if (Txt_SiteQUali4.Text != "")
                {
                    Curriculo += "Qualidade: " + Txt_SiteQUali4.Text + "" + "\n";
                }

                if (Cls_Util.Unit.ValidarTelefone(Txt_Telefone.Text) && Cls_Util.Unit.ValidarCep(Txt_cep.Text) 
                    && Cls_Util.Unit.ValidarBlogOuSite(txt_InformeBlog.Text, Cmb_Blog.Text) 
                    && Cls_Util.Unit.ValidaLogradouro(Txt_Logradouro.Text)
                    && Cls_Util.Unit.ValidarEmail(Txt_Email.Text) && Cls_Util.Unit.ValidarNumero(Txt_Numero.Text)
                    && Cls_Util.Unit.ValidarBairro(Txt_Bairro.Text) && Cls_Util.Unit.ValidarCidade(Txt_Cidade.Text) 
                    && Cls_Util.Unit.Validarquali(Txt_SiteQUali.Text, Txt_SiteQUali2.Text, Txt_SiteQUali3.Text)
                    && Cls_Util.Unit.ValidarCurso(Txt_Curso.Text) && Cls_Util.Unit.ValidarId(Txt_Id.Text,"Salvar Json"))
                {
                    salvar s = new salvar("Salvar");
                    if (s.Status)
                    {
                        s.Incluir(Txt_Id.Text, Curriculo);
                        if (s.Status)
                        {
                            MessageBox.Show("Ok: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Err: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Err: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    salvar sa = new salvar("Salvar Json");
                    if (sa.Status)
                    {
                        Cls_Util.Dados C = new Cls_Util.Dados();
                        C = Leitura();
                        C.Fichario("Salvar Json");

                        escreve(C);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel salvar o seu Currículo " + sa.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    AtualizaArGrid();

                    LimparCurriculo();
                }
            }
        }

        private void LimparCurriculo()
        {
            Txt_Cidade.Text = "";
            Txt_Curso.Text = "";
            Txt_Email.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Nome.Text = "";
            Txt_Numero.Text = "";
            Txt_Bairro.Text = "";
            txt_InformeBlog.Text = "";
            Txt_SiteQUali.Text = "";
            Txt_cep.Text = "";
            Msk_DataNasc.Text = "";
            Msk_Remuneração.Text = "";
            Txt_Telefone.Text = "";
            Cmb_Blog.Text = "";
            Cmb_Emprego.Text = "";
            Cmb_remoto.Text = "";
            Cmb_Estados.Text = "";
            Txt_Curso2.Text = "";
            Txt_Curso3.Text = "";
            Txt_Curso4.Text = "";
            Txt_SiteQUali2.Text = "";
            Txt_SiteQUali3.Text = "";
            Txt_SiteQUali4.Text = "";
            Txt_Id.Text = "";
            txt_InformeBlog.Enabled = false;
        }


        Cls_Util.Dados Leitura()
        {
            Cls_Util.Dados C = new Cls_Util.Dados();

            C.Nome = Txt_Nome.Text;
            C.DataDeNascimento = Msk_DataNasc.Text;
            C.Email = Txt_Email.Text;
            C.Telefone = Txt_Telefone.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Numero = Txt_Numero.Text;
            C.CEP = Txt_cep.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Uf = Cmb_Estados.Text;
            C.PrimeiroEmprego = Cmb_Emprego.Text;
            C.InteresseEmTrabalhoRemoto = Cmb_remoto.Text;
            C.Remuneracao = Msk_Remuneração.Text;
            C.SiteBlog = Cmb_Blog.Text;
            C.URL = txt_InformeBlog.Text;
            C.Curso = Txt_Curso.Text;
            C.Curso2 = Txt_Curso2.Text;
            C.Curso3 = Txt_Curso3.Text;
            C.Curso4 = Txt_Curso4.Text;
            C.Qualidades = Txt_SiteQUali.Text;
            C.Qualidades2 = Txt_SiteQUali2.Text;
            C.Qualidades3 = Txt_SiteQUali3.Text;
            C.Qualidades4 = Txt_SiteQUali4.Text;
            C.Id = Txt_Id.Text;
            return C;
        }

        void escreve(Cls_Util.Dados C)
        {

            Txt_Nome.Text = C.Nome;
            Msk_DataNasc.Text = C.DataDeNascimento;
            Txt_Email.Text = C.Email;
            Txt_Telefone.Text = C.Telefone;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Numero.Text = C.Numero;
            Txt_cep.Text = C.CEP;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;
            Cmb_Estados.Text = C.Uf;
            Cmb_Emprego.Text = C.PrimeiroEmprego;
            Cmb_remoto.Text = C.InteresseEmTrabalhoRemoto;
            Msk_Remuneração.Text = C.Remuneracao;
            Cmb_Blog.Text = C.SiteBlog;
            txt_InformeBlog.Text = C.URL;
            Txt_Curso.Text = C.Curso;
            Txt_Curso2.Text = C.Curso2;
            Txt_Curso3.Text = C.Curso3;
            Txt_Curso4.Text = C.Curso4;
            Txt_SiteQUali.Text = C.Qualidades;
            Txt_SiteQUali2.Text = C.Qualidades2;
            Txt_SiteQUali3.Text = C.Qualidades3;
            Txt_SiteQUali4.Text = C.Qualidades4;
            Txt_Id.Text = C.Id;
        }

        private void Tls_limpar_Click(object sender, EventArgs e)
        {
            LimparCurriculo();
        }

        //private void TLS_Buscar_Click(object sender, EventArgs e)
        //{
        //    salvar s = new salvar("Salvar Json");
        //    if (s.Status)
        //    {

        //      List<string> list = new List<string>();
        //      list = s.BuscarTodos();
        //        if (s.Status)
        //        {

        //          List<List<string>> listBusca = new List<List<string>>();

        //          for (int i = 0; i <= list.Count - 1; i++)
        //          {
        //             Cls_Util.Dados C = Cls_Util.DeserializeObject(list[i]);
        //             listBusca.Add(new List<string> { C.Id});
        //          }
        //             Frm_Busca B = new Frm_Busca(listBusca);
        //             B.ShowDialog();
        //            if (B.DialogResult == DialogResult.OK)
        //            {
        //                var idSelect = B.IdSelect;
        //                string SG = s.Buscar(idSelect);
        //                Cls_Util.Dados C = new Cls_Util.Dados();
        //                C = Cls_Util.DeserializeObject(SG);
        //                escreve(C);
        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("Erro: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erro: " + s.mensagem);
        //    }
        // } 

        private void AtualizaArGrid()
        {
            salvar s = new salvar("Salvar Json");
            var listaBusca = s.BuscarTodosFichario("Salvar Json");
            DG_Curriculo.Rows.Clear();
            for (int i = 0; i < listaBusca.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DG_Curriculo);
                row.Cells[0].Value = "Buscar";
                row.Cells[1].Value = listaBusca[i][0].ToString();
                row.Cells[2].Value = listaBusca[i][1].ToString();

                DG_Curriculo.Rows.Add(row);

            }
        }

        private void Tls_excluir_Click(object sender, EventArgs e)
        {

            salvar s = new salvar("Salvar Json");
            if (s.Status)
            {
                s.ApagarJson(Txt_Id.Text);
            }
            if (s.Status)
            {
                MessageBox.Show("Ok: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Err: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            salvar sa = new salvar("Salvar");
            if (sa.Status)
            {
                sa.Apagar(Txt_Id.Text);
            }

            AtualizaArGrid();
            LimparCurriculo();
        }

        private void Tls_Duvidas_Click(object sender, EventArgs e)
        {

            Frm_Duvidas D = new Frm_Duvidas();
            D.ShowDialog();
        }

        private void Tls_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Util.Dados C = new Cls_Util.Dados();
                C = Leitura();
                string CurriculoJson = Cls_Util.SerializeObject(C);

                salvar s = new salvar("Salvar Json");
                if (s.Status)
                {
                    s.Alterar(C.Id, CurriculoJson);
                    if (s.Status)
                    {
                        MessageBox.Show("Ok: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Err: " + s.mensagem, "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Cls_Util.Dados D = new Cls_Util.Dados();
                C = Leitura();
                string CurriculoTxt = Cls_Util.SerializeObject(D);

                salvar sa = new salvar("Salvar");
                if (sa.Status)
                {
                    sa.AlterarTxt(C.Id, CurriculoTxt);
                    if (sa.Status)
                    {

                    }

                }

                AtualizaArGrid();
                LimparCurriculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                salvar s = new salvar("Salvar Json");
                if (s.Status)
                {
                    string id = DG_Curriculo.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string sg = s.Buscar(id);
                    Cls_Util.Dados C = new Cls_Util.Dados();
                    C = Cls_Util.DeserializeObject(sg);
                    escreve(C);
                }
            }
        }


        //inutil 


        private void Form1_Load(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void Cmb_Emprego_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void Cmb_Estados_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void Txt_Nome_TextChanged(object sender, EventArgs e)
        { }

        private void Txt_Nome_Click(object sender, EventArgs e)
        { }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { }

        private void groupBox1_Enter(object sender, EventArgs e)
        { }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void Lbl_Qualificaçôes_Click(object sender, EventArgs e)
        { }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void Grp_OutrasInformações_Enter(object sender, EventArgs e)
        { }

        private void Txt_Numero_TextChanged(object sender, EventArgs e)
        { }

        private void Lbl_Nome_Click(object sender, EventArgs e)
        { }

        private void Txt_Cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_Emprego_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Lbl_Outras_Informações_Click(object sender, EventArgs e)
        {

        }
    }
}

