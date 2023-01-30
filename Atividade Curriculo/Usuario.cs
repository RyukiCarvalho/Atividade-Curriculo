using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.IO;
using Atividade_Curriculo;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection.Metadata.Ecma335;

namespace Atividade_Curriculo
{
    public class Cls_usuario
    {
        public string Login;
        public string senha;
        public string confirmarSenha;
        public bool status;
        public string mensagem;
        public string salve;
        public string caminhoUsuario = "Usuário.txt";

        public Cls_usuario(string Usuário)
        {
            status = true;
            try
            {
                salve = Usuário;
                mensagem = " Usuário Salvo";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Usuário não pode ser salvo conexão com erro " + ex.Message;
            }


        }
        public void Incluir(string nome, string User)
        {

            try
            {
                File.AppendAllText(caminhoUsuario, User);
                status = true;
                mensagem = "Usuário salvo com Sucesso." + nome;
                    
                  
                status = false;
                mensagem = "Usuário não pode ser salvo pois ja existe outro com esse nome." + nome;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Usuário não pode ser salvo conexão com erro " + ex.Message;
            }
        }

        public void validarLogin(string Login, string senha)
        {
            if (File.Exists(caminhoUsuario))
            {
                var textoDosUsuarios = File.ReadAllText(caminhoUsuario);

                string[] Usuário = textoDosUsuarios.Split();
                for (int i = 0; i < Usuário.Length - 1; i++)
                {
                    string linha = Usuário[i];
                    string Usuario = linha.Split(';')[0];
                    string Senha = linha.Split(';')[1];
                    if (Login == Usuario && Senha == senha)
                    {
                        MessageBox.Show("Seja bem vindo!");
                        Form1 Curriculo = new Form1();
                        Curriculo.Show();
                        return;
                    }
                }
                MessageBox.Show("Usuário ou senha incorretas");
            }
        }

        public bool RecuperarSenha(string Login, string senha)
        {
            if (File.Exists(caminhoUsuario))
            {
                var textoDosUsuarios = File.ReadAllText(caminhoUsuario);

                string[] Usuário = textoDosUsuarios.Split();
                for (int i = 0; i < Usuário.Length - 1; i++)
                {
                    string linha = Usuário[i];
                    string Usuario = linha.Split(';')[0];
                    string Senha = linha.Split(';')[1];
                    if (Login == Usuario && Senha == senha)
                    {
                        MessageBox.Show("Sua senha e usuario estão corretos já pode mudar sua senha");
                        return true;
                    }
                    
                }
                MessageBox.Show("Seu usuario ou senha estão incorretos, por favor verifique");
            }

            return false;
        }
    }
}





