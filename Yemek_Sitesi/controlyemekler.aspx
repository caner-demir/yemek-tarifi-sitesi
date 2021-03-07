<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="controlyemekler.aspx.cs" Inherits="Yemek_Sitesi.Yemekler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style47 {
            background-color: #4775d1;
            margin-left: 0px;
        }
        .auto-style48 {
            width: 100%;
        }
        .auto-style49 {
            text-align: center;
        }
        .auto-style50 {
            margin-left: 5px;
            margin-right: 5px;
        }
        .auto-style51 {
            width: 280px;
        }
        .auto-style52 {
            font-size: large;
        }
        .auto-style53 {
            font-size: x-large;
        }
        .auto-style54 {
            width: 32px;
        }
        .auto-style56 {
            width: 160px;
            font-size: large;
        }
        .auto-style57 {
            width: 100px;
            font-size: large;
            font-family: "Segoe UI";
        }
        .auto-style58 {
            width: 100px;
            font-size: large;
            font-family: "Segoe UI";
            text-align: right;
        }
        .auto-style59 {
            width: 100px;
            font-size: large;
            text-align: right;
        }
        .auto-style61 {
            background-color: #C0C0C0;
            margin-left: 0px;
        }
        .auto-style62 {
            font-size: medium;
        }
        .auto-style63 {
            text-align: center;
            width: 95px;
        }
        .auto-style64 {
            font-size: x-large;
            width: 250px;
        }
        .auto-style65 {
            font-size: x-large;
            width: 115px;
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
                <td class="auto-style64">Yemek Listesi:</td>
                <td class="auto-style65">Sil</td>
                <td class="auto-style53">Düzenle</td>
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
                        <td class="auto-style63">
                            <a href="controlyemekler.aspx?yemekid=<%# Eval("YemekID") %>&islem=sil"><asp:Image ID="Image2" runat="server" Height="32px" ImageUrl="~/Resimler/delete-icon.png" Width="32px" />
                                </a>
                        </td>
                        <td class="auto-style49">
                            <a href="detailsduzenle.aspx?yemekid=<%# Eval("YemekID") %>"><asp:Image ID="Image3" runat="server" Height="32px" ImageUrl="~/Resimler/refresh.png" Width="32px" />
                                </a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style61" Font-Names="Segoe UI">
        
            <table class="auto-style48">
                <tr>
                    <td class="auto-style54">
                        <asp:Button ID="ButtonOpen0" runat="server" CssClass="auto-style52" Height="32px" Text="+" Width="32px" OnClick="ButtonOpen0_Click" />
                    </td>
                    <td class="auto-style54">
                        <asp:Button ID="ButtonClose0" runat="server" CssClass="auto-style52" Height="32px" Text="-" Width="32px" OnClick="ButtonClose0_Click" />
                    </td>
                    <td class="auto-style53">Yemek Ekle:</td>
                </tr>
            </table>
        
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" CssClass="auto-style47" Font-Names="Segoe UI" Style="background-color: #000; background-size: auto; padding-bottom:10px; padding-top:10px; color: #e4e4e4;">
        <table class="auto-style48" style="padding-bottom: 10px; padding-top: 10px">
            <tr>
                <td class="auto-style59" style="font-family: 'Segoe UI'"><strong>Yemek Adı:</strong></td>
                <td class="auto-style56" style="font-family: 'Segoe UI'">
                    <asp:TextBox ID="TextBoxAd" runat="server" CssClass="auto-style62" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style58"><strong>Malzemeler:</strong></td>
                <td class="auto-style56" style="font-family: 'Segoe UI'">
                    <asp:TextBox ID="TextBoxAd0" runat="server" CssClass="auto-style62" Height="150px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style58"><strong>Yemek Tarifi:</strong></td>
                <td class="auto-style56" style="font-family: 'Segoe UI'">
                    <asp:TextBox ID="TextBoxAd1" runat="server" CssClass="auto-style62" Height="200px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style58"><strong>Kategorisi:</strong></td>
                <td class="auto-style56" style="font-family: 'Segoe UI'">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style62" Width="300px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
            <td class="auto-style58"><strong>Yemek Resim:</strong></td>
            <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style62" Width="300px"/>
            </td>
        </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style56" style="font-family: 'Segoe UI'"><strong>
                    <asp:Button ID="ButtonEkle" runat="server" BackColor="White" CssClass="auto-style26" Font-Names="Segoe UI" style="font-size: large; font-weight: bold" Text="Ekle" Width="150px" OnClick="ButtonEkle_Click" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
        
</asp:Content>

