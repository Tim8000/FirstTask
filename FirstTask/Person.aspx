<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbTest.aspx.cs" Inherits="FirstTask.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="SELECT * FROM [Contacts]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                <asp:BoundField DataField="Personid" HeaderText="Personid" SortExpression="Personid" />
            </Columns>
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="True" AutoGenerateSelectButton="True" DataKeyNames="Id" OnSelectedIndexChanged="GridView2_OnSelectedIndexChanged">
        </asp:GridView>
        <p>
            <asp:Label ID="ResultLabel" runat="server" Text="Label">ууцй</asp:Label>
        </p>
    </form>
</body>
</html>
