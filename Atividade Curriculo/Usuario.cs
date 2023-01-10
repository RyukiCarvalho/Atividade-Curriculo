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
            status = true;

            try
            {
                File.AppendAllText(caminhoUsuario,User);
                status = true;
                mensagem = "Usuário salvo com Sucesso." + nome;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Usuário não pode ser salvo conexão com erro " + ex.Message;
            }
        }


    }
}



    

