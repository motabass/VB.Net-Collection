<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="kalorien.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            height: 20px;
        }
    .auto-style5 {
        width: 336px;
    }
    .auto-style6 {
        height: 20px;
        width: 336px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Kalorien-Rechner</h1>
    <table>
        <tr>
            <td class="auto-style5"><strong>Geschlecht</strong></td>
            <td>
                <asp:DropDownList ID="ddGeschlecht" runat="server">
                    <asp:ListItem>weiblich</asp:ListItem>
                    <asp:ListItem>männnlich</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Gewicht</strong>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGewicht" ErrorMessage="Fehlt!" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtGewicht" runat="server"></asp:TextBox>
&nbsp;kg</td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Alter</strong>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAlter" ErrorMessage="Fehlt!" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtAlter" runat="server"></asp:TextBox>
&nbsp;Jahre</td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Körpergröße</strong>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGroesse" ErrorMessage="Fehlt!" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtGroesse" runat="server"></asp:TextBox>
&nbsp;cm</td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Aktivitäten</strong>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="rdlAktiv" ErrorMessage="Fehlt!" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RadioButtonList ID="rdlAktiv" runat="server">
                    <asp:ListItem>keine Bewegung</asp:ListItem>
                    <asp:ListItem>ausschließlich sitzend/liegend</asp:ListItem>
                    <asp:ListItem>sitzend, kaum körperliche Aktivität</asp:ListItem>
                    <asp:ListItem>sitzend, zeitweilig gehend/stehend</asp:ListItem>
                    <asp:ListItem>überwiegend gehend/stehend</asp:ListItem>
                    <asp:ListItem>körperlich anstrengende Arbeit </asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="cmdBerechne" runat="server" style="text-align: center; width: 100%;" Text="Kalorienverbrauch berechnen" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6"><strong>Ihr Kalorienverbrauch</strong></td>
            <td class="auto-style4">
                <asp:Label ID="lblKcal" runat="server"></asp:Label>
&nbsp;kcal pro Tag</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="cmdReset" runat="server" style="text-align: center; width: 100%;" Text="Zurücksetzen" />
            </td>
        </tr>
    </table>

</asp:Content>

