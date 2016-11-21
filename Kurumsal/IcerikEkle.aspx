<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="IcerikEkle.aspx.cs" Inherits="Kurumsal.IcerikEkle" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>İçerik ekleme formu</h1>

    <div class="satir">
        <label>Başlık:</label> <input name="baslik" />
    </div>
    <div class="satir">
        <label>Makale</label>
        <textarea name="makale" id="editor" class="uzunyazi"></textarea>
        <%-- <input id="editor" name="makale" class="uzunyazi" />--%>
    </div>
    <div class="satir">
        <input type="submit" value="KAYDET" />
    </div>
</asp:Content>
