<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Status.aspx.cs" Inherits="SessionManagement_1262774.Status" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Status</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Username:</td>
                    <td><asp:Label ID="lblUsername" runat="server" /></td>
                </tr>
                <tr>
                    <td>Account Number:</td>
                    <td><asp:Label ID="lblAccountNum" runat="server" /></td>
                </tr>
                <tr>
                    <td>Last Login:</td>
                    <td><asp:Label ID="lblLastLogin" runat="server" /></td>
                </tr>
                <tr>
                    <td>Status:</td>
                    <td><asp:Label ID="lblStatus" runat="server" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
