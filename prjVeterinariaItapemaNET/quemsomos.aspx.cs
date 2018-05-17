using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace prjVeterinariaItapemaNET
{
    public partial class quemsomos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument arquivo = new XmlDocument();
            arquivo.Load(Request.PhysicalApplicationPath + @"xmls\quemsomos.xml");
            XmlNodeList funcionarios = arquivo.GetElementsByTagName("funcionario");

            for (int i = 0; i < funcionarios.Count; i++)
            {
                #region Exibir UM funcionario
                Label descricao = new Label();
                descricao.Text = funcionarios[i]["descricao"].InnerText;

                Label nome = new Label();
                nome.CssClass = "nomeColaborador";
                nome.Text = funcionarios[i]["nome"].InnerText +"<br>";

                Panel pnlDadosFuncionario = new Panel();
                pnlDadosFuncionario.CssClass = "fl dadosColaborador";
                pnlDadosFuncionario.Controls.Add(nome);
                pnlDadosFuncionario.Controls.Add(descricao);

                Image imgFuncionario = new Image();
                imgFuncionario.ImageUrl = "~/images/colaborador/"+ funcionarios[i]["nomeFoto"].InnerText +".jpg";

                Panel fotoFuncionario = new Panel();
                fotoFuncionario.CssClass = "fl fotoColaborador";
                fotoFuncionario.Controls.Add(imgFuncionario);

                Panel limparFloats = new Panel();
                limparFloats.CssClass = "cls";

                Panel pnlFuncionario = new Panel();
                pnlFuncionario.CssClass = "fl colaborador espDir";
                pnlFuncionario.Controls.Add(fotoFuncionario);
                pnlFuncionario.Controls.Add(pnlDadosFuncionario);
                pnlFuncionario.Controls.Add(limparFloats);

                pnlQuemSomos.Controls.Add(pnlFuncionario);
                #endregion
            }

        }
    }
}