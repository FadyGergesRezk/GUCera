﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewProfile.aspx.cs" Inherits="GUCera.viewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styleProfile.css" rel="stylesheet" />
</head>
<body>
        <img src="Stock/GUCERA.png"  alt="Alternate Text" class="user" />
        <asp:Label Text="GU" CssClass="lblgucera1" ForeColor="Black" runat="server" />
        <asp:Label Text="CE" CssClass="lblgucera2" ForeColor="#cc0000" runat="server" />
        <asp:Label Text="RA" CssClass="lblgucera3" ForeColor="#ff9900" runat="server" />
        <div class="profilebox">
            <img src="Stock/profile.png"  alt="Alternate Text" class="profile" />
            <h2>YOUR PROFILE</h2>
        <form id="form1" runat="server">
            <br />
            <asp:Label Text="First name:" CssClass="lblfname1" runat="server" />
            <asp:Label ID="fname" CssClass="lblfname2" runat="server" /><br /><br />

            <asp:Label Text="Last name:" CssClass="lbllname1" runat="server" />
            <asp:Label ID="lname" CssClass="lbllname2" runat="server" /><br /><br />

            <asp:Label Text="Password:" CssClass="lblpass1" runat="server" />
            <asp:Label ID="pass" CssClass="lblpass2" runat="server" /><br /><br />

            <asp:Label Text="Gender:" CssClass="lblgender1" runat="server" />
            <asp:Label ID="lblgender" CssClass="lblgender2" runat="server" /><br /><br />

            <asp:Label Text="E-mail:" CssClass="lblmail1" runat="server" />
            <asp:Label ID="mail" CssClass="lblmail2" runat="server" /><br /><br />

            <asp:Label Text="Address:" CssClass="lbladdrress1" runat="server" />
            <asp:Label ID="address" CssClass="lbladdress2" runat="server" /><br /><br />

            <asp:Button ID="back" runat="server" Text="Back" CssClass="btnback" OnClick="backbtn" />
            </form>
        </div>
    
</body>
</html>
