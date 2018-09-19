<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VISTA.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
        <link href="<%= ResolveClientUrl("~/Content/bootstrap.min.css") %>" rel="stylesheet" type="text/css" /> 
    <script src="<%= ResolveClientUrl("~/Scripts/jquery-3.3.1.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/bootstrap.min.js") %>" type="text/javascript"></script>


    <link href="Content/Datatables/dataTables.bootstrap4.css" rel="stylesheet" />
    <script src="Scripts/jquery.dataTables.min.js"></script>
    <script src="Scripts/dataTables.bootstrap4.min.js"></script>
    
    <script src="Default.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="principal" runat="server">
    <form runat="server"> 
        <input id="numPregunta" type="hidden" value="0" />

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/servicios/wsPersonas.asmx" />
            </Services>
        </asp:ScriptManager>
        

        <table  id="example" class="table table-striped table-bordered small" style="margin: 0 auto; width:90%" >
  
        </table>

    </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
