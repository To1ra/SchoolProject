<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBy.aspx.cs" Inherits="SchoolProject.ShowBy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<div  style="width: 100px; height: 100px; margin: auto; display: flex; align-items: center;">
  <asp:Label ID="outputLabel" runat="server" />
</div>

             <asp:Button Text="ShowItems" runat="server" onClick="Show_By"   />
</div>
    </form>
</body>
</html>
