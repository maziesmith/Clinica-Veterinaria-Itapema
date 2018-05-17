using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using System.Xml.Linq;
using System.IO;

namespace prjVeterinariaItapemaNET
{
    public partial class admin : System.Web.UI.Page
    {
        #region Carrega funcionários do arquivo XML

        void CarregaFuncionarios()
        {
            if (File.Exists(Request.PhysicalApplicationPath + @"XMLs\quemsomos.xml"))
            {
                XmlDocument arquivo = new XmlDocument();
                arquivo.Load(Request.PhysicalApplicationPath + @"XMLs\quemsomos.xml");
                XmlNodeList funcionarios = arquivo.GetElementsByTagName("funcionario");
                lblFuncionarios.Text = "<table>";
                lblFuncionarios.Text += "<tr><th>Nome</th><th>Descrição</th><th>Imagem</th></tr>";
                bool par = false;
                foreach (XmlNode funcionario in funcionarios)
                {
                    Image img = new Image();
                    img.ImageUrl = "~/Images/colaborador/" + funcionario["nomeFoto"].InnerText + ".jpg";
                    
                    if (!par)
                    {
                        lblFuncionarios.Text += "<tr><td class='centro'>" + funcionario["nome"].InnerText + "</td><td>" + funcionario["descricao"].InnerText + "</td><td class='centro'>" + funcionario["nomeFoto"].InnerText + "</td></tr>";
                    }
                    else
                    {
                        lblFuncionarios.Text += "<tr><td class='centro par'>" + funcionario["nome"].InnerText + "</td><td class='par'>" + funcionario["descricao"].InnerText + "</td><td class='par centro'>" + funcionario["nomeFoto"].InnerText + "</td></tr>";
                    }
                    par = !par;
                }
                lblFuncionarios.Text += "</table>";
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregaFuncionarios();
        }

        #region Verifica se já tem funcionario cadastrado

        public bool verificaSeJaTem(string esse)
        {
            bool jatem = false;
            XmlDocument arquivo = new XmlDocument();
            arquivo.Load(Request.PhysicalApplicationPath + @"XMLs\quemsomos.xml");
            XmlNodeList funcionarios = arquivo.GetElementsByTagName("funcionario");
            foreach (XmlNode funcionario in funcionarios)
            {
                string nome = funcionario["nome"].InnerText;
                if (nome == esse)
                {
                    jatem = true;
                }
            }
            return jatem;
        }

        #endregion

        #region Gera uma frase de saudação para o usuário administrador

        public string Saudacoes(string esse)
        {
            lblSaudacoes.Text = "Bem vindo, " + esse;
            return lblSaudacoes.Text;
        }

        #endregion

        #region Login

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Request.PhysicalApplicationPath + "XMLs/ContasAcesso.xml");
            XmlNodeList Usuario = xmlDoc.GetElementsByTagName("ADMIN");
            string Username = "";
            string Password = "";
            string xmlUsername = "";
            string xmlPassword = "";
            Username = txtLogin.Text;
            Password = txtPass.Text;

            #region Validação de Login

            for (int i = 0; i < Usuario.Count; i++)
            {
                xmlUsername = Usuario[0]["USERNAME"].InnerText.ToString();
                xmlPassword = Usuario[0]["PASSWORD"].InnerText.ToString();

                if (Username == xmlUsername)
                {
                    if (Password == xmlPassword)
                    {
                        lblMsg.Text = "Login efetuado com sucesso.";
                        pnlLogin.Visible = false; //Desabilita o painel onde se faz o Login
                        pnlFunc.Visible = true; //Habilita o painel onde se adiciona funcionários
                        lblMsg.Text = "";
                        Saudacoes(xmlUsername);
                    }
                    else
                    {
                        lblMsg.Text = "Senha incorreta.";
                    }
                }
                else
                {
                    lblMsg.Text = "Usuário inexistente.";
                }
            }

            #endregion
        }
            

        #endregion

        #region Adiciona funcionários

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validações
            if (txtNome.Text == "")
            {
                lblAviso.Text = "Por favor, digite o nome.";
                txtNome.Focus();
                return;
            }
            if (txtDescricao.Text == "")
            {
                lblAviso.Text = "Por favor, digite a descrição.";
                txtDescricao.Focus();
                return;
            }
            if (upImagem.FileName == "")
            {
                lblAviso.Text = "Por favor, insira a imagem.";
                upImagem.Focus();
                return;
            }
            #endregion

            #region Verifica se já tem
            if (File.Exists(Request.PhysicalApplicationPath + @"XMLs\quemsomos.xml"))
            {
                if (verificaSeJaTem(txtNome.Text))
                {
                    lblAviso.Text = "O funcionário "+txtNome.Text+" já está cadastrado!";
                    txtNome.Text = "";
                    txtNome.Focus();
                    return;
                }
            }
            #endregion

            #region Incluir Funcionario no XML
            string arquivos = Request.PhysicalApplicationPath + @"XMLs\quemsomos.xml";
            XElement documento;

            if (File.Exists(arquivos))
            {
                documento = XElement.Load(arquivos);
            }
            else
            {
                documento = new XElement("funcionarios");
            }

            if (upImagem.PostedFile != null)
            {
                // PostedFile.FileName passa o caminho completo do arquivo na maquina local.
                // Usando a função Substring ele passa para string todos os dados do arquivo.
                string NomeArq = upImagem.PostedFile.FileName.Substring(upImagem.PostedFile.FileName.LastIndexOf(@"\") + 1);

                //Obtém o tipo de arquivo.
                string TipoArq = upImagem.PostedFile.ContentType;

                //Obtém o tamanho do arquivo enviado via formulário.
                int TamanhoArq = upImagem.PostedFile.ContentLength;

                if (TipoArq != "image/jpeg")    //Verifica se o arquivo não é .jpg
                {
                    lblAviso.Text = "Você só pode fazer upload de imagens com a extensão jpg";
                    return;
                }
                //Verifica se o arquivo consegue ser carregado no servidor para ser gravado no diretório correto.
                //Se for menor ou igual a zero, significa que não conseguiu subir o arquivo.
                if (TamanhoArq <= 0)
                {
                    lblAviso.Text = "A tentativa de upLoad do arquivo " + NomeArq + " falhou!";
                }
                else
                {
                    //Salva o arquivo no diretório especificado.
                    upImagem.PostedFile.SaveAs(Request.PhysicalApplicationPath + @"Images\colaborador\" + NomeArq);
                }
            }
            XElement itemProduto = new XElement("funcionario");
            itemProduto.Add(new XElement("nome", txtNome.Text));
            itemProduto.Add(new XElement("descricao", txtDescricao.Text));
            itemProduto.Add(new XElement("nomeFoto", upImagem.FileName.Replace(".jpg","").Replace(".png","")));
            documento.Add(itemProduto);
            documento.Save(arquivos);
            txtNome.Text = "";
            txtDescricao.Text = "";
            //Verifica se o arquivo foi enviado.
           

            CarregaFuncionarios();
            #endregion
        }

        #endregion

    }
}
