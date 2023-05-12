<%@ Page Title="" Language="C#" MasterPageFile="~/admin/pages/AdminMasterPage.master" AutoEventWireup="true" CodeFile="mails.aspx.cs" Inherits="admin_pages_mails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="fromid" HeaderText="fromid" SortExpression="fromid" />
            <asp:BoundField DataField="toid" HeaderText="toid" SortExpression="toid" />
            <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
            <asp:BoundField DataField="detail" HeaderText="detail" SortExpression="detail" />
            <asp:BoundField DataField="mdate" HeaderText="mdate" SortExpression="mdate" />
            <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            <asp:BoundField DataField="attach" HeaderText="attach" SortExpression="attach" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MailServerDb.mdf;Integrated Security=True;Connect Timeout=30" DeleteCommand="DELETE FROM [mails] WHERE [Id] = @Id" InsertCommand="INSERT INTO [mails] ([fromid], [toid], [subject], [detail], [mdate], [status], [attach]) VALUES (@fromid, @toid, @subject, @detail, @mdate, @status, @attach)" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [mails]" UpdateCommand="UPDATE [mails] SET [fromid] = @fromid, [toid] = @toid, [subject] = @subject, [detail] = @detail, [mdate] = @mdate, [status] = @status, [attach] = @attach WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="fromid" Type="Int32" />
            <asp:Parameter Name="toid" Type="Int32" />
            <asp:Parameter Name="subject" Type="String" />
            <asp:Parameter Name="detail" Type="String" />
            <asp:Parameter Name="mdate" Type="DateTime" />
            <asp:Parameter Name="status" Type="String" />
            <asp:Parameter Name="attach" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="fromid" Type="Int32" />
            <asp:Parameter Name="toid" Type="Int32" />
            <asp:Parameter Name="subject" Type="String" />
            <asp:Parameter Name="detail" Type="String" />
            <asp:Parameter Name="mdate" Type="DateTime" />
            <asp:Parameter Name="status" Type="String" />
            <asp:Parameter Name="attach" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

