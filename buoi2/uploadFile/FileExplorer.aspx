<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileExplorer.aspx.cs" Inherits="uploadFile.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <asp:Table id="Table1" runat="server"
        CellPadding="10" 
        GridLines="Both"
        HorizontalAlign="Center">
        <asp:TableHeaderRow id="Table1HeaderRow" 
            BackColor="LightBlue"
            runat="server">
            <asp:TableHeaderCell 
                Scope="Column" 
                Text="Name" />
            <asp:TableHeaderCell  
                Scope="Column" 
                Text="Size" />
        </asp:TableHeaderRow>  
    </asp:Table>
        </div>
    </form>
   
</body>
</html>
