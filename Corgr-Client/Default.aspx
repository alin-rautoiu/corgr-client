<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeBehind="Default.aspx.cs" Inherits="Corgr_Client._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="navbar navbar-inverse navbar-fixed-top">
         <div class="container">
             <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                   <span class="icon-bar"></span>
                </button>
             </div>
             <div class="navbar-collapse collapse">
                  <ul class="nav navbar-nav">
                     <li><a runat="server" href="~/listDogs">List Dogs</a></li>
                  </ul>
             </div>
            </div>
    </div>

    <h1 style="text-align:center">Dogs Collection</h1>
    <br />
    <br />
    <style>        
        .displayed{
            display: block;
            margin-left: auto;
            margin-right: auto;
            border: solid;
            padding: 10px;
            width: 300px;
            height: 220px
        }
        .center {
            margin: auto;
            width: 60%;
            padding: 10px;
        }
    </style>
    <asp:Image runat="server" ID="DogImage" CssClass="displayed"/>
    <br />
    <div style="margin-left: auto; margin-right: auto; display: block; text-align: center;">
        <asp:Label runat="server" ID="DogName"></asp:Label>
   
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
        <asp:Button  ID ="NextButton" runat="server" Text="Next" BackColor="Blue" OnClick="NextButton_Click"/> 
     </div>

</asp:Content>

<asp:Content ID="BodyContent2" ContentPlaceHolderID="ContentMessage" runat="server">
    <asp:Label runat="server" ID="NoDogs"></asp:Label>
</asp:Content>

