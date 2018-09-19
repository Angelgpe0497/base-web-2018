<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Agregar.aspx.cs" Inherits="Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Regresar" />
        </div>
    </form>
</body>
</html>
