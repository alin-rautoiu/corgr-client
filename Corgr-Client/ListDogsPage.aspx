<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDogsPage.aspx.cs" Inherits="Corgr_Client.ListDogsPage" %>

<asp:Content ID="ListsContent" ContentPlaceHolderID="SecondPageContent" runat="server">
    
    <style type="text/css">
       .inlineBlock { display: inline-block; }
    </style>

    <asp:Panel ID="LikedDogs" CssClass="inlineBlock" runat="server">
        <asp:Label runat="server">Favorite Dogs</asp:Label>
        <ul>       
        <asp:Repeater runat="server" ID="RepeaterLikedDogs">
            <ItemTemplate> 
                <li><%# DataBinder.Eval(Container.DataItem, "Name") %></li>
                <li><%# DataBinder.Eval(Container.DataItem, "Face") %></li>
                <%--<li><asp:Repeater runat="server" ID="RepeaterLikesList">
                    <ItemTemplate> 
                        <div class="center" style="margin-right: auto;  display: block; text-align: center;">    
                        <li><%# Container.DataItem.ToString() %></li>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                </li>--%>
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
