<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Certificates.aspx.cs" Inherits="GUCera.View_Certificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styleCertificate.css" rel="stylesheet" />
</head>
<body>
    <img src="Stock/GUCERA.png"  alt="Alternate Text" class="user" />
        <asp:Label Text="GU" CssClass="lblgucera1" ForeColor="Black" runat="server" />
        <asp:Label Text="CE" CssClass="lblgucera2" ForeColor="#cc0000" runat="server" />
        <asp:Label Text="RA" CssClass="lblgucera3" ForeColor="#ff9900" runat="server" />

    <div class="certificatebox" id="assginmentbox" runat="server" >

         <img id="img" src ="Stock/certificate.png"  alt="Alternate Text" class="certificate" runat="server" />


         <form id="form1" runat="server">
                
               <asp:Label   ForeColor="Black" CssClass="lblwelcome"   Text="VIEW CERTIFICATES" Font-Size="30px" runat="server" />
                <br />
                <br />
                <div id="tobehidden" runat="server">
                <asp:Label Text="Course Id" CssClass="lblcid"  runat="server" />
                <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1" runat="server" 
                forecolor="Red" Errormessage="*" ControlToValidate="courseID">
                </asp:RequiredFieldValidator>
                <asp:TextBox ID="courseID" placeholder="Enter the course id" runat="server" CssClass="txtcid"  />
                <asp:Label  ID="msg" ForeColor="#009933" CssClass="lblmsg" runat="server" />
                <br />
                <br/>
                <asp:Button ID="view" runat="server" Text="View" CssClass="btnview" OnClick="Button1_Click" /><br /><br />
                <asp:Button ID="back" runat="server" Text="Back" CssClass="btnback" OnClick="Button2_Click" CausesValidation="false" />
                </div>
                   <br />
                   <br />
                   <br />
                <br />
             


</form>
    </div>

</body>
</html>