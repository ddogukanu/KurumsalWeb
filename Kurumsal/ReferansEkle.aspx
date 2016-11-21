<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="ReferansEkle.aspx.cs" Inherits="Kurumsal.ReferansEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Referans ekleme formu</h1>

    <div class="satir">
        <label>AdSoyad:</label> <input name="adsoyad" />
    </div>
    <div class="satir">
        <label>Mesaj</label> <input name="mesaj" class="uzunyazi" />
    </div>
    <div class="satir">
        <input type="submit" value="KAYDET" />
    </div>
</asp:Content>
