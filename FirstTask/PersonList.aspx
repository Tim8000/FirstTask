<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonList.aspx.cs" Inherits="FirstTask.PersonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" href="~/Content/mydatagrid.css" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="True" AutoGenerateSelectButton="True" DataKeyNames="Id" OnSelectedIndexChanged="GridView2_OnSelectedIndexChanged" CssClass="mydatagrid" PagerStyle-CssClass="pager"  HeaderStyle-CssClass="header" RowStyle-CssClass="rows" >
        </asp:GridView>
    </form>
</body>
</html>
