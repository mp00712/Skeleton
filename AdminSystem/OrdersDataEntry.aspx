<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="OrderID" width="185px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" Text="Find" style="margin-bottom: 0px" />
        <p>
            <asp:Label ID="lblStockID" runat="server" Text="StockID" width="185px"></asp:Label>
            <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblItemQuantity" runat="server" Text="ItemQuantity" width="185px"></asp:Label>
        <asp:TextBox ID="txtItemQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblTotalPrice" runat="server" Text="TotalPrice" width="185px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chKShipment" runat="server" Text="Shipment" />
        </p>
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
