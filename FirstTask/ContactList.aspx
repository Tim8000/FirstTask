<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactList.aspx.cs" Inherits="FirstTask.ContactList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" href="~/Content/mydatagrid.css" type="text/css" />
    <title></title>
</head>
<body>
<h2 id="pageHeader" runat="server"></h2>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="CListGridView" runat="server" AutoGenerateColumns="False" CssClass="mydatagrid" PagerStyle-CssClass="pager"  HeaderStyle-CssClass="header" RowStyle-CssClass="rows" >
            <Columns>
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName"/>
                <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
