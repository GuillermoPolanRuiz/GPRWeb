<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="GPRWeb.UI.Inicio.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f0f0f0;
        }
        header {
            background-color: #3498db;
            color: #fff;
            padding: 20px 0;
            text-align: center;
            margin-bottom: 20px;
        }
        nav {
            background-color: #2980b9;
            padding: 10px 0;
            text-align: center;
            margin-bottom: 20px;
        }
        nav a {
            color: #fff;
            text-decoration: none;
            margin: 0 10px;
        }
        nav a:hover {
            text-decoration: underline;
        }
        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        h1 {
            color: #3498db;
            margin-top: 0;
        }
        .movie {
            border-bottom: 1px solid #ccc;
            padding-bottom: 20px;
            margin-bottom: 20px;
        }
        .movie h3 {
            margin-top: 0;
            color: #2980b9;
        }
        .movie p {
            margin: 5px 0;
            color: #555;
        }
    </style>
</head>
<body>
    <header>
        <h1>¡Bienvenido a nuestra página de películas!</h1>
    </header>
    <nav>
        <a href="#">Inicio</a>
        <a href="#">Películas</a>
    </nav>
    <form id="form1" runat="server">
        <div>
            <h1>Lista de Películas</h1>
            <asp:Repeater ID="rMovies" runat="server">
                <ItemTemplate>
                    <div>
                        <h3><%# Eval("Title") %></h3>
                        <%--<p>Año: <strong><%# Eval("Año") %></strong></p>--%>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
