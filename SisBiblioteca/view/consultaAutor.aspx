<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="consultaAutor.aspx.cs" Inherits="SisBiblioteca.consultaAutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Topo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="fundoSistema">
        <div class="tela">
            <table>
                <tr style="font-weight: 700; text-align: center;">
                    <td> Consulta Autor </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
                        <asp:TextBox runat="server" ID="txtNome" AutoPostBack="True" OnTextChanged="txtNome_TextChanged"  />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Gênero: " runat="server" />
                        <asp:TextBox runat="server" ID="txtGen" AutoPostBack="True" OnTextChanged="txtGen_TextChanged"  />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="dgAutor" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="496px" AllowPaging="True" PageSize="5" OnPageIndexChanging="dgAutor_PageIndexChanging">
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
            <div>
                <asp:LinkButton ID="btnVoltar" CssClass="btn btn-novo" 
                PostBackUrl="~/sistema.aspx" runat="server">Voltar</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Rodape" runat="server">
</asp:Content>
