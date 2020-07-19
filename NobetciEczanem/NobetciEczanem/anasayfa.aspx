<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="NobetciEczanem.anasayfa" %>

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
    <title>Anasayfa</title>
</head>
<body>
      <div class="ana">
          <div class="top">
            <div id="navbar">
                 <div id="logoimg"></div>
                 <div id="logo">NobetciEczanem</div>
                  <div id="navbar-right">
                      <i class="fab fa-facebook"></i>
                      <i class="fab fa-instagram"></i>
                      <i class="fab fa-twitter"></i>
                      <i class="fab fa-linkedin"></i>
       
                  </div>
            </div>
               <div class="topmiddle">
                 <h1>İstediğiniz noktadaki nöbetçi eczaneyi anında bulun</h1>
                 <div class="searchbox">
                    <form action="anasayfa.aspx" runat="server" method="post">
                      <div class="selectbox">
                          <asp:DropDownList ID="dropDownListIl" CssClass="select" AutoPostBack="true" OnSelectedIndexChanged="dropDownListIl_SelectedIndexChanged" runat="server"></asp:DropDownList>
                       </div>
                        <div class="selectbox">
                            <asp:DropDownList ID="dropDownListIlce" AutoPostBack="true" CssClass="select" runat="server"></asp:DropDownList>
                       </div>
                    </form>
                     <form action="eczaneler.aspx" method="post">
                         <input type="hidden" id="ilfield" name="ilfield"/>
                         <input type="hidden" id="ilcefield" name="ilcefield"/>
                         <input type="submit" class="btnsearch" value="Ara" />
                     </form>
                 </div> 
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
