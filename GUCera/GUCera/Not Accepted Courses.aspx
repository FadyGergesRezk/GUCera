﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Not Accepted Courses.aspx.cs" Inherits="GUCera.Not_Accepted_Courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
 	 <img src="Stock/GUCERA.png"  alt="Alternate Text" class="user" />
        <asp:Label Text="GU" CssClass="lblgucera1" runat="server" />
        <asp:Label Text="CE" CssClass="lblgucera2" runat="server" />
        <asp:Label Text="RA" CssClass="lblgucera3" runat="server" />

        

    <form id="form1" runat="server">
        <div id="tobehidden2" runat="server" class="box2">
         <asp:Button  runat="server" OnClick="HomePage"  Text="Home Page" CssClass="button" />
        <h2>Table Assignments of StudentsCourses</h2>
        <asp:GridView ID="GridView1" runat="server" width="600px" CssClass="grid"  CellPadding="4" ForeColor="#333333" GridLines="None" onrowdatabound="GridView1_RowDataBound">
                <AlternatingRowStyle BackColor="White"  ForeColor="#284775"></AlternatingRowStyle>

                   <EditRowStyle BackColor="#999999"></EditRowStyle>

                   <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

                   <HeaderStyle BackColor="#000000" Font-Bold="True" ForeColor="White"></HeaderStyle>

                   <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

                   <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

                   <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                   <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

                   <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

                   <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

                   <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
               </asp:GridView>
            </div>
     
    </form>

</body>
</html>
