<%@ Page Title="" Language="VB" MasterPageFile="~/Master.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
        Hier geht es zur Anmeldung</h2>
    <p>
        <asp:Button ID="cmdAnmeldung" runat="server" Text="Anmeldung" />
    </p>
    <div class="formular">
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="DBConn" DefaultMode="Insert" Height="50px" Visible="False" Width="509px">
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Vorname" HeaderText="Vorname" SortExpression="Vorname" />
                <asp:BoundField DataField="Nachname" HeaderText="Nachname" SortExpression="Nachname" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:CheckBoxField DataField="Mitglied" HeaderText="Mitglied" SortExpression="Mitglied" />
                <asp:BoundField DataField="Bemerkung" HeaderText="Bemerkung" SortExpression="Bemerkung" />
                <asp:CommandField InsertText="Anmelden" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:Label ID="lblWarnung" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:AccessDataSource ID="DBConn" runat="server" DataFile="~/veranstaltung.mdb" DeleteCommand="DELETE FROM [Teilnehmer] WHERE [ID] = ?" InsertCommand="INSERT INTO [Teilnehmer] ([Vorname], [Nachname], [Email], [Mitglied], [Bemerkung]) VALUES (?, ?, ?, ?, ?)" SelectCommand="SELECT * FROM [Teilnehmer]" UpdateCommand="UPDATE [Teilnehmer] SET [Vorname] = ?, [Nachname] = ?, [Email] = ?, [Mitglied] = ?, [Bemerkung] = ? WHERE [ID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
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
</div>
</asp:Content>

