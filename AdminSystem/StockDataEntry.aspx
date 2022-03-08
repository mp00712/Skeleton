<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockID" runat="server" height="29px" Text="StockID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStockID" runat="server" height="29px"></asp:TextBox>
            <br />
            <asp:Label ID="lblStockName" runat="server" height="29px" Text="Stock Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStockName" runat="server" height="29px"></asp:TextBox>
            <br />
            <asp:Label ID="lblItemQuantity" runat="server" height="29px" Text="Item Quantity"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtItemQuantity" runat="server" height="29px"></asp:TextBox>
            <br />
            <asp:Label ID="lblTotalPrice" runat="server" height="29px" Text="Total Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTotalPrice" runat="server" height="29px"></asp:TextBox>
            <br />
            <asp:Label ID="lblRestockDate" runat="server" height="29px" Text="Restock Date"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtRestockDate" runat="server" height="29px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkStockAvailability" runat="server" height="29px" Text="StockAvailability" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" height="29px"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="29px" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
