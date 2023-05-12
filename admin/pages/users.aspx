<%@ Page Title="" Language="C#" MasterPageFile="~/admin/pages/AdminMasterPage.master" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="admin_pages_users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="surname" HeaderText="surname" SortExpression="surname" />
            <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
            <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
            <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
            <asp:BoundField DataField="pincode" HeaderText="pincode" SortExpression="pincode" />
            <asp:BoundField DataField="birthdate" HeaderText="birthdate" SortExpression="birthdate" />
            <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
            <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
            <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MailServerDb.mdf;Integrated Security=True;Connect Timeout=30" DeleteCommand="DELETE FROM [Register] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Register] ([name], [surname], [mobile], [address], [city], [pincode], [birthdate], [gender], [username], [password], [image]) VALUES (@name, @surname, @mobile, @address, @city, @pincode, @birthdate, @gender, @username, @password, @image)" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Register]" UpdateCommand="UPDATE [Register] SET [name] = @name, [surname] = @surname, [mobile] = @mobile, [address] = @address, [city] = @city, [pincode] = @pincode, [birthdate] = @birthdate, [gender] = @gender, [username] = @username, [password] = @password, [image] = @image WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="surname" Type="String" />
            <asp:Parameter Name="mobile" Type="String" />
            <asp:Parameter Name="address" Type="String" />
            <asp:Parameter Name="city" Type="String" />
            <asp:Parameter Name="pincode" Type="String" />
            <asp:Parameter Name="birthdate" Type="DateTime" />
            <asp:Parameter Name="gender" Type="String" />
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="image" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="surname" Type="String" />
            <asp:Parameter Name="mobile" Type="String" />
            <asp:Parameter Name="address" Type="String" />
            <asp:Parameter Name="city" Type="String" />
            <asp:Parameter Name="pincode" Type="String" />
            <asp:Parameter Name="birthdate" Type="DateTime" />
            <asp:Parameter Name="gender" Type="String" />
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="image" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

