<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sample.MVP.Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: ContentTitle %></h1>
            </hgroup>
            <section>
                <asp:Repeater runat="server" ID="clientsRepeater">
                   <HeaderTemplate>
                        <table>
                        <thead>
                            <tr>
                                <th>Client Name</th>
                                <th>Contact Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            
                        
                   </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ClientName") %></td>
                            <td><%#Eval("ContactName") %></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    </table>
                    </FooterTemplate>
                </asp:Repeater>
            </section>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
</asp:Content>
