<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="sistema.aspx.cs" Inherits="SisBiblioteca.sistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
  <div class="fundoSistema">
    <div class="menu">
        <nav>
            <ul>
                <li><h4> Cadastro </h4></li>
                <li>
                    <ul>
                        <li><a href="view/cadLivro.aspx"> Livro </a></li>
                        <li><a href="view/cadAutor.aspx"> Autor </a></li>
                        <li><a href="view/cadUsuario.aspx"> Usuário </a></li>
                    </ul>
                </li>
                <li><h4> Listas </h4></li>
                <li>
                    <ul>
                        <li><a href="view/listaLivro.aspx"> Livro </a></li>
                        <li><a href="view/listaAutor.aspx"> Autor </a></li>
                        <li><a href="view/listaUsuario.aspx"> Usuário </a></li>
                    </ul>
                </li>
                <li><h4> Pesquisa </h4></li>
                <li>
                    <ul>
                        <li><a href="view/consultaLivro.aspx"> Livro </a></li>
                        <li><a href="view/consultaAutor.aspx"> Autor </a></li>
                        <li><a href="view/consultaUsuario.aspx"> Usuário </a></li>
                    </ul>
                </li>
                <li><h4> Reserva </h4></li>
                <li>
                    <ul>
                        <li><a href="#"> Livro </a></li>
                    </ul>
                </li>
                <li>
                    <asp:LinkButton ID="btnSair" runat="server" OnClick="btnSair_Click">Sair do sistema</asp:LinkButton>
                </li>
           </ul>
        </nav>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
    <asp:Label ID="lblLogin" runat="server" Text=""></asp:Label>
</asp:Content>
