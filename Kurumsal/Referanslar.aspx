<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="Referanslar.aspx.cs" Inherits="Kurumsal.Referanslar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <a href="ReferansEkle.aspx">Referans Ekle</a>

    <h1>Referanslar</h1>
    <p>Referansların listesi burada olacak</p>
    <ul class="liste">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li><span><%#Eval("AdSoyad") %></span>
                    <a href="Referanssil.aspx?ID=<%#Eval("ReferansID") %>">Sil</a>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
