<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="s4_l4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <p class="lead">Введите данные о товаре</p>
        <p>
            <asp:Label runat="server" Text="Название" ID="Label0" Width="100px"></asp:Label>
            <asp:TextBox runat="server" Width="300px" ID="TextBox1"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Введите название товара." ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </p>
        <p>
            <asp:Label runat="server" Text="Артикул" ID="Label1" Width="100px"></asp:Label>
            <asp:TextBox runat="server" Width="300px" ID="TextBox2"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Введите артикул." ControlToValidate="TextBox2"></asp:RequiredFieldValidator><br />
            <asp:RangeValidator runat="server" ErrorMessage="Артикул должен быть натуральным числом." ControlToValidate="TextBox2" MaximumValue="999999" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </p>
        <p>
            <asp:Label runat="server" Text="Цена" ID="Label2" Width="100px"></asp:Label>
            <asp:TextBox runat="server" Width="300px" ID="TextBox3"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Введите стоимость товара." ControlToValidate="TextBox3"></asp:RequiredFieldValidator><br />
            <asp:RangeValidator runat="server" ErrorMessage="Стоимость — это число, больше 0,01" ControlToValidate="TextBox3" MaximumValue="999999" MinimumValue="0,01" type="Double"></asp:RangeValidator></p>
        <p>
            <asp:Label runat="server" Text="Дата изготовления" ID="Label6" Width="200px"></asp:Label>
            <asp:Calendar runat="server" Width="200px" ID="Calendar1"></asp:Calendar>
        </p>
        <p>
            <asp:Label runat="server" Text="Срок реализации" ID="Label7" Width="200px"></asp:Label>
            <asp:Calendar runat="server" Width="200px" ID="Calendar2"></asp:Calendar><br />
        </p>

        <p>
            <asp:Button ID="Button1" runat="server" Text="Сохранить" Width="600px" OnClick="Button1_click" /></p>
    </div>

    <div>
        <p class="lead">Список товаров</p>
        <asp:ListBox ID="ListBox1" runat="server" Width="600px" Height="685px" Rows="20"></asp:ListBox>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Просмотр" OnClick="Button2_click" />
            <asp:Button ID="Button3" runat="server" Text="Редактировать" OnClick="Button3_click" />
        <asp:Button ID="Button4" runat="server" Text="Удалить" /></p>
    </div>

</asp:Content>
