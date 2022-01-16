<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BeuticianWeb.Register" %>

<asp:Content ID="RegisterContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="Scripts/main.js"> </script>
    <div class="container" style="margin-top: 50px; background: #fff; padding: 50px;">


        <asp:Label ID="LabelErrorEmpty" runat="server" Text="Polja označena sa * moraju biti popunjena!" Visible="false"></asp:Label>
         <asp:Label ID="LabelErrorCustomerExists" runat="server" Text="Nalog sa unetom email adresom već postoji!" Visible="false"></asp:Label>
        <br/>
        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Ime:</label>
                <label for="" style="color: red;">*</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Prezime:</label>
                <label for="" style="color: red;">*</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxSurname" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Adresa:</label>
                <label for="" style="color: red;">*</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxAddress" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <label for="inputState">Grad</label>
                <label for="" style="color: red;">*</label>

                <asp:DropDownList onchange="dropDownListValueChange(this.value);" AppendDataBoundItems="False" AutoPostBack="false" CssClass="form-control" ID="DropDownListCity" runat="server"></asp:DropDownList>

            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Poštanski broj:</label>
                <label for="" style="color: red;">*</label>
                <asp:TextBox ClientIDMode="Static" CssClass="form-control" ID="TextBoxZipCode" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Email adresa:</label>
                <label for="" style="color: red;">*</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxEmail" runat="server"></asp:TextBox>
                 <asp:Label ID="LabelErrorEmail" runat="server" Text="Email adresa nije validna!" Visible="false"></asp:Label>
            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputEmail1">Broj telefona:</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxPhone" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="exampleInputPassword1">Lozinka:</label>
                <label for="" style="color: red; ">*</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxPassword" TextMode="Password" runat="server"></asp:TextBox>
                 <asp:Label ID="LabelErrorPassword" runat="server" Text="Lozinka mora imate najmanje 8 karaktera!" Visible="false"></asp:Label>

            </div>
            <div class="form-group col-md-4">
                <label for="exampleInputPassword1">Potvrdi lozinku:</label>
                <label for="" style="color: red;">*</label>
                <asp:TextBox CssClass="form-control" ID="TextBoxConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
                 <asp:Label ID="LabelErrorConfirmPassword" runat="server" Text="Lozinke se ne poklapaju!" Visible="false"></asp:Label>

            </div>
        </div>



        <asp:Button ID="ButtonRegister" OnClick="ButtonRegister_Click" CssClass="btn btn-primary btn-lg" runat="server" Text="Registrujte se" />
        <br />
        <br />
        <label for="" style="color: red">* Ova polja su neophodna.</label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Imate nalog? </asp:Label>
        <a runat="server" href="Login.aspx">Prijavite se</a>

    </div>

    <script>

</script>


</asp:Content>
