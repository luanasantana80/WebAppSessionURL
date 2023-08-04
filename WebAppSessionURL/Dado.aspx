<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dado.aspx.cs" Inherits="WebAppSessionURL.Dado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="LbTxt" runat="server" Text="Name of people: " Font-Bold="True"></asp:Label> 
            <br />
            <asp:Label ID="Label1" runat="server" > </asp:Label> 
            <p></p>
            <asp:Label ID="LbTxT2" runat="server" Text="The address: " Font-Bold="True"></asp:Label> 
            <br />
            <asp:Label ID="Label2" runat="server"> </asp:Label> 
            <p></p>
            <asp:Label ID="LbTxt3" runat="server" Text="Year Birth: " Font-Bold="True"> </asp:Label> 
            <br />
            <asp:Label ID="Label3" runat="server" > </asp:Label> 
            <p></p>
            <asp:Label ID="LbTxt4" runat="server" Text="Telephone: " Font-Bold="True"></asp:Label> 
            <br />
            <asp:Label ID="Label4" runat="server" > </asp:Label> 
            <p>
                <asp:Button ID="Button1" runat="server" Text="Voltar" OnClick="Button1_Click" />
            </p>
        </div>
    </form>
</body>
</html>
