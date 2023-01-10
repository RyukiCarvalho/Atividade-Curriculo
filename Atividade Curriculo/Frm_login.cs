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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "" || txt_senha.Text == "")
            {
               MessageBox.Show("Prencha todos os campos!");
            }
            else
            {
                Cls_usuario AcessoLogin = new Cls_usuario(" Usuário");
                if (File.Exists(AcessoLogin.caminhoUsuario))
                {
                    string textoDosUsuarios = File.ReadAllText(AcessoLogin.caminhoUsuario);

                    try
                    {
                        foreach (string linha in textoDosUsuarios.Split())
                        {
                            string Usuario = linha.Split(';')[0];
                            string senha = linha.Split(';')[1];

                            if (txt_usuario.Text == Usuario && txt_senha.Text == senha)
                            {
                                MessageBox.Show("Seja bem vindo!");
                                Form1 Curriculo = new Form1();
                                Curriculo.Show();
                                
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretas");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }               
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_PromeiroAcesso frm = new Frm_PromeiroAcesso();
            frm.ShowDialog();
        }
        private void chk_Mostrasenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Mostrasenha.Checked)
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_AlterarSenha senha = new Frm_AlterarSenha();
            senha.ShowDialog();
        }
    }
}
