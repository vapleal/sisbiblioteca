<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="consultaUsuario.aspx.cs" Inherits="SisBiblioteca.consultaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="fundoSistema">
        <div class="tela">
            <table>
                <tr style="font-weight: 700; text-align: center;">
                    <td> Consulta Usuário </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
                        <asp:TextBox runat="server" ID="txtNome" AutoPostBack="True" OnTextChanged="txtNome_TextChanged" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Login: " runat="server" />
                        <asp:TextBox runat="server" ID="txtUsuario" AutoPostBack="True" OnTextChanged="txtUsuario_TextChanged" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="dgUsuario" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="496px" AllowPaging="True" OnPageIndexChanging="dgUsuario_PageIndexChanging" PageSize="5">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerSettings FirstPageText="Início" LastPageText="Última" Mode="NumericFirstLast" PageButtonCount="3" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
