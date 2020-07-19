<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eczaneler.aspx.cs" Inherits="NobetciEczanem.eczaneler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
<link href="https://fonts.googleapis.com/css?family=Montserrat|Poppins&display=swap" rel="stylesheet"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.1/css/all.css"/>
<link rel="shortcut icon" type="image/png" href="images/logo.png" />
<link href='css/style.css' rel='stylesheet' type='text/css'/>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" charset="utf-8"></script>
    <title>Eczaneler</title>
</head>
<body style="background:#f3f3f3">
     <div class="ana">
            <div id="navbar2">
                 <div id="logoimg2"></div>
                 <div id="logo2">NobetciEczanem</div>
                <div class="arama">
                    <form runat="server" method="post">
                      <div class="selectbox2">
                          <asp:DropDownList ID="dropDownListIl" CssClass="select1"  AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="dropDownListIl_SelectedIndexChanged" runat="server"></asp:DropDownList>
                       </div>
                        <div class="selectbox2">
                            <asp:DropDownList ID="dropDownListIlce" CssClass="select2"  AutoPostBack="true" runat="server"></asp:DropDownList>
                       </div>
                    </form>
                     <form action="eczaneler.aspx" method="post">
                         <input type="hidden" id="ilfield" name="ilfield"/>
                         <input type="hidden" id="ilcefield" name="ilcefield"/>
                         <input type="submit" class="buton" value="Ara" />
                     </form>
                </div>
                  <div class="socialmedia">
                      <i class="fab fa-facebook"></i>
                      <i class="fab fa-instagram"></i>
                      <i class="fab fa-twitter"></i>
                      <i class="fab fa-linkedin"></i>
                  </div>
            </div>
         <div class="eczaneler">
             <h1 id="ililce" runat="server"></h1>
             <div id="ecz" runat="server">
             </div>
         </div>
     </div>
     <script>
        var e = document.getElementById("dropDownListIl");
        var e1 = document.getElementById("dropDownListIlce");
        document.getElementById("ilfield").value = e.options[e.selectedIndex].value;
        document.getElementById("ilcefield").value = e1.options[e1.selectedIndex].value;
    </script>
</body>
</html>
