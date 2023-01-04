<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteItem.aspx.cs" Inherits="SchoolProject.DeleteItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" Text="מחק" OnClick="Delbutton"/>
            <asp:TextBox ID="Delbox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
