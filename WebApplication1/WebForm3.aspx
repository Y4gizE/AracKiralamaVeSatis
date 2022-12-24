<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 156px;
        }
        .auto-style2 {
            width: 156px;
            height: 33px;
        }
        .auto-style3 {
            height: 33px;
            width: 1100px;
        }
        .auto-style4 {
            width: 156px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            width: 1100px;
        }
        .auto-style6 {
            width: 156px;
            height: 248px;
        }
        .auto-style7 {
            height: 248px;
            width: 1100px;
        }
        .auto-style8 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 1100px;
        }
        .auto-style11 {
            width: 156px;
            height: 40px;
        }
        .auto-style12 {
            width: 1100px;
            height: 40px;
        }
        .auto-style14 {
            height: 37px;
        }
        .auto-style15 {
            width: 156px;
            height: 37px;
        }
        </style>
</head>
<body style="background-color:darkgray;">
    <form id="form1" runat="server">
    <table style="width:100%;border-width:6px;px;border-color:mediumaquamarine;border-style:dashed;"border="1">
        <tr>
                <td class="auto-style2"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Marka</td>
                <td class="auto-style3">            <asp:DropDownList ID="DropDownListMarka" runat="server" Width="164px" OnSelectedIndexChanged="DropDownListMarka_SelectedIndexChanged">
                <asp:ListItem>Ford</asp:ListItem>
                <asp:ListItem>Toyota</asp:ListItem>
                <asp:ListItem>Audi</asp:ListItem>
            </asp:DropDownList></td>
           </tr>
    
        <div>
        </div>
        
        <tr>
                <td class="auto-style1"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Model</td>
                <td class="auto-style10">&nbsp;<asp:TextBox ID="ModelT" runat="server"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style2"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Motor Hacmi</td>
                <td class="auto-style3">
                    <asp:TextBox ID="MotorTipiT" runat="server" CssClass="auto-style8"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style4"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Yakıt Tipi</td>
                <td class="auto-style5">
                    <asp:TextBox ID="YakitTipi" runat="server"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style1"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Vites Tipi</td>
                <td class="auto-style10">&nbsp;<asp:TextBox ID="VitesTipiT" runat="server" CssClass="auto-style8"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style1"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Renk</td>
                <td class="auto-style10">&nbsp;<asp:TextBox ID="RenkT" runat="server" CssClass="auto-style8"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style2"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Fiyat</td>
                <td class="auto-style3">
                    <asp:TextBox ID="Fiyat" runat="server" CssClass="auto-style8" Width="165px"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style1"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Kilometre</td>
                <td class="auto-style10">&nbsp;<asp:TextBox ID="KilometreT" runat="server" CssClass="auto-style8" Width="158px"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style11"style="font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Ekle</td>
                <td class="auto-style12">&nbsp;<asp:Button ID="Button1" runat="server" Text="Ekle" Width="164px" OnClick="Button1_Click" /></td>
           </tr>
            <td class="auto-style15"style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">Yaz</td>
            <td class="auto-style14"><asp:Button ID="Button2" runat="server" Text="Yazdır" Width="168px" OnClick="Button2_Click" />
        </td>
        <tr><td class="auto-style14">Bilgi Paketi</td><td>
            <asp:Label ID="bilgipaketi" runat="server" Text=""></asp:Label></td></tr>
        <tr>
                <td border="1" class="auto-style6"style="border-style:dotted;border-width:5px;border-color:dodgerblue;font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Son Durum</td>
                <td border="1" class="auto-style7" style="border-style:dotted;border-width:5px;border-color:dodgerblue">   <asp:Label ID="sondurum" runat="server" Text="" BackColor="#FFFFCC"></asp:Label>      </td>
           </tr>
        </table>
    </form>
</body>
</html>
