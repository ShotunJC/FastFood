<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FastFoods._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div>
            <table style="width:100%;">
                <tr>
                    <td style="width: 437px">Order</td>
                    <td style="width: 392px">Items</td>
                    <td>Delivery</td>
                </tr>
                <tr>
                    <td style="width: 437px">Order Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="OrderNum" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 392px">Order Number:&nbsp;
                        <asp:TextBox ID="iOrderNum" runat="server"></asp:TextBox>
                    </td>
                    <td>Delivery Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="DeliveryNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 437px">Customer Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:TextBox ID="CustName" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 392px">Line Item:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="LineItem" runat="server"></asp:TextBox>
                    </td>
                    <td>Driver Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="DriverName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 437px">Customer Address:&nbsp; 
                        <asp:TextBox ID="CustAddress" runat="server" Width="241px"></asp:TextBox>
                    </td>
                    <td style="width: 392px">Description:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="Description" runat="server"></asp:TextBox>
                    </td>
                    <td>Driver Contact Number:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="DriverContact" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 437px">Contact Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="ContactNum" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 392px">Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="Price" runat="server"></asp:TextBox>
                    </td>
                    <td>Order Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="dOrderNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 437px">Total Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TotalPrice" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 392px">QTY:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="qty" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 437px">&nbsp;</td>
                    <td style="width: 392px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 437px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Insert" />
                    </td>
                    <td style="width: 392px">
                        <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 437px">
                        <asp:Button ID="clear" runat="server" Text="Clear" OnClick="clear_Click" />
                    </td>
                    <td style="width: 392px">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </div>

    </asp:Content>
