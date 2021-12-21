<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="listaUsuario.aspx.cs" Inherits="SisBiblioteca.listaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="fundoSistema">
        <div class="tela">
            <table>
                <tr>
                    <td> Lista de Usuários </td>
                </tr>
                <tr>
                    <td>
                        <asp:gridview runat="server" ID="dgUsuarios" CellPadding="4" ForeColor="#333333" GridLines="None" Width="495px" AllowPaging="True" OnPageIndexChanging="dgUsuarios_PageIndexChanging" PageSize="5">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:HyperLinkField DataNavigateUrlFields="Login do Usuário" DataNavigateUrlFormatString="~/cadUsuario.aspx?user={0}" HeaderText="Ação" Text="Excluir" />
                            </Columns>
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
                        </asp:gridview>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;">
                        <asp:LinkButton ID="btnCancelar" runat="server" 
                            CssClass="btn btn-novo" Width="70px" PostBackUrl="~/sistema.aspx"> Voltar </asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
