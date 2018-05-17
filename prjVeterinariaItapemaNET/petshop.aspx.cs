using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace prjVeterinariaItapemaNET
{
    public partial class petshop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel limparFloat = new Panel();
            limparFloat.CssClass = "cls";

            if (Directory.Exists(Request.PhysicalApplicationPath + "images/petshop"))
            {
                string[] arquivos = Directory.GetFiles(Request.PhysicalApplicationPath + "images/petshop");

                for (int i = 0; i < arquivos.Length; i++)
                {
                    #region Monta Produto para ir pra tela
                    string nomeFisicoArquivo = Path.GetFileName( arquivos[i] );
                    string nomeTitulo = Path.GetFileNameWithoutExtension(nomeFisicoArquivo);
                    nomeTitulo = nomeTitulo.Substring(4).Replace("-", " ");

                    Label nomeProduto = new Label();
                    nomeProduto.Text = nomeTitulo;

                    Panel pnlNomeProduto = new Panel();
                    pnlNomeProduto.CssClass = "fl dadosProdutosPetShop";
                    pnlNomeProduto.Controls.Add(nomeProduto);

                    Image imgProduto = new Image();
                    imgProduto.ImageUrl = "~/images/petshop/" + nomeFisicoArquivo;

                    Panel pnlImagemProduto = new Panel();
                    pnlImagemProduto.CssClass = "fl fotoProdutoPetShop";
                    pnlImagemProduto.Controls.Add(imgProduto);

                    Panel pnlItemProduto = new Panel();
                    pnlItemProduto.CssClass = "fl produtoPetShop espDir";
                    pnlItemProduto.Controls.Add(pnlImagemProduto);
                    pnlItemProduto.Controls.Add(pnlNomeProduto);

                    pnlGaleria.Controls.Add(pnlItemProduto);
                    #endregion
                }

                pnlGaleria.Controls.Add(limparFloat);
            }
        }
    }
}