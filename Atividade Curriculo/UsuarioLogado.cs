using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Curriculo
{
    public class UsuarioLogado
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }

        protected UsuarioLogado(string Login, string senha)
        {
            Usuario = Login;
            Senha = senha;
        }
    }
}
