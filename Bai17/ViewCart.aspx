<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Bai17.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        *{
            font-family: Arial, Helvetica, sans-serif;
            font-size: 14px;
            text-decoration:none;
        }
        body{
            justify-content: center;
            display: flex;
        }
        .wrapper{
            width: 800px;
        }
        table {
            border-collapse: collapse;
            border-radius: 10px;
            overflow: hidden;
            width: 100%;
        }
       table td,table th {
            border: 1px solid #ddd;
            padding: 8px 18px;
            text-align: center;
       }
       table th {
            border: 1px solid rgb(113, 112, 197);
            text-align: center;
       }
       table tr:nth-child(even){background-color: #e6d7d7;}
       table tr:hover {background-color: rgb(163, 174, 241);}
       table th {
            padding-top: 12px;
            padding-bottom: 12px;
            background-color: #692894;
            color: white;
            font-weight: 500;
            font-size: 16px;
            
        }
        .button{
            background-color: rgb(226, 68, 68);
            outline: none;
            border: none;
            padding: 6px 15px;
            border-radius:5px;
            color: white;
            cursor:pointer;
        }
        .button:hover{
            opacity:.7
        }
        .footer{
            display: flex;
            justify-content: space-between;
            padding: 10px;
        }
         .pay {
             background-color: rgb(89, 91, 209);
         }
        .buy-con{
            background-color:yellowgreen;
        }
        .total{
            display: flex;
            justify-content: center;
            align-items: center;
        }
        p{
            font-weight: 700;
            margin-right: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="wrapper">
        <table>
            <thead>
              <tr>
                <th>
                    Hình ảnh
                </th>
                <th>
                    Tên sản phẩm
                </th>
                <th>
                   Gía
                </th>
                <th>
                    Số lượng
                 </th>
                 <th>
                    Thành tiền
                 </th>
                 <th>
                    Cập nhật
                 </th>
              </tr>
            </thead>
               
         <tbody>
           <%foreach (Bai17.Cart cart in carts) { %>
                <tr>
                <td>
                    <img src="<%=cart.Product.Images %>" width="70" height="40"/>
                </td>
                <td>
                    <%=cart.Product.Name %>
                </td>
                <td>
                   <%=cart.Product.Price %> VND
                </td>
                <td>
                     <%=cart.Soluong %>
                 </td>
                 <td>
                     <%=cart.Soluong * cart.Product.Price %>
                 </td>
                 <td>
                    <button runat="server" id="<%@ cart %>" class="button">Xóa</button>
                 </td>
            </tr>
             <%} %>
           
         </tbody>
        </table>
        <div class="footer">
            <div class="group">
                <a href="Products.aspx" class="button buy-con">Mua tiếp</a>
                <a class="button pay">Thanh Toán</a>
            </div>
            <div class="total">
                <p>Tổng tiền:</p>
                <span><%=totalPrice %> VND</span>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
