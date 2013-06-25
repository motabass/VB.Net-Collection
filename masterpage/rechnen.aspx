<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="rechnen.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
        <h1 style="text-align: center">Rechen-Trainer</h1>
        
          <div>
              <asp:Label ID="lbZahl1" runat="server"></asp:Label>
</div>
          <div>
              <span class="auto-style2">+</span><asp:Label ID="lbZahl2" runat="server" CssClass="auto-style2"></asp:Label>
   </div>
        <div>
  
              =<asp:TextBox ID="txtErg" runat="server" Width="65px"></asp:TextBox>
              <asp:Button ID="cmdBerechnen" runat="server" Text="Berechnen" />
              <asp:Label ID="lbRichtig" runat="server"></asp:Label>
              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtErg" ErrorMessage="Bitte nur Zahlen!" ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Display="Dynamic"></asp:CompareValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtErg" Display="Dynamic" ErrorMessage="Sie müssen ein Ergebnis eingeben!" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          <div>
 
              <asp:Button ID="cmdNeu" runat="server" style="height: 26px" Text="Neue Zahl" />
 
            </div>

           <div>
 
      
               <asp:Label ID="lbRi" runat="server" Text="Richtig: 0"></asp:Label>
&nbsp;&nbsp;
               <asp:Label ID="lbFa" runat="server" Text="Falsch: 0"></asp:Label>
 
      
            </div>
</asp:Content>

