<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Eliminar.aspx.cs" Inherits="Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
function ShowSelected()
{
/* Para obtener el valor */
        var cod = document.getElementById("DropDownList1").value;
//alert(cod);
 
/* Para obtener el texto */
        var combo =
            document.getElementById("DropDownList1");
        var selected =
            combo.options[combo.selectedIndex].text;
    //    alert(selected);
        if (confirm('¿Estas seguro de eliminar'+  combo + '-' + selected)) {
            return true;
        }
        else {
            return false;
        }	
}
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnkEliminar" runat="server" OnClientClick="" OnClick="LinkButton1_Click">Eliminar</asp:LinkButton>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:DropDownList  ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="nombre" DataValueField="id">
            </asp:DropDownList>
            <asp:ObjectDataSource  ID="ObjectDataSource1" runat="server" SelectMethod="getAll" TypeName="DATOS.daos.PersonaDAO"></asp:ObjectDataSource>
            <asp:Button ID="btnEliminar2" runat="server" OnClick="btnEliminar2_Click" Text="Eliminar Combo" OnClientClick = "return ShowSelected();"/>
        </div>
    </form>
</body>
</html>
