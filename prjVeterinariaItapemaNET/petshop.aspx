<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloPadrao.Master" AutoEventWireup="true" CodeBehind="petshop.aspx.cs" Inherits="prjVeterinariaItapemaNET.petshop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/estiloPetShop.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fl coluna1">
		<h1 class="tituloPagina">Pet Shop</h1>

        <asp:Panel ID="pnlGaleria" runat="server" CssClass="coluna1">
        </asp:Panel>
	
	</div>
	<div class="cls"></div>
</asp:Content>
