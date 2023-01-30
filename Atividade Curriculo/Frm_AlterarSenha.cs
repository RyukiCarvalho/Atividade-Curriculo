using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.LinkLabel;

namespace Atividade_Curriculo
{
    public partial class Frm_AlterarSenha : Form
    {
        public Frm_AlterarSenha()
        {
            InitializeComponent();
        }

        private void chk_mostrarenhanova_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrarenhanova.Checked)
            {
                txt_senhaNova.PasswordChar = '\0';
                txt_SenhaAntiga.PasswordChar = '\0';
            }
            else
            {
                txt_senhaNova.PasswordChar = '*';
                txt_SenhaAntiga.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls_usuario UsuárioSenha = new Cls_usuario(" Usuário");

            if (txt_NomeDoUsuario.Text == "" && txt_SenhaAntiga.Text == "" && txt_SenhaAntiga.Text == "")
            {
                MessageBox.Show("Prencha todos os campos ! ");
            }
            else
            {
                Cls_usuario AcessoLogin = new Cls_usuario(" Usuário");

                if(AcessoLogin.RecuperarSenha(txt_NomeDoUsuario.Text, txt_SenhaAntiga.Text))
                {
                    if (txt_SenhaAntiga.Text == "")
                    {
                        MessageBox.Show("Digite a senha");
                    }
                    else
                    {
                        string SenhaNova = txt_SenhaAntiga.Text;
                        File.Delete(AcessoLogin.senha);
                        File.AppendAllText(AcessoLogin.caminhoUsuario, SenhaNova);
                    }

                }

            }
        }
    }
    
}
