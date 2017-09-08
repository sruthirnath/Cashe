<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebGrid.aspx.cs" Inherits="CashingDemo.WebGrid" %>
<%@ OutputCache Duration="60" VaryByParam="DropDownList1" Location="Server" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Select Designation: 
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Text="All" Value="All" Selected="True"></asp:ListItem> 
            <asp:ListItem Text="developer" Value="developer"></asp:ListItem> 
            <asp:ListItem Text="tester" Value="testing"></asp:ListItem> 
            <asp:ListItem Text="network engineer" Value="network engineer"></asp:ListItem> 
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView><br />
        Server Time: <asp:Label ID="Label1" runat="server"></asp:Label><br />
        Client Time:<script type="text/javascript">
            document.write(Date());
        </script>
    </div>
    </form>
</body>
</html>