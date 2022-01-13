<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BeuticianWeb.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <asp:Panel CssClass="container" ID="PanelEmpty" runat="server">

        <asp:Panel CssClass="row justify-content-md-center" ID="Panel2" runat="server">

            <div class="col col-lg-9 col-md-9 col-12" style="margin-top: 50px; background: #fff; text-align:center; height: 150px">
                <h4 style="line-height:150px">Korpa je prazna.</h4>
            </div>
        </asp:Panel>

    </asp:Panel>

      <asp:Panel ID="PanelProducts" Style="margin-top:50px" runat="server" CssClass="container"></asp:Panel>


</asp:Content>
