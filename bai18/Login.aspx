<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="bai18.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assets/css/all.min.css" rel="stylesheet" />
    <style>
      body {
        display: flex;
        justify-content: space-evenly;
      }
      .group-input {
        display: flex;
        margin: 10px 0px;
        width: 100%;
      }
      .group-input .icon {
        background-color: rgb(123, 38, 156);
        padding: 10px 10px;
        display: flex;
        justify-content: center;
        align-items: center;
        border-bottom-left-radius: 5px;
        border-top-left-radius: 5px;
        color: #e3e3e3;
      }
      .group-input input {
        outline-color: cadetblue;
        outline-offset: 0ch;
        padding-left: 10px;
        flex-grow: 1;
      }
      .btn {
        width: 100%;
        padding: 10px;
        text-transform: uppercase;
        color: #1a0d31;
        background-color: rgb(230, 97, 97);
        transition: all 0.25s ease-in-out;
        cursor: pointer;
        outline: none;
        border: none;
        margin-top: 20px;
      }
      .btn:hover {
        background-color: #155799;
        border-color: #155799;
        color: white;
      }
      .btn:focus {
        background-color: #155799;
        border-color: #155799;
        color: white;
        outline: 5px auto #155799;
      }
      .form-login {
        width: 300px;
        padding: 20px 40px;
        border: 1px solid #e3e3e3;
        background-color: cyan;
        border-radius: 10px;
      }
      .title-form {
        font-size: 20px;
        text-align: center;
        font-weight: 700;
        text-transform: uppercase;
        font-family: cursive;
      } 
      .btn-disabled{
        opacity: .5;
        cursor: not-allowed;
      }
       table{
        font-family: Arial, Helvetica, sans-serif;
        border-collapse: collapse;
      }
      table td, table th {
        border: 1px solid #ddd;
        padding: 8px;
      }

      table tr:nth-child(even){background-color: #f2f2f2;}

      table tr:hover {background-color: #ddd;}

      table th {
        padding-top: 12px;
        padding-bottom: 12px;
        text-align: left;
        background-color: #04AA6D;
        color: white;
      }
      .text-loginFail{
          color:red;
      }
      .title-table{
          font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
      }
    </style>
    <script>
        function validate(data){
            const username = document.getElementById("username").value;
            const password = document.getElementById("password").value;
            if(username.length<6 || password.length<6){
                alert("username or password must not less than 6 cheracters");
                return false
            }else{
                return true
            }
        }
        async function blockLogin(timeblock = 10000) {
            const btnLogin = document.getElementById("btn-login");
            btnLogin.disabled = true;
            btnLogin.innerHTML = "BLOCK";
            btnLogin.classList.toggle("btn-disabled");
            btnLogin.classList.toggle("btn:hover");
            btnLogin.classList.toggle("btn:focus");
            setTimeout(() => {
                btnLogin.disabled = false;
                btnLogin.innerHTML = "lOGIN";
                btnLogin.classList.toggle("btn-disabled");
                btnLogin.classList.toggle("btn:hover");
                btnLogin.classList.toggle("btn:focus");
            }, timeblock);
        }
    </script>
</head>
<body>
     <div class="table-">
            <asp:Label runat="server" CssClass="title-table">Account</asp:Label>
          <asp:Table runat="server" ID="TableAccount" >
            <asp:TableHeaderRow>
              <asp:TableHeaderCell>Username</asp:TableHeaderCell>
              <asp:TableHeaderCell>Password</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
            </asp:TableRow>
          </asp:Table>
        </div>
    <form id="form1" runat="server" onsubmit="return validate()" method="post" action="DoLogin.aspx">
         <div class="form-login">
        <div class="title-form">Login</div>
        <div class="group-input">
          <div class="icon">
            <i class="fas fa-user"></i>
          </div>
          <input type="text" placeholder="Username" id="username" name="username"/>
        </div>
        <div class="group-input">
          <div class="icon"><i class="fas fa-unlock-alt"></i></div>
          <input type="password" placeholder="password" id="password"  name="password"/>
        </div>
             <asp:Label runat="server" CssClass="text-loginFail" Text="Đăng nhập thất bại!" ID="label"/>
         <button id="btn-login" class="btn">Login</button>
      </div>
    </form>
    <div class="table-">
          <asp:Label runat="server" CssClass="title-table"><%= loginStatus?"History Session Login":"Login to see history" %></asp:Label>
          <asp:Table runat="server" ID="tblSession" >
            <asp:TableHeaderRow>
              <asp:TableHeaderCell>Account</asp:TableHeaderCell>
              <asp:TableHeaderCell>Time</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
            </asp:TableRow>
          </asp:Table>
        </div>
</body>
    <%       if (block) {%>
             <script>
                 blockLogin();
             </script>
        <%}       %>
</html>
