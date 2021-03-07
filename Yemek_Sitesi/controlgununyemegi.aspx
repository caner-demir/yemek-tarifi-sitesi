<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="controlgununyemegi.aspx.cs" Inherits="Yemek_Sitesi.GununYemegiAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style61 {
            background-color: #C0C0C0;
            margin-left: 0px;
        }
        .auto-style48 {
            width: 100%;
        }
        .auto-style54 {
            width: 32px;
        }
        .auto-style52 {
            font-size: large;
        }
        .auto-style53 {
            font-size: x-large;
        }
        .auto-style50 {
            margin-left: 5px;
            margin-right: 5px;
        }
        .auto-style51 {
            width: 440px;
        }
        .auto-style62 {
            font-size: x-large;
            width: 370px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style61" Font-Names="Segoe UI">
        <table class="auto-style48">
            <tr>
                <td class="auto-style54">
                    <asp:Button ID="ButtonOpen" runat="server" CssClass="auto-style52" Height="32px" Text="+" Width="32px" OnClick="ButtonOpen_Click" />
                </td>
                <td class="auto-style54">
                    <asp:Button ID="ButtonClose" runat="server" CssClass="auto-style52" Height="32px" Text="-" Width="32px" OnClick="ButtonClose_Click" />
                </td>
                <td class="auto-style62">Yemek Listesi:</td>
                <td class="auto-style53">Seç</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Style="background-color: #000; background-size: auto; padding-bottom:10px; padding-top:10px; color: #e4e4e4;">
        <asp:DataList ID="DataList1" runat="server" CssClass="auto-style50" Width="590px">
            <ItemTemplate>
                <table class="auto-style48">
                    <tr>
                        <td class="auto-style51">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>' CssClass="auto-style52" Font-Names="Segoe UI"></asp:Label>
                        </td>
                        <td class="auto-style7">
                            <a href='detailsduzenle.aspx?yemekid=<%# Eval("YemekID") %>'>
                            <asp:Image ID="Image3" runat="server" Height="32px" ImageUrl="~/Resimler/select.png" Width="32px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    </asp:Content>
