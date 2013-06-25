<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
    
                Passwort <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
    
                <asp:Button ID="cmdVersch" runat="server" style="margin-bottom: 0px" Text="Verschlüsseln" />
                <asp:Button ID="cmdEntsch" runat="server" Text="Entschlüsseln" />
    
    </div>
      
    <div>
    
        <asp:TextBox ID="txtText" runat="server" Height="241px" TextMode="MultiLine" Width="453px"></asp:TextBox>
    
    </div>
          <div>

            <asp:Label ID="lblStatus" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
