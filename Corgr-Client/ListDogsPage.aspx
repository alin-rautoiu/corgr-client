<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDogsPage.aspx.cs" Inherits="Corgr_Client.ListDogsPage" %>

<asp:Content ID="ListsContent" ContentPlaceHolderID="SecondPageContent" runat="server">

    <style type="text/css">
        .inlineBlock {
            display: inline-block;
        }
    </style>

    <asp:Panel ID="LikedDogs" CssClass="inlineBlock" runat="server">
        <asp:Label runat="server" >Favorite Dogs</asp:Label>
        <ul>

        <asp:Repeater runat="server" ID="RepeaterLikedDogs" OnItemDataBound="Dogs_OnItemDataBound">
            
            <ItemTemplate> 
                <li><%# DataBinder.Eval(Container.DataItem, "Name") %></li>
                
                <li><%# DataBinder.Eval(Container.DataItem, "Face") %></li>
                
              <asp:Repeater runat="server" ID="RepeaterLikesList">
                    <ItemTemplate> 
                    
                            <li><%# Container.DataItem.ToString() %></li>
                       
                    </ItemTemplate>
                </asp:Repeater>
             
            </ItemTemplate>
        </asp:Repeater>
        </ul>
    </asp:Panel>


    <asp:Panel ID="DislikedDogs" CssClass="inlineBlock" runat="server">
        <asp:Label runat="server">Unliked Dogs</asp:Label>
        <ul>
            <asp:Repeater runat="server" ID="RepeaterUnlikedDogs">
                <ItemTemplate>
                    <li><%# DataBinder.Eval(Container.DataItem, "Name") %></li>
                    <li><%# DataBinder.Eval(Container.DataItem, "Face") %></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </asp:Panel>







</asp:Content>
