<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloPadrao.Master" AutoEventWireup="true" CodeBehind="faleconosco.aspx.cs" Inherits="prjVeterinariaItapemaNET.faleconosco" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/estiloFaleConosco.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fl coluna1de2">
		<h1 class="tituloPagina">Fale Conosco</h1>
		<p class="subtitulo">Informações de contato </p>

		<p><strong>Endereço:</strong><br>
		Oswaldo Cruz, 1396 -Sítio Paecará - Vicente de Carvalho – Guarujá</p>

		<p><strong>Telefones:</strong><br>
		(13) 3342-7517 / (13) 7814-1573 / 55*114*24637</p>

		<p><strong>E-mail:</strong><br>
		itapemavet@hotmail.com</p>

		<p><strong>Horário de funcionamento:</strong><br>
		Segunda a Sexta das 9h00 às 19h30<br>
		Sábado das 9h00 às 19h00</p>

		<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3284.9122742586806!2d-46.29219729999999!3d-23.9511055!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce03da711f55e9%3A0xb4074c7cb0573f94!2sAv.+Osvaldo+Cruz%2C+1412+-+Parque+Estuario+(Vicente+de+Carvalho)%2C+Guaruj%C3%A1+-+SP%2C+11460-100!5e0!3m2!1spt-BR!2sbr!4v1432926595650" id="mapa" frameborder="0" class="areaMapa" style="border:0"></iframe>

	</div>
	<div class="fl coluna2de2">
		<p class="subtitulo esqSup">Nos envie uma mensagem</p>
		<p>Nome:<br>
        <asp:TextBox ID="txtNome" runat="server" placeholder="Digite seu nome completo" required autofocus></asp:TextBox></p>
        
        <p>Email:<br>
        <asp:TextBox ID="txtEmail" TextMode="Email" runat="server" placeholder="Digite seu email" required></asp:TextBox>
        </p>
		<p>Assunto:<br>
        <asp:DropDownList ID="txtAssunto" runat="server" placeholder="Selecione o assunto da mensagem" required>
            <asp:ListItem>Dúvida</asp:ListItem>
            <asp:ListItem>Reclamação</asp:ListItem>
            <asp:ListItem>Orçamento</asp:ListItem>
            <asp:ListItem>Banho e Tosa</asp:ListItem>
            <asp:ListItem>Outros</asp:ListItem>
        </asp:DropDownList>
        </p>
		<p>Mensagem:<br>
        <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine" Rows="5" placeholder="Digite sua mensagem" required></asp:TextBox>
        </p>

		<p class="areaBotao"><asp:Button ID="btnEnviar" runat="server" Text="Enviar" 
                onclick="btnEnviar_Click" /></p>
		<p class="areaMsg"><asp:Label ID="lblMsg" CssClass="lblMsg" runat="server" Text="&nbsp;"></asp:Label></p>
	</div>
	<div class="cls"></div>
</asp:Content>
