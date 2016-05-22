<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUDProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            id
            <asp:TextBox runat="server" ID="txtId" ></asp:TextBox> <br />
            Name
            <asp:TextBox runat="server" ID="TextBox1" ></asp:TextBox> <br />            
            Address
            <asp:TextBox runat="server" ID="TextBox2" ></asp:TextBox> <br />
            Telepon
            <asp:TextBox runat="server" ID="TextBox3" ></asp:TextBox> 
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submit" />
        </div>
    <div>
     <asp:gridview ID="Contact_Gridview" runat="server"></asp:gridview>
    </div>
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </form>
</body>
</html>
