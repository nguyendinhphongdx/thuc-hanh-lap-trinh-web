<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Bai17.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .pannel{
            width: 250px;
            height: 350px;
            background-color: #dae6da;
            border: 3px solid #ffcccc;
            box-shadow: 0px 10px 6px -6px #999999;
            line-height: 100px;
            text-align: center;
            border-radius:10px;
            min-width: 250px;
            margin:10px;
            display: flex;
            flex-flow: column;
        }
        .listPannel{
            display:flex;
            padding:5px 15px;
            overflow-x:scroll;
        }
        .image{
           width: 200px;
            height: 220px;
            align-self: center;
        }
        .button{
            padding: 8px 20px;
            width: 80px;
            align-self: flex-end;
            margin-right: 20px;
        }
        
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
       
        <image class="image" src="./assets/login_background_dark.png"/>
        <div >
            <asp:Panel ID= "PanelList"  runat = "server">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
