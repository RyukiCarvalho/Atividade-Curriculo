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
using System.Reflection.Metadata.Ecma335;

namespace Atividade_Curriculo
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        public string Mensagem;
        public bool Status;
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Prencha todos os campos !");
            }
            else
            {
                Cls_usuario AcessoLogin = new Cls_usuario(" Usuário");
                AcessoLogin.validarLogin(txt_usuario.Text, txt_senha.Text); 

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
