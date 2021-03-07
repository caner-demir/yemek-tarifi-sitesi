<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="detailsoneri.aspx.cs" Inherits="Yemek_Sitesi.OneriDetayAdmin" %>
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
        .auto-style50 {
            width: 150px;
            font-family: "Segoe UI";
            text-align: right;
            font-size: large;
        }
        .auto-style62 {
            font-size: medium;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style46" Style="background-color: #000; background-size: auto; padding-bottom: 10px; color: #e4e4e4;">
        <tr>
            <td class="auto-style47" style="font-family: 'Segoe UI'">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Yemek Adı:</strong></td>
            <td>
                    <asp:TextBox ID="TextBoxAd" runat="server" CssClass="auto-style62" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Malzemeler:</strong></td>
            <td>
                    <asp:TextBox ID="TextBoxAd0" runat="server" CssClass="auto-style62" Height="150px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Yemek Tarifi:</strong></td>
            <td>
                    <asp:TextBox ID="TextBoxAd1" runat="server" CssClass="auto-style62" Height="200px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Öneren İsim:</strong></td>
            <td>
                    <asp:TextBox ID="TextBoxAd2" runat="server" CssClass="auto-style62" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Öneren Mail:</strong></td>
            <td>
                    <asp:TextBox ID="TextBoxAd3" runat="server" CssClass="auto-style62" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style50"><strong>Kategori:</strong></td>
            <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style62" Width="300px">
                    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style48">&nbsp;</td>
            <td><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style26" Font-Names="Segoe UI" style="font-size: large; font-weight: bold" Text="Onayla" OnClick="Button1_Click" />
                </strong></td>
        </tr>
    </table>
</asp:Content>
