<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Bai17.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            display:flex;
            justify-content:center
        }
        .pannel {
            width: 250px;
            /*height: 310px;*/
            background-color: #dae6da;
            border: 3px solid #ffcccc;
            box-shadow: 0px 10px 6px -6px #999999;
            /*line-height: 100px;*/
            text-align: center;
            border-radius: 10px;
            min-width: 250px;
            margin: 10px;
            display: flex;
            flex-flow: column;
            padding-bottom:10px;
        }
        .listPannel{
            display:flex;
            padding:5px 15px;
            overflow-x:scroll;
            width:1000px;
        }
        .image{
           width: 200px;
            height: 220px;
            align-self: center;
        }
        .button {
            /*width: 80px;*/
            width: 180px;
            align-self: center;
            /*margin-right: 20px;*/
            border: 2px solid #155799;
            padding: 4px 24px;
            font-size: 1em;
            letter-spacing: 1px;
            text-transform: uppercase;
            color: #673ab7;
            background-color: white;
            transition: all 0.25s ease-in-out;
            cursor: pointer;
        }
        .button:hover{
            background-color: #155799;
            border-color: #155799;
            color: white;
        }
        .button:focus {
            background-color: #155799;
            border-color: #155799;
            color: white;
            outline: 5px auto #155799;
          }
        h2 {
            line-height: 0;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div >
            <asp:Panel ID= "PanelList"  runat = "server">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
