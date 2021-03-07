<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="detailskategori.aspx.cs" Inherits="Yemek_Sitesi.KategoriAdminDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style46 {
            width: 100%;
        }
        .auto-style47 {
            width: 150px;
        }
        .auto-style48 {
            width: 150px;
            font-family: "Segoe UI";
            text-align: right;
        }
        .auto-style49 {
            font-size: medium;
        }
        .auto-style50 {
            width: 150px;
            font-family: "Segoe UI";
            text-align: right;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <table class="auto-style46" Style="background-color: #000; background-size: auto; padding-bottom: 10px; color: #e4e4e4;">
        <tr>
            <td class="auto-style47" style="font-family: 'Segoe UI'">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Kategori Adı:</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style49" Font-Names="Segoe UI" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style48">&nbsp;</td>
            <td><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style26" Font-Names="Segoe UI" style="font-size: large; font-weight: bold" Text="Güncelle" OnClick="Button1_Click" />
                </strong></td>
        </tr>
    </table>
</asp:Content>
