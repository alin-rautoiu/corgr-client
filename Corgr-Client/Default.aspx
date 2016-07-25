<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeBehind="Default.aspx.cs" Inherits="Corgr_Client._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center">Dogs Collection</h1>
    <br />
    <br />
    <style>
        img.displayed{
            display: block;
            margin-left: auto;
            margin-right: auto;
            width: 300px;
            height: 220px
        }
    </style>
    <asp:Image runat="server" ID="DogImage" CssClass="displayed" ImageUrl="http://www.petpact.com/wp-content/uploads/2014/12/happy-labrador.jpg" />
    <br />
    <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Label runat="server" ID="DogName" Text="Aria Labradino"></asp:Label>
   
    <br />
    
    <ul>       
    <asp:Repeater runat="server" ID="RepeaterLikes">
        <ItemTemplate>     
            <li><%# Container.DataItem.ToString() %></li>
        </ItemTemplate>
    </asp:Repeater>
    </ul>
   
    <br />
    <br />
     
    
        <asp:Button ID="Like" runat="server" Text="Like" BackColor="Green" />  
        <asp:Button ID="Dislike" runat="server" Text="Dislike" BackColor="Red" />
     </div>

</asp:Content>
