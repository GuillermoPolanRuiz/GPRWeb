<%@ Page Title="GPRWeb" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GPRWeb._Default"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Styles/Default.css" type="text/css" media="screen" />
    <body class="main-bg">
        <div class="login-container text-c animated flipInX">
                <div>
                    <h1 class="logo-badge text-whitesmoke"><span class="fa fa-user-circle"></span></h1>
                </div>
                    <h3 class="text-whitesmoke">Sign In Template</h3>
                    <p class="text-whitesmoke">Sign In</p>
                <div class="container-content">
                    <form class="margin-t">
                        <div class="form-group">
                            <input id="tbUser" type="text" class="form-control" placeholder="Username" required="" runat="server">
                        </div>
                        <div class="form-group">
                            <input id="tbPass" type="password" class="form-control" placeholder="*****" required="" runat="server">
                        </div>
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="form-button button-l margin-b" OnClick="Consultar_Click" TabIndex="5" />
        
                        <a class="text-darkyellow" href="#"><small>Forgot your password?</small></a>
                        <p class="text-whitesmoke text-center"><small>Do not have an account?</small></p>
                        <a class="text-darkyellow" href="#"><small>Sign Up</small></a>
                    </form>
                    <p class="margin-t text-whitesmoke"><small> Your Name &copy; 2018</small> </p>
                </div>
            </div>
    </body>

</asp:Content>
