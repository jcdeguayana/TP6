<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio2.aspx.cs" Inherits="TP6.Inicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1"><strong>&nbsp;&nbsp;&nbsp; Inicio<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style4" NavigateUrl="~/SeleccionarProductos.aspx">SeleccionarProductos</asp:HyperLink>
            <table class="auto-style2">
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<span class="auto-style1"><asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style4" NavigateUrl="~/EliminarProductosSeleccionados.aspx">Eliminar Productos Seleccionados</asp:HyperLink>
                        </span></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<span class="auto-style1"><asp:HyperLink ID="HyperLink3" runat="server" CssClass="auto-style4" NavigateUrl="~/MostrarProductos.aspx">Mostrar Productos</asp:HyperLink>
                        </span></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </span>
        </div>
    </form>
</body>
</html>
