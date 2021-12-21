<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="listaLivro.aspx.cs" Inherits="SisBiblioteca.listaLivro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .tela {
            width: 700px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
    <div class="fundoSistema">
        <div class="tela">
            <table>
                <tr>
                    <td style="text-align: center;"><h2 style="width: 688px">Lista de Livros</h2></td>
                </tr>
                <tr>
                    <td>
                        <asp:gridview runat="server" ID="dgLivros" CellPadding="4" ForeColor="#333333" GridLines="None" Width="692px" AllowPaging="True" PageSize="3" AutoGenerateColumns="False" OnPageIndexChanging="dgLivros_PageIndexChanging">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ImageField DataImageUrlField="Capa" HeaderText="Capa">
                                    <ControlStyle Height="110px" />
                                </asp:ImageField>
                                <asp:BoundField DataField="Título" HeaderText="Título" />
                                <asp:BoundField DataField="Autor" HeaderText="Autor" />
                                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                                <asp:BoundField DataField="Gênero Literário" HeaderText="Gênero Literário" />
                                <asp:HyperLinkField DataNavigateUrlFields="ISBN" DataNavigateUrlFormatString="~/view/cadLivro.aspx?update={0}" HeaderText="Ação" Text="Atualizar" />
                                <asp:HyperLinkField DataNavigateUrlFields="ISBN" DataNavigateUrlFormatString="~/view/cadLivro.aspx?delete={0}" HeaderText="Ação" Text="Excluir" />
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
				<tr>
                    <td style="text-align: right;">
                        <asp:Literal ID="literal" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
