<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="yorumlar.aspx.cs" Inherits="Yemek_Sitesi.YemekDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
        .auto-style2 {
            width: 140px;
        }
        .auto-style5 {
            width: 140px;
            text-align: right;
        }
                
        .auto-style8 {
            width: 600px;
        }
        .auto-style9 {
            text-align: justify;
            font-family: "Segoe UI";
            margin-bottom: 10px;
            margin-left: 10px;
            width: 600px;
        }
        
        </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #d5d5d5">
        <table style="width: 100%; background-color: #f5f5f5; background-size: auto; padding: 20px; border: 2px solid grey; border-radius: 15px;">
            <tr>
                <td style="text-align: center; padding: 5px">
                    <strong><asp:Label ID="Label3" runat="server" CssClass="aligned-big-header" Text="Label"></asp:Label></strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center;">
                    <asp:Image ID="Image1" runat="server" Style="border-radius: 10px; width: 90%; height: auto; display: block; margin-left: auto; margin-right: auto; margin-bottom: 20px"/>
                </td>
            </tr>
        </table>
    </div>
    <asp:DataList ID="DataList2" runat="server" Width="600px" style=" background-size: auto;">
        <ItemTemplate>
            <div style="background-color: #d5d5d5">
                <table style="background-color: #fff; border: 2px solid grey; padding: 20px; border-radius: 15px;">
                    <tr>
                        <td class="auto-style8">
                            <strong>
                            <asp:Label ID="Label4" runat="server" Style="font-family: 'Segoe UI'; font-size: large" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("YorumIcerik") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-family: 'Segoe UI'; clear:both" class="auto-style8">
                            <p style="float:left;"><strong>Puan: </strong><asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label></p>
                            <p style="float:right;"><strong>Tarih: </strong><asp:Label ID="Label6" runat="server" Text='<%#Eval("YorumTarih", "{0:dd/M/yyyy}")%>'></asp:Label></p>
                        </td>
                    </tr>
                
                </table>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <div style="background-color: #d5d5d5; padding-bottom: 5px;">
        <asp:Panel ID="Panel1" runat="server" style="font-size: large; padding-top: 20px; background-color: #f5f5f5; background-size: auto; border: 2px solid grey; padding: 20px; border-radius: 15px;">
            <table style="width: 600px; border-spacing: 10px; background-size: auto">
                <tr>
                    <td class="auto-style5">Yorum Paneli</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Ad Soyad:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="325px" Height="26px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Mail:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="325px" Height="26px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Yorum:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="120px" TextMode="MultiLine" Width="325px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Puan:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="100px" Style="border: 2px solid grey;">
                            <asp:ListItem Value=1>1</asp:ListItem>
                            <asp:ListItem Value=2>2</asp:ListItem>
                            <asp:ListItem Value=3>3</asp:ListItem>
                            <asp:ListItem Value=4>4</asp:ListItem>
                            <asp:ListItem Value=5>5</asp:ListItem>
                            <asp:ListItem Value=6>6</asp:ListItem>
                            <asp:ListItem Value=7>7</asp:ListItem>
                            <asp:ListItem Value=8>8</asp:ListItem>
                            <asp:ListItem Value=9>9</asp:ListItem>
                            <asp:ListItem Value=10>10</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yorum Yap"  Width="150px" Height="30px" Style="font-weight: bold;" Font-Names="Segoe UI" BackColor="#999999"  />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>


