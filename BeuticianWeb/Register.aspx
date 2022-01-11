<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BeuticianWeb.Register" %>

<asp:Content ID="RegisterContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container" style="margin-top: 50px; background: #fff; padding: 50px;">
        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Ime:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Prezime:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxSurname" runat="server" ></asp:TextBox>
            </div>
        </div>


        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Adresa:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxAddress" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <label for="inputState">Grad</label>
                
                <asp:DropDownList CssClass="form-control" ID="DropDownListCity" runat="server"></asp:DropDownList>

            </div>
            <div class="form-group col-md-2">
                <label for="exampleInputEmail1">Poštanski broj:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxZipCode" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Email adresa:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxEmail" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Broj telefona:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxPhone" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputPassword1">Lozinka:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxPassword" TextMode="Password" runat="server"></asp:TextBox>

            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputPassword1">Potvrdi lozinku:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>


            </div>
        </div>



        <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg" runat="server" Text="Registrujte se" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Imate nalog? </asp:Label>
        <a runat="server" href="Login.aspx">Prijavite se</a>

    </div>
</asp:Content>
