<%@ Page Title="" Language="VB" MasterPageFile="~/Master.master" AutoEventWireup="false" CodeFile="admin.aspx.vb" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Passwort:
    <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
    
    <asp:Button ID="cmdOk" runat="server" Text="OK" />
    
    <br />
    <asp:GridView ID="GridView1" runat="server" Visible="False" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="GridConn" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Vorname" HeaderText="Vorname" SortExpression="Vorname" />
            <asp:BoundField DataField="Nachname" HeaderText="Nachname" SortExpression="Nachname" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:CheckBoxField DataField="Mitglied" HeaderText="Mitglied" SortExpression="Mitglied" />
            <asp:BoundField DataField="Bemerkung" HeaderText="Bemerkung" SortExpression="Bemerkung" />
        </Columns>
    </asp:GridView>
    
<asp:AccessDataSource ID="GridConn" runat="server" DataFile="~/veranstaltung.mdb" DeleteCommand="DELETE FROM [Teilnehmer] WHERE [ID] = ?" InsertCommand="INSERT INTO [Teilnehmer] ([ID], [Vorname], [Nachname], [Email], [Mitglied], [Bemerkung]) VALUES (?, ?, ?, ?, ?, ?)" SelectCommand="SELECT * FROM [Teilnehmer] ORDER BY [Nachname]" UpdateCommand="UPDATE [Teilnehmer] SET [Vorname] = ?, [Nachname] = ?, [Email] = ?, [Mitglied] = ?, [Bemerkung] = ? WHERE [ID] = ?">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ID" Type="Int32" />
        <asp:Parameter Name="Vorname" Type="String" />
        <asp:Parameter Name="Nachname" Type="String" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Mitglied" Type="Boolean" />
        <asp:Parameter Name="Bemerkung" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Vorname" Type="String" />
        <asp:Parameter Name="Nachname" Type="String" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Mitglied" Type="Boolean" />
        <asp:Parameter Name="Bemerkung" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </UpdateParameters>
</asp:AccessDataSource>
<asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="DetConn" Visible="False">
    <Fields>
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="Vorname" HeaderText="Vorname" SortExpression="Vorname" />
        <asp:BoundField DataField="Nachname" HeaderText="Nachname" SortExpression="Nachname" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:CheckBoxField DataField="Mitglied" HeaderText="Mitglied" SortExpression="Mitglied" />
        <asp:BoundField DataField="Bemerkung" HeaderText="Bemerkung" SortExpression="Bemerkung" />
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
    </Fields>
</asp:DetailsView>
    <asp:Label ID="lblWarnung" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    <asp:AccessDataSource ID="DetConn" runat="server" DataFile="~/veranstaltung.mdb" DeleteCommand="DELETE FROM [Teilnehmer] WHERE [ID] = ?" InsertCommand="INSERT INTO [Teilnehmer] ([ID], [Vorname], [Nachname], [Email], [Mitglied], [Bemerkung]) VALUES (?, ?, ?, ?, ?, ?)" SelectCommand="SELECT * FROM [Teilnehmer] WHERE [ID] =  ?" UpdateCommand="UPDATE [Teilnehmer] SET [Vorname] = ?, [Nachname] = ?, [Email] = ?, [Mitglied] = ?, [Bemerkung] = ? WHERE [ID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="Vorname" Type="String" />
            <asp:Parameter Name="Nachname" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Mitglied" Type="Boolean" />
            <asp:Parameter Name="Bemerkung" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="?" PropertyName="SelectedValue" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Vorname" Type="String" />
            <asp:Parameter Name="Nachname" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Mitglied" Type="Boolean" />
            <asp:Parameter Name="Bemerkung" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
    
</asp:Content>

