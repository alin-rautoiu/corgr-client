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
       .center {
            margin: auto;
            width: 60%;
            padding: 10px;
        }
    </style>
    <asp:Image runat="server" ID="DogImage" CssClass="displayed" />
    <br />
    <div style="margin-left: auto; margin-right: auto; display: block; text-align: center;">
        <asp:Label runat="server" ID="DogName" Text="Aria Labradino"></asp:Label>
   
    <br />
    <div class="center" style="margin-left: auto; margin-right: auto; display: block; text-align: center;">    
    <ul>       
    <asp:Repeater runat="server" ID="RepeaterLikes">
        <ItemTemplate> 
            <div class="center" style="margin-right: auto;  display: block; text-align: center;">    
            <li><%# Container.DataItem.ToString() %></li>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    </ul>
    </div>
   
    <br />
    <br />
     
        
        <asp:Button  ID ="LikeButton" runat="server" Text="Like" BackColor="Green" OnClick="LikeButton_Click"/>  
        <asp:Button  ID="DislikeButton" runat="server" Text="Dislike" BackColor="Red" OnClick="DislikeButton_Click"/>
     </div>

</asp:Content>
