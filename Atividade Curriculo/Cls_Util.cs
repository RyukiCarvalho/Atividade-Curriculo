using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Atividade_Curriculo
{
    public class Cls_Util
    {

        public class Unit
        {
            public static bool ValidarTelefone(string teleofne)
            {
                bool validar = false;
                if (teleofne.Length == 15)
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("O telefone precisa de 11 Caracteres Numéricos ");
                }
                return validar;
            }

            public static bool ValidarEmail(string Email)
            {
                bool ValidEmail = false;
                int indexArr = Email.IndexOf("@");

                if (indexArr >= 5)
                {
                    int indexDot = Email.IndexOf(".", indexArr);
                    if (indexDot - 1 > indexArr)
                    {
                        if (indexDot + 1 < Email.Length)
                        {
                            string indexDot2 = Email.Substring(indexDot + 1, 1);
                            if (indexDot2 != ".")
                            {
                                ValidEmail = true;
                            }
                            else
                            {
                                MessageBox.Show("Email invalido ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("o seu email Deve terminar ou com .com ou .com.br ou .br");
                        }
                    }
                    else
                    {
                        MessageBox.Show("E obrigado a ter algo escrito Depois do @ é ele deve terminar sempre com um ponto");
                    }
                }
                else
                {
                    MessageBox.Show(" o seu Email tem que ter 5 palavras antes do @");
                }
                return ValidEmail;
            }

            public static bool ValidarBlogOuSite(string site, string Cmb_Blog)
            {
                bool validar = false;
                if (Cmb_Blog == "Sim")
                {
                    if (site.StartsWith("https://") || site.StartsWith("http://"))
                    {
                        if (site.EndsWith(".com") || site.EndsWith(".com.br"))
                        {

                            validar = true;

                        }
                        else
                        {
                            MessageBox.Show("Seu site tem que terminar com '.com' ou com '.com.br'.");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Seu site tem que começar com https:// ou com http://.");

                    }
                    return validar;
                }
                else
                {
                    return true;
                }
            }

            public static bool ValidarCep(string CEP)
            {
                bool validar = false;
                if (CEP.Length == 9)
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("O CEP Precisa De 8 caracteres Numéricos");
                }
                return validar;
            }

            //teste
            public static string GeraJSONCEP(string CEP)
            {
                System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

                int cont;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                Stream stream = resposta.GetResponseStream();
                do
                {
                    cont = stream.Read(buffer, 0, buffer.Length);
                    temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                    sb.Append(temp);

                } while (cont > 0);
                return sb.ToString();

            }


            public static bool ValidaLogradouro(string Logradouro)
            {
                bool validar = false;
                if (Logradouro.Length <= 100)
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("O Logradouro Deve ter no máximo 100 caracteres");
                }
                return validar;
            }

            public static bool ValidarNumero(string Numero)
            {
                bool validar = false;
                if (Numero.Length <= 10)
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("O Número precisa de 10 Caracteres Numéricos ");
                }
                return validar;
            }

            public static bool ValidarBairro(string Bairro)
            {
                bool validar = false;
                if (Bairro.Length <= 80)
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("O Bairro deve ter no máximo 80 Caracteres ");
                }
                return validar;
            }

            public static bool ValidarCidade(string Cidade)
            {
                bool validar = false;
                if (Cidade.Length <= 80)
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("O Cidade deve ter no máximo 80 Caracteres ");
                }
                return validar;
            }

            //public static bool ValidarId(string Id, string DiretorioJson)
            //{
            //    bool validar = false;
            //    if (Id.Length == 6)
            //    {
            //        validar = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("o seu Id obrigatoriamente seis números");
            //    }
            //    return validar;
            //}

            public static bool Validarquali(string Txt_SiteQUali, string Txt_SiteQUali2, string Txt_SiteQUali3)
            {
                bool validar = false;
                if (Txt_SiteQUali != "" && Txt_SiteQUali2 != "" && Txt_SiteQUali3 != "")
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show(" tem que informar três qualificaçôe são obrigadas a serem informadas ");
                }
                return validar;
            }

            public static bool ValidarCurso(string Txt_Curso)
            {
                bool validar = false;
                if (Txt_Curso != "")
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("e obrigado informar pelo menos um curso ");
                }
                return validar;
            }
        }
        public class Dados
        {
            public string Nome { get; set; }
            public string Id { get; set; }
            public string DataDeNascimento { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string CEP { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Uf { get; set; }
            public string PrimeiroEmprego { get; set; }
            public string InteresseEmTrabalhoRemoto { get; set; }
            public string Remuneracao { get; set; }
            public string SiteBlog { get; set; }
            public string URL { get; set; }
            public string Curso { get; set; }
            public string Curso2 { get; set; }
            public string Curso3 { get; set; }
            public string Curso4 { get; set; }
            public string Qualidades { get; set; }
            public string Qualidades2 { get; set; }
            public string Qualidades3 { get; set; }
            public string Qualidades4 { get; set; }
            public void Fichario(string DiretorioJson)
            {
                var CurriculoJson = SerializeObject(this);
                salvar save = new salvar(DiretorioJson);
                if (save.Status)
                {
                    save.IncluirJSon(Id, CurriculoJson);
                    if (!(save.Status))
                    {
                        MessageBox.Show("Já existe um Curriculo com esse nome.");
                    }
                    return;
                }

            }
        }
        public static Dados DeserializeObject(string C)
        {
            return JsonConvert.DeserializeObject<Dados>(C);
        }
        public static string SerializeObject(Dados dados)
        {
            return JsonConvert.SerializeObject(dados);
        }

    }
}






