<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="administration.aspx.vb" Inherits="administration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>News-Einträge bearbeiten</h1>
    <p>Kennwort:
        <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;<asp:Button ID="cmdOK" runat="server" Text="OK" />
    </p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="AccessDataSource1" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Visible="False">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="ID" HeaderText="Nummer" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
    <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="details" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="ID" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="background-color: #99FF99" Visible="False">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
            <asp:BoundField DataField="Eintrag" HeaderText="Eintrag" SortExpression="Eintrag" />
            <asp:TemplateField HeaderText="Anzeigen_bis" SortExpression="Anzeigen_bis">
                <EditItemTemplate>
                    <asp:Calendar ID="Calendar1" runat="server" SelectedDate='<%# Bind("Anzeigen_bis") %>'></asp:Calendar>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:Calendar ID="Calendar2" runat="server" SelectedDate='<%# Bind("Anzeigen_bis") %>'></asp:Calendar>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" BackColor="#FF9900" Text='<%# Bind("Anzeigen_bis") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
    <asp:Label ID="lblWarnung" runat="server"></asp:Label>
    <asp:AccessDataSource ID="details" runat="server" DataFile="~/App_Data/webDB.mdb" DeleteCommand="DELETE FROM [News] WHERE [ID] = ?" InsertCommand="INSERT INTO  [News] ( [Titel], [Eintrag], [Anzeigen_bis]) VALUES (?, ?, ?)" SelectCommand="SELECT * FROM [News] WHERE ([ID] = ?)" UpdateCommand="UPDATE [News] SET [Titel] = ?, [Eintrag] = ?, [Anzeigen_bis] = ? WHERE [ID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Titel" Type="String" />
            <asp:Parameter Name="Eintrag" Type="String" />
            <asp:Parameter Name="Anzeigen_bis" Type="DateTime" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="ID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Titel" Type="String" />
            <asp:Parameter Name="Eintrag" Type="String" />
            <asp:Parameter Name="Anzeigen_bis" Type="DateTime" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/webDB.mdb" SelectCommand="SELECT [ID], [Titel] FROM [News]"></asp:AccessDataSource>
</asp:Content>

