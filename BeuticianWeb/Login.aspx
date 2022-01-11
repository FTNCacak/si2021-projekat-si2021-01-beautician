<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BeuticianWeb.Login" %>

<asp:Content ID="LoginContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container" style="margin-top: 50px; background: #fff; padding: 50px;">
        <div class="form-group">
            <label for="exampleInputEmail1">Email adresa:</label>

            <asp:TextBox CssClass="form-control" ID="TextBoxLoginEmail" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Lozinka:</label>
            <asp:TextBox CssClass="form-control" ID="TextBoxLoginPassword" TextMode="Password" runat="server"></asp:TextBox>

        </div>

        <asp:Button ID="ButtonLoginSubmit" CssClass="btn btn-primary btn-lg" runat="server" Text="Prijavite se" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label">Nemate nalog? </asp:Label>
        <a runat="server" href="Register.aspx">Registrujte se</a>
    </div>

</asp:Content>
