<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="Yemek_Sitesi.AnaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .no-change { 
            -moz-box-sizing: border-box; 
            -webkit-box-sizing: border-box; 
            box-sizing: border-box; 
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:DataList ID="DataList2" runat="server" style="background-color: #d5d5d5;">
        <ItemTemplate>
            <table style="padding: 20px; border: 2px solid grey; border-radius: 15px; background-color: #f5f5f5; width: 600px">
                <tr>
                    <td style="text-align: center;"><strong>
                        <a href="yorumlar.aspx?yemekid=<%# Eval("YemekId") %>"><asp:Label ID="Label3" runat="server" CssClass="aligned-big-header" Text='<%# Eval("YemekAd") %>'></asp:Label>
                            </a>
                        </strong></td>
                </tr>
                <tr>
                    <td class="justified-text"><strong>Malzemeler:</strong>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>' ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height: 12px;">
                    </td>
                </tr>
                <tr>
                    <td class="justified-text">
                        <asp:Image ID="Image1" runat="server" Style="border-radius: 10px; width: 90%; height: auto; display: block; margin-left: auto; margin-right: auto;" ImageUrl='<%# Eval("YemekResim") %>'/>
                    </td>
                </tr>
                <tr>
                    <td style="height: 12px;">
                    </td>
                </tr>
                <tr>
                    <td class="justified-text"><strong>Yemek Tarifi:</strong>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>' ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height: 12px;">
                    </td>
                </tr>
                <tr>
                    <td class="justified-text" style="clear: both">
                        <p style="float:left;"><strong>Puan:</strong>&nbsp;<asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label></p>
                        <p style="float:right;"><strong>Gönderen: </strong><a href='anasayfa.aspx?gonderen=<%# Eval("Gonderen")%>'><asp:Label ID="Label2" runat="server" Text='<%# Eval("Gonderen") %>'></asp:Label></a></p>
                    </td>
                </tr>
                <tr>
                    <td class="justified-text" style="clear: both">
                        <p style="float:left;"><strong>Yorum Sayısı: </strong><asp:Label ID="Label1" runat="server" Text='<%# Eval("YorumSayisi") %>'></asp:Label></p>
                        <p style="float:right;"><strong>Eklenme Tarihi: </strong><asp:Label ID="Label6" runat="server" Text='<%#Eval("YemekTarih", "{0:dd/M/yyyy}")%>'></asp:Label></p>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <%if (ToplamSayfa > 1) { %>
        <div style="background: #d5d5d5; padding: 5px 0px 5px 0px;">
            <div class="no-change" style="padding: 20px; border: 2px solid grey; border-radius: 15px; background-color: #f5f5f5; width: 600px; text-align: right;">
                <%if (Convert.ToDecimal(SayfaNo) > 1) { %>
                    <asp:HyperLink ID="HyperLink2" runat="server">&larr; Önceki Sayfa</asp:HyperLink>
                <%} %>
                <%if (Convert.ToDecimal(SayfaNo) > 1 && Convert.ToDecimal(SayfaNo) < ToplamSayfa) { %>
                    <h3 style="display: inline"> | </h3>
                <%} %>
                <%if (Convert.ToDecimal(SayfaNo) < ToplamSayfa) { %>
                    <asp:HyperLink ID="HyperLink1" runat="server">Sonraki Sayfa &rarr;</asp:HyperLink>
                <%} %>
            </div>
        </div>
    <%} %>
</asp:Content>

