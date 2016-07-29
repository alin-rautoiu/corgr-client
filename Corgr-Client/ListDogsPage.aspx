<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDogsPage.aspx.cs" Inherits="Corgr_Client.ListDogsPage" %>

<asp:Content ID="ListsContent" ContentPlaceHolderID="SecondPageContent" runat="server">

    <style type="text/css">
        .inlineBlock {
            display: inline-block;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                <asp:Panel ID="LikedDogs" CssClass="inlineBlock" runat="server">
                    <asp:Label runat="server" Font-Bold="true" Font-Underline="true">Favorite Dogs</asp:Label>
                    <br />
                    <br />
                    <ul>
                        <asp:Repeater runat="server" ID="RepeaterLikedDogs" OnItemDataBound="DogsLikes_ItemDataBound">
                            <ItemTemplate>
                                <br />
                                <br />
                                <li class=""><%# DataBinder.Eval(Container.DataItem, "Name") %></li>
                                <asp:Image runat="server" ID="DogImage" CssClass="displayed" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Face") %>' />
                                <div style="color: darkgrey">
                                    <li>Preferences</li>
                                </div>
                                <div class="center">
                                    <ul>
                                        <asp:Repeater runat="server" ID="RepeaterLikesList">
                                            <ItemTemplate>
                                                <li><%# Container.DataItem.ToString() %></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </asp:Panel>
            </div>
            <div class="col-sm-6">
                <asp:Panel ID="DislikedDogs" CssClass="inlineBlock" runat="server">
                    <asp:Label runat="server" Font-Bold="true" Font-Underline="true">Unliked Dogs</asp:Label>
                    <br />
                    <br />
                    <ul>
                        <asp:Repeater runat="server" ID="RepeaterUnlikedDogs" OnItemDataBound="DogsUnlikes_ItemDataBound">
                            <ItemTemplate>
                                <br />
                                <br />
                                <li><%# DataBinder.Eval(Container.DataItem, "Name") %></li>
                                <asp:Image runat="server" ID="DogImage" CssClass="displayed" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Face") %>' />
                                <div style="color: darkgrey">
                                    <li>Preferences</li>
                                </div>
                                <div class="center">
                                    <ul>
                                        <asp:Repeater runat="server" ID="RepeaterLikesList">
                                            <ItemTemplate>
                                                <li><%# Container.DataItem.ToString() %></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </asp:Panel>
            </div>
        </div>
    </div>







</asp:Content>
