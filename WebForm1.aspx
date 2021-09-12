<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="StyleSheet" href="estilos.css" type="text/css">
    
    <style type="text/css">
        #MostrarGrafico {
            width: 146px;
        }
    </style>
</head>
<body class="nuevoEstilo2">
    <form id="form1" runat="server">
        <div style="margin-left: 40px" id="Result" class="nuevoEstilo2">
            <asp:Label ID="Label2" runat="server" ClientIDMode="Static" Height="50px" Text="TIENDA DE ELECTRODOMESTICOS" Width="855px" CssClass="nuevoEstilo1"></asp:Label>
            <br />
            <br />
            <asp:CheckBoxList ID="Elec" runat="server" AutoPostBack="True">
                <asp:ListItem>Tostadora</asp:ListItem>
                <asp:ListItem>Vatidora</asp:ListItem>
                <asp:ListItem>Licuadora</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Eliga algun electrodomestico" CssClass="nuevoEstilo2"></asp:Label>
            <br />
            <br />
            <input type="submit" id="MostrarGrafico" runat="server" value="Mostrar Producto" OnServerClick ="MostrarGrafico_ServerClick" visible="True" /><asp:Button ID="Button1" runat="server" Text="Mostar proveedor" OnClick="Button1_Click1" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Listar clientes" Width="162px" />
            <br />
            <br />
            <asp:Label ID="cl1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="cl2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="res" runat="server"></asp:Label>

            <br />

            <asp:Label ID="cl3" runat="server"></asp:Label>

            <br />
            <br />

            <img id="Grafico" runat="server" />
            </div>
    </form>
</body>
</html>
