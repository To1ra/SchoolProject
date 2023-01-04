<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateShop.aspx.cs" Inherits="SchoolProject.CreateShop1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <div id ="startShop" style ="visibility:visible;">
    <form id="form1" runat="server">
            <asp:Button onclick="btnSave_Click1" OnClientClick="myFunction()" Text="text" runat="server" />
    <div>
        <label>Shop Password:</label>
        <asp:TextBox ID="ShopPassword" runat="server" />
    </div>

    <div>
        <label>TransferOpt:</label>
        <asp:DropDownList ID="TransferOpt" runat="server">
            <asp:ListItem Value="Blankets">Blankets</asp:ListItem>
            <asp:ListItem Value="Rings">Rings</asp:ListItem>
            <asp:ListItem Value="Other">Other</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <label>Particial:</label>
        <asp:CheckBox ID="Particial" runat="server" />
    </div>
            
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </div>
        </form>
        </div>
    
        
    <script src="JavaScript.js"></script>
</body>
</html>
