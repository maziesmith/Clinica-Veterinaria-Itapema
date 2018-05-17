<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloPadrao.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prjVeterinariaItapemaNET.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/estiloIndex.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
	<script src="js/jquery-3.2.0.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fl coluna1">
		<!--<img src="images/banner/1.jpg" width="100%">-->

		<div id="carousel" class="carousel slide" data-ride="carousel" style="width:100%">
			<!-- Indicadores -->
			<ol class="carousel-indicators">
				<li data-target="#carousel" data-slide-to="0" class="active"></li>
				<li data-target="#carousel" data-slide-to="1"></li>
				<li data-target="#carousel" data-slide-to="2"></li>
			</ol>

			<!-- Área das Imagens -->
			<div class="carousel-inner">
				<div class="item active">
					<img src="images/banner/1.jpg" class="imgClinica" alt="...">
				</div>
				<div class="item">
					<img src="images/banner/2.jpg" class="imgClinica" alt="...">
				</div>
				<div class="item">
					<img src="images/banner/3.jpg" class="imgClinica" alt="...">
				</div>
			</div>

			<!-- Controles -->
			<a class="left carousel-control" href="#carousel" role="button" data-slide="prev">
				<span id="esquerda_banner"><img src="images/banner/esquerda.png"></span>
			</a>
			<a class="right carousel-control" href="#carousel" role="button" data-slide="next">
				<span id="direita_banner"><img src="images/banner/direita.png"></span>
			</a>
		</div>
	</div>
	<div class="fl coluna1de2">
		<h1 class="tituloPagina">Seja Bem Vindo!</h1>
		<p>A Clínica Veterinária Itapema se preocupa com a saúde, higiene e bem-estar do seu amigo. Oferecemos ótimos serviços e profissionais atualizados em congressos e cursos, além da comodidade de fazer quase todos osexames na clínica, Taxi Dog e o Banho e Tosa.</p>
		<p>Nossa missão é atender os animais com amor, focando na prevenção e na cura de doenças. Cuidar do bem-estar dos animais e proporcionar tranquilidade para seus donos.</p>
		<p>Temos a visão de ser reconhecida como a melhor clínica veterinária do Guarujá, com excelência no atendimento médico-veterinário e suporte ao cliente.</p>
		<p>Nossos valores são busca de conhecimento, respeito à vida, amabilidade no trato com os animais e seus proprietários e ética nos procedimentos.</p>
	</div>
	<div class="fl coluna2de2">
		<img src="images/clinica.jpg" class="imgClinica">
	</div>
	<div class="cls"></div>
</asp:Content>
