<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloPadrao.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="prjVeterinariaItapemaNET.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>    
        .TextBox
        {
            width:100%;
            border-radius:5px;
            border:thin orange solid;
            padding:5px;
            font-size:.8em;
            font-family:Swis721 Cn BT;
        }
        .Button
        {
            margin:auto;
            width:20%;
            border-radius:5px;
            border:2px orange solid;
            background:transparent;
            padding:5px;
            font-weight:bold;
            font-size:.8em;
            font-family:Swis721 Cn BT;
        }
        table { width:100%; margin:auto; }
        th { background-color: #a6cf45; color: #2B2B2B; }
        td.par { background-color: #e3e4e5; }
        .centro { text-align:center; } 

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlAdmin" runat="server" CssClass=Form>
        <asp:Panel ID="pnlLogin" runat="server">
            <table style="width:400px;margin:auto;">
            <tr>
                <td style="text-align:right;">
                    Login:
                </td>
                <td>
                    <asp:TextBox ID="txtLogin" runat="server" CssClass=TextBox></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right;">
                    Senha: 
                </td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server"   CssClass=TextBox TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnLogar" runat="server" Text="Logar" CssClass=Button 
                        onclick="btnLogar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Text="&nbsp;"></asp:Label>
                </td>
            </tr>
        </table>
        </asp:Panel>
        <asp:Panel ID="pnlFunc" runat="server" Visible=false>
            <asp:Label ID="lblSaudacoes" runat="server" Text="Label"></asp:Label>
            <table>
                
                <tr>
                    <td colspan=7 style="text-align:center; background-color:#f57e2a;font-size:20px; color:White;">PÁGINA DO ADMINISTRADOR</td>
                </tr>
                <tr>
                    <td colspan=7 style="text-align:center; background-color:#2b2b2b;font-size:16px; color:White;">Incluir Funcionário</td>
                </tr>
                <br />
                <tr>
                    <td>Nome:</td>
                    <td><asp:TextBox ID="txtNome" runat="server"></asp:TextBox></td>
                    <td>Descrição:</td>
                    <td><asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                    <td>Selecione uma imagem: </td>
                    <td><asp:FileUpload ID="upImagem" runat="server"  /></td>
                    <td><asp:Button ID="btnAdd" runat="server" Text="Adicionar" onclick="btnAdd_Click" /></td>             
                </tr>
                <tr>
                    <td colspan=7 style="text-align:center; background-color:#2b2b2b;">&nbsp;</td>
                </tr>
                <br />
                <caption>
                    
                    <tr>
                        <td colspan="7">
                            <asp:Label ID="lblFuncionarios" runat="server" Text="&nbsp;"></asp:Label>
                        </td>
                    </tr>
                </caption>
            </table>
            <asp:Label ID="lblAviso" runat="server" Text="&nbsp;"></asp:Label>
    
            <hr />
            
        </asp:Panel>
    </asp:Panel>
</asp:Content>
