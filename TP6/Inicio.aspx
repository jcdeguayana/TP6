<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style3 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">Grupo N° 1<br />
            <br />
            <br />
            </strong>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style3" NavigateUrl="~/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
            <strong>
            <br />
            <br />
            </strong>
            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style3" NavigateUrl="~/Inicio2.aspx">Ejercicio 2</asp:HyperLink>
            <strong>
            <br />
            </strong></span>
        </div>
    </form>
</body>
</html>
