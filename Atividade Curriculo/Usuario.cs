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
        public string caminhoUsuarioCiper = "Usuáriocripter.txt";


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

        public void Incluir(string nome, string senha, string User)
        {
            try
            {

                var textociper = Cls_ciper.Encrypt(nome);
                var textoSenha = Cls_ciper.Encrypt(senha);

                if (File.Exists(caminhoUsuarioCiper))
                {

                    var ler = File.ReadAllText(caminhoUsuarioCiper);

                    if (ler.Contains(textociper))
                    {
                        mensagem = "Usuario já existe";
                        status = false;
                    }

                    else
                    {
                        File.AppendAllText(caminhoUsuarioCiper, textociper + ";" + textoSenha + "\n");
                        status = true;
                        mensagem = "Usuário salvo com Sucesso." + nome;
                    }
                }
                else
                {
                    File.AppendAllText(caminhoUsuarioCiper, textociper + ";" + textoSenha + "\n");

                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Usuário não pode ser salvo conexão com erro " + ex.Message;
            }
        }

        public void validarLogin(string Login, string senha)
        {
            if (File.Exists(caminhoUsuarioCiper))
            {
                var textoDosUsuarios = File.ReadAllText(caminhoUsuarioCiper);

                var loginciper = Cls_ciper.Encrypt(Login);
                var texoSenhaciper = Cls_ciper.Encrypt(senha);

                string[] Usuário = textoDosUsuarios.Split();
                for (int i = 0; i < Usuário.Length - 1; i++)
                {
                    string linha = Usuário[i];
                    string Usuario = linha.Split(';')[0];
                    string Senha = linha.Split(';')[1];
                    if (loginciper == Usuario && Senha == texoSenhaciper)
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

        public bool AlterarSenha(string Login, string senha, string SenhaNova)
        {
            if (File.Exists(caminhoUsuarioCiper))
            {
                var textoDosUsuarios = File.ReadAllText(caminhoUsuarioCiper);

                var loginciperNovo = Cls_ciper.Encrypt(Login);
                var texoSenhaciperNovo = Cls_ciper.Encrypt(senha);
                var SenhaNovaCiper = Cls_ciper.Encrypt(SenhaNova);

                string[] Usuário = textoDosUsuarios.Split();
                for (int i = 0; i < Usuário.Length - 1; i++)
                {
                    string linha = Usuário[i];
                    string Usuario = linha.Split(';')[0];
                    string Senha = linha.Split(';')[1];
                    if (loginciperNovo == Usuario && Senha == texoSenhaciperNovo)
                    {

                        var Index = textoDosUsuarios.IndexOf(linha);

                        var teste = Index + 1; 

                        var texto2 = textoDosUsuarios.Remove(teste - 1, linha.Length + 1);

                        File.WriteAllText(caminhoUsuarioCiper, $"{loginciperNovo};{SenhaNovaCiper}\n{texto2}");
                        MessageBox.Show("Senha Alterada");
                        return true;

                        
                    }
                }
                MessageBox.Show("Seu usuario ou senha estão incorretos, por favor verifique");
            }
            return false;
        }
    }
}





