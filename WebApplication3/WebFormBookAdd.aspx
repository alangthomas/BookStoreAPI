<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormBookAdd.aspx.cs" Inherits="WebApplication3.WebFormBookAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="boreder-radius: 5px">
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" BorderColor="#990000" BorderStyle="Solid" Height="26px"></asp:TextBox>
            <br />
            Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" BorderColor="#990000" BorderStyle="Solid" Height="26px"></asp:TextBox>
            <br />
            Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" BorderColor="#990000" BorderStyle="Solid" Height="24px"></asp:TextBox>
            <br />
            Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" BorderColor="#990000" BorderStyle="Solid" Height="24px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#990033" BorderColor="#663300" BorderStyle="Solid" ForeColor="White" Height="35px" OnClick="Button1_Click" style="margin-left: 0px" Text="SUBMIT" Width="167px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
