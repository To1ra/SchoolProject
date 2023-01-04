<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SchoolProject.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            NickName:
            <asp:TextBox ID="NickName" runat="server"></asp:TextBox>
            <br />
            Password:
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            FarmName:
            <asp:TextBox ID="FarmName" runat="server"></asp:TextBox>
            <br />
            Farm Level:
            <asp:TextBox ID="FarmLevel" runat="server"></asp:TextBox>
            <br />
            Email:
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            Farm ID:
            <asp:TextBox ID="FarmID" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
