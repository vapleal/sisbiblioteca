<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cadAutor.aspx.cs" Inherits="SisBiblioteca.cadAutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table {
            width: 500px;
        }
        table tr {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="fundoSistema">
        <div class="tela">
            <table >
                <tr>
                    <td colspan="2" style="text-align: center;"><h2>Cadastro de Autor</h2></td>
                </tr>
                <tr>
                    <td style="width: 100px;">
                        <asp:label runat="server" text="Nome: "></asp:label>
                    </td>
                    <td style="width: 400px;">
                        <asp:textbox ID="txtNome" runat="server"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td><asp:label runat="server" text="Nacionalidade: "></asp:label></td>
                    <td><asp:textbox ID="txtNacionalidade" runat="server"></asp:textbox></td>
                </tr>
                <tr>
                    <td><asp:label runat="server" text="Genero: "></asp:label></td>
                    <td><asp:textbox ID="txtGenero" runat="server"></asp:textbox></td>
                </tr>
                <tr>
                    <td>
                        <asp:linkbutton ID="btnSalvar" runat="server" CssClass="btn btn-ok" Width="100px" OnClick="btnSalvar_Click">Salvar</asp:linkbutton>
                    </td>
                    <td>
                        <asp:linkbutton ID="btnCancelar" runat="server" CssClass="btn btn-cancel" Width="100px" PostBackUrl="~/sistema.aspx" OnClick="btnCancelar_Click">Cancelar</asp:linkbutton>
                        &nbsp;&nbsp;&nbsp;
                        <asp:linkbutton ID="btnNovo" runat="server" CssClass="btn btn-novo" Width="100px">Novo</asp:linkbutton>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
