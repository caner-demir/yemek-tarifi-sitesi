<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="tarifoner.aspx.cs" Inherits="Yemek_Sitesi.TarifOner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
            text-align: right;
            font-family: "Segoe UI";
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #d5d5d5; padding-bottom: 5px">
        <table style="width: 600px; border-spacing: 10px; background-color: #f5f5f5; border: 2px solid grey; border-radius: 15px;">
            <tr>
                <td  class="aligned-big-header" colspan= "2";><strong>Tarif Öner</strong></td>
            </tr>
            <tr >
                <td class="auto-style1" ><strong>Tarif Ad:</strong></td>
                <td  >
                    <asp:TextBox ID="TextBoxTarifAd" runat="server" Width="350px" Height="26px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Malzemeler:</strong></td>
                <td >
                    <asp:TextBox ID="TextBoxMalzemeler" runat="server" Height="120px" TextMode="MultiLine" Width="350px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Yapılışı:</strong></td>
                <td >
                    <asp:TextBox ID="TextBoxYapilis" runat="server" Height="180px" TextMode="MultiLine" Width="350px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Tarifi Öneren:</strong></td>
                <td >
                    <asp:TextBox ID="TextBoxTarifOneren" runat="server" Width="350px" Height="26px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Mail Adresi:</strong></td>
                <td >
                    <asp:TextBox ID="TextBoxMailAdresi" runat="server" TextMode="Email" Width="350px" Height="26px" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 120px;">&nbsp;</td>
                <td >
                    <strong>
                    <asp:Button ID="ButtonTarifOner" runat="server" Text="Tarif Öner" Width="150px" Height="30px" Style="font-weight: bold;" Font-Names="Segoe UI" OnClick="ButtonTarifOner_Click" BackColor="Gray" />
                    </strong>
                    </td>
            </tr>
            <tr>
                <td style="width: 120px;">&nbsp;</td>
                <td >&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
