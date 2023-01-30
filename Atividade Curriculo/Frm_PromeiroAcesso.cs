using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Atividade_Curriculo
{
    public partial class Frm_PromeiroAcesso : Form
    {
        public Frm_PromeiroAcesso()
        {
            InitializeComponent();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (txt_primeirouser.Text == "" || txt_senhap.Text == "" || txt_Confrimarsenha.Text == "")
            {
                MessageBox.Show("Prencha todos os campos!");
            }
            else
            {
                string user = "" + txt_primeirouser.Text + ";" + "" + txt_senhap.Text + "\n";

                if (txt_senhap.Text == txt_Confrimarsenha.Text)
                {
                    Cls_usuario salvar = new Cls_usuario("Usuário");
                    if (salvar.status)
                    {
                        salvar.Incluir(txt_primeirouser.Text, user);
                        if (salvar.status)
                        {
                            MessageBox.Show("Seu usuario foi criado com sucesso", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                        else
                        {
                            MessageBox.Show("Esse usuario com esse nome já esxiste ", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel salvar seu usuário", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não estão iguais confira elas novamente", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void chk_Mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Mostrarsenha.Checked)
            {
                txt_senhap.PasswordChar = '\0';
                txt_Confrimarsenha.PasswordChar = '\0';
            }
            else
            {
                txt_senhap.PasswordChar = '*';
                txt_Confrimarsenha.PasswordChar = '*';
            }
        }
      

        private void Limpar()
        {
            txt_primeirouser.Text = "";
            txt_senhap.Text = "";
            txt_Confrimarsenha.Text = "";

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txt_primeirouser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
