<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItemList.aspx.cs" Inherits="SchoolProject.CreateShop" %>

<!DOCTYPE html
    <%-->This page is a create a shop page where you`ll be able to create your shop ...--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Items to the database:</h1>
            <asp:Button runat="server" Text="לחץ להוספה" OnClick="Insertbutton" />
            <asp:TextBox ID="InsertCategory" runat="server"  Text="enter category"></asp:TextBox>
            <asp:TextBox ID="InsertName" runat="server"  Text="enter name"></asp:TextBox>
            <asp:TextBox ID="InsertPrice" runat="server" Text="enter base price"></asp:TextBox>
            <asp:TextBox ID="InsertFood_Level" runat="server" Text="enter food level"></asp:TextBox>

        </div>
    </form>
</body>
</html>
