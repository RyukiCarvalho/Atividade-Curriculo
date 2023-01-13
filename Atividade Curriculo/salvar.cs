using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Atividade_Curriculo
{
    public class salvar
    {
        public string Salve;
        public string mensagem;
        public bool Status;

        public salvar(string Salvar)
        {
            Status = true;
            try
            {
                if (!(Directory.Exists(Salvar)))
                {
                    Directory.CreateDirectory(Salvar);
                }
                Salve = Salvar;
                mensagem = "Curriculo Salvo";
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Curriculo não pode ser salvo conexão com erro " + ex.Message;
            }
        }

        public void Incluir(string Id, string Curriculo)
        {
            Status = true;

            try
            {
                if (File.Exists(Salve + "\\" + Id + ".txt"))
                {
                    Status = false;
                    mensagem = "Curriculo não pode ser salvo já existe outro com esse Nome ";
                }
                else
                {
                    File.WriteAllText(Salve + "\\" + Id + ".txt", Curriculo);
                    Status = true;
                    mensagem = "Curriculo salvo com Sucesso." + Id;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Curriculo não pode ser salvo conexão com erro " + ex.Message;
            }
        }

        public void IncluirJSon(string Id, string curriculoJson)
        {
            Status = true;

            try
            {
                if (File.Exists(Salve + "\\" + Id + ".Json"))
                {
                    Status = false;
                    mensagem = "Curriculo não pode ser salvo já existe Nome Salvo ";
                }
                else
                {
                    File.WriteAllText(Salve + "\\" + Id + ".Json", curriculoJson);
                    Status = true;
                    mensagem = "Curriculo salvo com Sucesso. " + Id;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Curriculo não pode ser salvo conexão com erro " + ex.Message;

            }
        }

        public string Buscar(string Id)
        {
            Status = true;
            try
            {
                if (!(File.Exists(Salve + "\\" + Id + ".json")))
                {
                    Status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(Salve + "\\" + Id + ".json");
                    Status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return "";
        }

        public void ApagarJson(string Id)
        {
            Status = true;
            try
            {
                if (!(File.Exists(Salve + "\\" + Id + ".Json")))
                {
                    Status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
                else
                {
                    File.Delete(Salve + "\\" + Id + ".json");
                    Status = true;
                    mensagem = "Excluisão efetuada com sucesso. Identificador: " + Id;

                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }

        }

        public void Apagar(string Id)
        {
            Status = true;
            try
            {
                if (!(File.Exists(Salve + "\\" + Id + ".txt")))
                {
                    Status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
                else
                {
                    File.Delete(Salve + "\\" + Id + ".txt");
                    Status = true;
                    mensagem = "Excluisão em forma de Teto foi efetuada com sucesso. Identificador: " + Id;

                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }

        }

        public List<string> BuscarTodos()
        {
            Status = true;
            List<string> list = new List<string>();
            try
            {
                var arquivos = Directory.GetFiles(Salve, "*.Json");
                for (int i = 0; i <= arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(arquivos[i]);

                    Cls_Util.DeserializeObject(conteudo);

                    list.Add(conteudo);

                }
                return list;

            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Erro ao buscar o curriculo: " + ex.Message;
            }
            return list;
        }

        public List<List<string>> BuscarTodosFichario(string DiretorioJson)
        {
            salvar s = new salvar(DiretorioJson);
            if (s.Status)
            {
                List<string> list = new List<string>();
                list = s.BuscarTodos();
                if (s.Status)
                {
                    List<List<string>> listabusca = new List<List<string>>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Cls_Util.Dados C = Cls_Util.DeserializeObject(list[i]);
                        listabusca.Add(new List<string> { C.Id, C.Nome });
                    }
                    return listabusca;
                }
                else
                {
                    throw new Exception(s.mensagem);
                }
            }
            else
            {
                throw new Exception(s.mensagem);
            }
        }

        public void Alterar(string Id, string Curriculo)
        {

            Status = true;

            try
            {
                if (!(File.Exists(Salve + "\\" + Id + ".Json")))
                {
                    Status = false;
                    mensagem = "alteração não pode ser feita porque esse Id não existe ";
                }
                else
                {
                    File.Delete(Salve + "\\" + Id + ".Json");
                    File.WriteAllText(Salve + "\\" + Id + ".Json", Curriculo);
                    Status = true;
                    mensagem = "alteração de Curriculo feita com Sucesso." + Id;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Curriculo não pode ser salvo conexão com erro " + ex.Message;
            }
        }

        public void AlterarTxt(string Id, string Curriculo)
        {

            Status = true;

            try
            {
                if (!(File.Exists(Salve + "\\" + Id + ".txt")))
                {
                    Status = false;
                    mensagem = "alteração não pode ser feita porque esse Id não existe ";
                }
                else
                {
                    File.Delete(Salve + "\\" + Id + ".txt");
                    File.WriteAllText(Salve + "\\" + Id + ".txt", Curriculo);
                    Status = true;
                    mensagem = "alteração de Curriculo em forma de Texto foi concluida com Sucesso." + Id;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                mensagem = "Curriculo não pode ser salvo conexão com erro " + ex.Message;
            }
        }
      
    }
}


