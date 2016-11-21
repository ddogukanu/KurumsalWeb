<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="Ayar.aspx.cs" Inherits="Kurumsal.Ayar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Site Ayarları</h1>

    <div class="satir">
        <label>Logo</label> <input type="file" name="logo" /> 
        <img src="eskiresim.jpg" width="50" height="50"/>
    </div>
    <div class="satir">
        <label>Email</label> <input name="email" value="eski email"/>
    </div>
    <div class="satir">
        <label>Copyright</label><input name="copyright" value="eski copyright"/>
    </div>
    <div class="satir"><input type="submit" value="Kaydet" /></div>
</asp:Content>
