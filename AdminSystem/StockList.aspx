﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="407px" Width="429px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
    &nbsp;
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        &nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
        Enter a StockName
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
