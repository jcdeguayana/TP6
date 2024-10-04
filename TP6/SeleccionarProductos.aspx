<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio2.aspx">Volver a Inicio</asp:HyperLink>
        </div>
        <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="grdProductos_PageIndexChanging" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" PageSize="14">
            <Columns>
                <asp:TemplateField HeaderText="Id Producto">
                    <ItemTemplate>
                        <asp:Label ID="lbl_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre Producto">
                    <ItemTemplate>
                        <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Id Proveedor">
                    <ItemTemplate>
                        <asp:Label ID="lblProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio Unitario">
                    <ItemTemplate>
                        <asp:Label ID="lblPrecio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </form>
</body>
</html>
