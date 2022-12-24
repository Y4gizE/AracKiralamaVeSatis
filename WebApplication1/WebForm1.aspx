<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:gainsboro;">
   <center>
    <form id="form1" runat="server">
        <h1 style="background-color:#6666FF; width: 273px; position: relative;">Kullanıcı Kayıt</h1>
        <div>
        </div>
        <asp:Table ID="Table1" runat="server" Height="150px" Width="450px" BackColor="#FFFF66" BorderColor="#9999FF" BorderWidth="3px" Font-Size="Large" ForeColor="#003300" style="position:relative;top: 0px;">
            <asp:TableRow>
                <asp:TableCell><label>Kullanıcı Adı  :</label><asp:TextBox ID="kgiris" runat="server" ></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><label style="position:relative;">Parola :</label><asp:TextBox ID="pparola" runat="server" ></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="UyeGiris" runat="server" Text="Üye Giriş" style="position:relative;top:20px;" OnClick="UyeGiris_Click" />
        <p>
            &nbsp;</p>
    </form>
       </center>
</body>
</html>
