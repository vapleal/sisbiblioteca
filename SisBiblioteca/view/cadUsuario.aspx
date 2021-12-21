<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cadUsuario.aspx.cs" Inherits="SisBiblioteca.cadUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .caduser {
           position: relative;
           top: 50px;
           padding-left: 10px;
           padding-right: 10px;
           padding-top: 10px;
       }
       .btn-cad {
           width: 70px;
           position: relative;
       }
       select {
        }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="fundoSistema">
        <div class="tela">
            <div class="caduser">
                <asp:Label ID="Label2" runat="server" Text="Usuário: "></asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" AutoPostBack="True" OnTextChanged="txtUsuario_TextChanged"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Senha: "></asp:Label>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Nível de acesso:"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="drNivelUsu" runat="server" Height="40px" Width="200px">
                    <asp:ListItem Value="0">Administrador</asp:ListItem>
                    <asp:ListItem Value="1">Atendente</asp:ListItem>
                    <asp:ListItem Value="2">Aluno</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="caduser">
                <asp:LinkButton ID="btnEnviar" runat="server" CssClass="btn btn-ok btn-cad" Width="100px" OnClick="btnEnviar_Click">Salvar</asp:LinkButton>
                &nbsp;&nbsp;
                <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" CssClass="btn btn-cancel btn-cad" Width="100px">Cancelar</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnNovo" runat="server" CssClass="btn btn-novo" OnClick="btnNovo_Click" Width="100px">Novo</asp:LinkButton>
            </div>
        </div>
    </div>    

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
