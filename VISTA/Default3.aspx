<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            </Columns>
        </asp:GridView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/xml/XMLFile1.xml" XPath="bookstore/genre[@name='fiction']">


        </asp:XmlDataSource>
         <asp:Repeater
        DataSourceID="XmlDataSource1"
        runat="server">
          <ItemTemplate>
              <h1><%# XPath ("book/title") %></h1>
              <b>Price:</b>
              <%# XPath ("book/price") %>
          </ItemTemplate>
      </asp:Repeater>
    </form>
</body>
</html>
