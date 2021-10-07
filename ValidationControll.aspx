<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControll.aspx.cs" Inherits="ServerControll.ValidationControll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">  
   
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style2">User Name</td>  
            <td>  
                <asp:TextBox ID="username" runat="server"></asp:TextBox>  
                <asp:RequiredFieldValidator ID="user" runat="server" ControlToValidate="username"   
                ErrorMessage="Please enter a user name" ForeColor="Red">*</asp:RequiredFieldValidator>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="password" runat="server"></asp:TextBox>  
                <asp:RequiredFieldValidator ID="pass" runat="server" ControlToValidate="password"   
                ErrorMessage="Please enter a password" ForeColor="Red">*</asp:RequiredFieldValidator>  
            </td>  
        </tr>  
    
         <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"   
                ErrorMessage="Please enter a password" ForeColor="Red">*</asp:RequiredFieldValidator>  
            </td>  
        </tr>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2"   
            ControlToValidate="password" Display="Dynamic" ErrorMessage="Enter valid value" ForeColor="Red"   
            Operator="Equal" Type="Integer"></asp:CompareValidator>  
         <tr>  
            <td class="auto-style2">Email ID</td>  
            <td>  
                <asp:TextBox ID="email" runat="server"></asp:TextBox>  
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email"   
                ErrorMessage="Please enter valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">  
                </asp:RegularExpressionValidator>  
            </td>  
        </tr> 
         <tr>  
            <td class="auto-style2">Number</td>  
            <td>  
                <asp:TextBox ID="Number" runat="server"></asp:TextBox>  
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Number"   
                ErrorMessage="Enter value in specified range" ForeColor="Red" MaximumValue="199" MinimumValue="101"   
                SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
            </td>  
        </tr> 
      
        <tr>  
            <td class="auto-style2">  
            <br/>  
            <asp:Button ID="Button1" runat="server" Text="login"/>  
            </td>  
            <td>  
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>  
            <br/>  
            </td>  
        </tr>  
    </table>  
</form>
</body>
</html>
