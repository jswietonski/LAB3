<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LAB3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">

.container {
  width: 80%;
  height: 200px;
  margin: auto;
  padding: 10px;
}

.one {
  width: 30%;
  height: 1000px;
  
  float: left;
}

.two {
  margin-left: 15%;
  position: relative;
  height: 500px;


}
.regform
{
    width: 200px;
    height: 150px;
    background-color: lightseagreen;
    margin-left: auto;
    margin-right: auto;
}
.JSlabel
{
    width: 50px;
    height: 20px;
    border-color: brown

}
.red
{
    color:red;
}
.naglowek
{
    color:blue;
}
.ramka
{
    border-color:blue;
    border-style: solid;
    border-width: 4px;
}
</style>
</head>
<body style="height: 1000px">
    <form id="form1" runat="server" >
        <asp:Panel ID="JSPanel2" runat="server" Visible="true">
            <div class ="regform">
                <b>Podaj imie i nazwisko</b><br />
                <asp:TextBox ID="JSTextBox1" runat="server" OnTextChanged="JSTextBox1_TextChanged"></asp:TextBox>
                <asp:Button ID="JSButton1" runat="server" Text="Zarejestruj" OnClick="JSButton1_Click1" /><br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="false" DisplayMode="BulletList" ShowSummary="true" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="JSTextBox1" ValidationExpression ="[a-zA-Z]+\s[a-zA-Z]+" runat="server" ErrorMessage="Identyfikator nie jest zgodny ze wzorcem" Display="None" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Wypelnienie tego pola jest wymagane" ControlToValidate="JSTextBox1" Display="None"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Takie imie i nazwisko znajduje sie bazie" ControlToValidate="JSTextBox1" Display="None"></asp:CustomValidator>
                <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Ten uzytkwonik ma juz aktywna sesje" ControlToValidate="JSTextBox1" Display="None"></asp:CustomValidator>
               
            </div>
          
        </asp:Panel>


    <div class="container">             
           <asp:Panel ID="JSPanel1" runat="server" Visible="false"> 
            <div class="one">
            
                

                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="red"></asp:Label><br /><br /><br />
                <p class="naglowek">Okreśłenie rozmiaru elementów</p>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="s">Mały rozmiar elementu</asp:ListItem>
                <asp:ListItem Value="m">Średni rozmiar elementu</asp:ListItem>
                <asp:ListItem Value="x">Duży rozmiar elementu</asp:ListItem>
                </asp:RadioButtonList>
   
               <p class="naglowek"> Okreslenie polozenia rysunków</p>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="0">Kostka piątka</asp:ListItem>
                <asp:ListItem Value="1">Przekątna lewa</asp:ListItem>
                <asp:ListItem Value="2">Przekątna prawa</asp:ListItem>
                <asp:ListItem Value="3">Linia poziomo</asp:ListItem>
                <asp:ListItem Value="4">Linia pionowo</asp:ListItem>
                </asp:DropDownList>
                <asp:ScriptManager runat="server"></asp:ScriptManager>
                <div class="ramka">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    
                    <ContentTemplate>
                        <p class="naglowek"> Dane uzytkwonikow</p>
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True"></asp:DropDownList><br />
                        <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Ten uzytkownik ma aktywna sesje" ControlToValidate="JSTextBox1" Display="None"></asp:CustomValidator>
                        <br />
                        <asp:Label id="dane1"  runat="server" Text="Data Uruchomienia:" CssClass="JSlabel"></asp:Label>
                        <asp:Label id="Label2"  runat="server" Text="" CssClass="JSlabel"></asp:Label><br />

                    <asp:Label id="dane2" runat="server" Text="Godzina uruchomienia:"></asp:Label>
                        <asp:Label id="Label3"  runat="server" Text="" CssClass="JSlabel"></asp:Label><br />
                    
                    <asp:Label id="dane3" runat="server" Text="Ile zmian rozmiaru:" CssClass="JSlabel"></asp:Label>
                        <asp:Label id="Label4"  runat="server" Text="" CssClass="JSlabel"></asp:Label><br />

                    <asp:Label id="dane4" runat="server" Text="Ile zmian ukladu:" CssClass="JSlabel"></asp:Label>
                        <asp:Label id="Label5"  runat="server" Text="" CssClass="JSlabel"></asp:Label><br />
                   
                     <asp:Label id="dane5" runat="server" Text="Ile uzytkownikow:" CssClass="JSlabel"></asp:Label>
                        <asp:Label id="Label6"  runat="server" Text="" CssClass="JSlabel"></asp:Label><br />

                    <asp:Label id="dane6" runat="server" Text="Ile aplikacji:" CssClass="JSlabel"></asp:Label>
                        <asp:Label id="Label7"  runat="server" Text="" CssClass="JSlabel"></asp:Label><br />

                    </ContentTemplate>
                    <Triggers>
                    <asp:AsyncPostBackTrigger  ControlID="Timer1" EventName="Tick" />
                    </Triggers>
                </asp:UpdatePanel>
                </div>
                <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick">
</asp:Timer> 
            </div>
            <div class ="two">
                <asp:Image ID="Image0" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image1" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image2" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image3" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image4" runat="server" src="/and.jpeg" Width="50" Height="50"></asp:Image>
            </div>   
                 </asp:Panel>
    </div>
    </form>     
    </body>
</html>
