<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CRUDProject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        Masukkan Id yang ingin di Update atau Delete<br />
    <asp:textbox runat="server" ID="TextBoxid"></asp:textbox><br />
            Name
            <asp:TextBox runat="server" ID="TextBox1" ></asp:TextBox> <br />            
            Address
            <asp:TextBox runat="server" ID="TextBox2" ></asp:TextBox> <br />
            Telepon
            <asp:TextBox runat="server" ID="TextBox3" ></asp:TextBox> <br />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Change" />
        
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="DELETE" />
    </div>
    </form>
</body>
</html>
