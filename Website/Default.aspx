<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-size: medium;
        }
        .auto-style2
        {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1" style="height: 79px">
    
        <h1 style="text-align: center">Rechen-Trainer</h1>
        </div>
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
              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtErg" ErrorMessage="Bitte nur Zahlen!" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            </div>
          <div>
 
              <asp:Button ID="cmdNeu" runat="server" style="height: 26px" Text="Neue Zahl" />
 
            </div>

           <div>
 
      
               <asp:Label ID="lbRi" runat="server" Text="Richtig: 0"></asp:Label>
&nbsp;&nbsp;
               <asp:Label ID="lbFa" runat="server" Text="Falsch: 0"></asp:Label>
 
      
            </div>
    </form>
</body>
</html>
