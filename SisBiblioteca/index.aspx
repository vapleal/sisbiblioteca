<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SisBiblioteca.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="Login">
        <div class="label">
            <img src="imagens/logo.png" height="100px" style="margin-top: 50px;" /><br />
            <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
            <br />
        </div>
        <div class="">
            <asp:TextBox ID="txtUsuario" runat="server" BorderStyle="Solid">admin</asp:TextBox>
            <br />
        </div>
        <div class="label">
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            <br />
        </div>
        <div class="">
            <asp:TextBox TextMode="Password" ID="txtSenha" runat="server" BorderStyle="Solid" ></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="btnOK" runat="server" Text="Login" BorderStyle="Solid" CssClass="btn btn-ok" OnClick="btnOK_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">

</asp:Content>
