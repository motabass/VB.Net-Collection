<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="verschl.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Verschlüssler</h1>
     <div>
    
                Passwort <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
    
                <asp:Button ID="cmdVersch" runat="server" style="margin-bottom: 0px" Text="Verschlüsseln" />
                <asp:Button ID="cmdEntsch" runat="server" Text="Entschlüsseln" />
    
    </div>
      
    <div>
    
        <asp:TextBox ID="txtText" runat="server" Height="272px" TextMode="MultiLine" Width="842px"></asp:TextBox>
    
    </div>
          <div>

              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPW" Display="Dynamic" ErrorMessage="Bitte geben Sie ein Passwort ein!"></asp:RequiredFieldValidator>
              <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtText" Display="Dynamic" ErrorMessage="Es wurde kein Text eingegeben!"></asp:RequiredFieldValidator>

        </div>
</asp:Content>

