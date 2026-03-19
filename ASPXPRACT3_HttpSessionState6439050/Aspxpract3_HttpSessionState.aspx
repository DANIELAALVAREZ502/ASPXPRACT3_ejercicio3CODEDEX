<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aspxpract3_HttpSessionState.aspx.cs" Inherits="ASPXPRACT3_HttpSessionState6439050.Aspxpract3_HttpSessionState" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Enter Product - Session</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter Product (Session)</h2>
            Category <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList><br />
            Supplier <asp:DropDownList ID="ddlSupplier" runat="server"></asp:DropDownList><br />
            Product <asp:TextBox ID="txtProduct" runat="server"></asp:TextBox><br />
            Description <br />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox><br />
            Image <asp:TextBox ID="txtImage" runat="server"></asp:TextBox><br />
            Price <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
            Number in Stock <asp:TextBox ID="txtNumberInStock" runat="server"></asp:TextBox><br />
            Number on Order <asp:TextBox ID="txtNumberOnOrder" runat="server"></asp:TextBox><br />
            Reorder Level <asp:TextBox ID="txtReorderLevel" runat="server"></asp:TextBox><br /><br />
            
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
        </div>
    </form>
</body>
</html>
