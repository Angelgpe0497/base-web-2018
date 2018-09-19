<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ejecutar.aspx.cs" Inherits="Ejecutar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEjecutar" runat="server" OnClick="btnEjecutar_Click" Text="Ejecutar" />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAllDataset" TypeName="DATOS.daos.PersonaDAO"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
