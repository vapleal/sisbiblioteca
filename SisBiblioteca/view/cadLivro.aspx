<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cadLivro.aspx.cs" Inherits="SisBiblioteca.cadLivro" %>
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
                    <td colspan="2" style="text-align: center;"><h2>Cadastro de Obras</h2></td>
                </tr>
                <tr>
                    <td style="width: 100px;">
                        <asp:label runat="server" text="ISBN: "></asp:label>
                    </td>
                    <td style="width: 400px;">
                        <asp:textbox ID="txtISBN" runat="server"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td><asp:label runat="server" text="Título: "></asp:label></td>
                    <td><asp:textbox ID="txtTitulo" runat="server"></asp:textbox></td>
                </tr>
                <tr>
                    <td><asp:label runat="server" text="Genero: "></asp:label></td>
                    <td>
                        <asp:RadioButton ID="rbFic" runat="server" GroupName="grbGen" Text="Ficção" Checked="True" />
                        <asp:RadioButton ID="rbRom" runat="server" GroupName="grbGen" Text="Romance" />
                        <asp:RadioButton ID="rbPol" runat="server" GroupName="grbGen" Text="Policial" />
                        <asp:RadioButton ID="rbTer" runat="server" GroupName="grbGen" Text="Terror" />
                        <asp:RadioButton ID="rbFan" runat="server" GroupName="grbGen" Text="Fantasia" />
                    </td>
                </tr>
                <tr>
                    <td><asp:label runat="server" text="Autor: "></asp:label></td>
                    <td>
                        <asp:DropDownList ID="dlAutor" runat="server" Height="30px" Width="384px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:label runat="server" text="Sinopse: "></asp:label></td>
                    <td><asp:textbox ID="txtSin" runat="server" Height="74px" TextMode="MultiLine" Width="385px"></asp:textbox></td>
                </tr
                <tr>
                    <td><asp:label runat="server" text="Capa: "></asp:label></td>
                    <td>
                        <asp:FileUpload ID="fuCapa" runat="server" Height="30px" Width="386px" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:linkbutton ID="btnSalvar" runat="server" CssClass="btn btn-ok" Width="100px" OnClick="btnSalvar_Click">Salvar</asp:linkbutton>
                    </td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:linkbutton ID="btnCancelar" runat="server" CssClass="btn btn-cancel" Width="100px" PostBackUrl="~/sistema.aspx">Cancelar</asp:linkbutton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:linkbutton ID="btnNovo" runat="server" CssClass="btn btn-novo" Width="100px" OnClick="btnNovo_Click">Novo</asp:linkbutton>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
