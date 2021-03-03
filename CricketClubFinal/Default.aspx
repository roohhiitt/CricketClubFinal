<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CricketClubFinal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8">
  <title>CricketClub</title>
  <meta content="width=device-width, initial-scale=1.0" name="viewport">
  <meta content="" name="keywords">
  <meta content="" name="description">

  <!-- Favicons -->
  <link href="img/favicon.png" rel="icon">
  <link href="img/apple-touch-icon.png" rel="apple-touch-icon">

  <!-- Google Fonts -->
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,700,700i|Poppins:300,400,500,700" rel="stylesheet">

  <!-- Bootstrap CSS File -->
  <link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet">

  <!-- Libraries CSS Files -->
  <link href="lib/font-awesome/css/font-awesome.min.css" rel="stylesheet">
  <link href="lib/animate/animate.min.css" rel="stylesheet">

  <!-- Main Stylesheet File -->
  <link href="css/style.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
         <!--==========================
  Header
  ============================-->
  <header id="header">
    <div class="container">


      <nav id="nav-menu-container">
        <ul class="nav-menu">
          <li class="menu-active"><a href="#hero">Home</a></li>
          <li><a href="SignUp.aspx">Registration</a></li>
            <li><a href="SignIn.aspx">Login</a></li>
          
          <li class="menu-has-children"><a href="">Sports</a>
            <ul>
              <li><a href="#">Cricket</a></li>
              <li class="menu-has-children"><a href="#">Badminton</a>
                <ul>
                  <li><a href="#">Singles</a></li>
                  <li><a href="#">Doubles</a></li>
                </ul>
              </li>
              <li><a href="#">Volleyball</a></li>

            </ul>
          </li>
        </ul>
      </nav><!-- #nav-menu-container -->
    </div>
    
  </header><!-- #header -->

  <!--==========================
    Hero Section
  ============================-->
    <section id="hero">
    <div class="hero-container">
      <h1>Welcome to Kumuli Sports Club</h1>
      <h2>Start where you are. Use what you have. Do what you can </h2>
      <a href="#about" class="btn-get-started">Get Started</a>
    </div>
  </section><!-- #hero -->

  <main id="main">



          
           
    </form>
      <!-- JavaScript Libraries -->
  <script src="lib/jquery/jquery.min.js"></script>
  <script src="lib/jquery/jquery-migrate.min.js"></script>
  <script src="lib/bootstrap/js/bootstrap.bundle.min.js"></script>
  <script src="lib/easing/easing.min.js"></script>
  <script src="lib/wow/wow.min.js"></script>
  <script src="lib/waypoints/waypoints.min.js"></script>
  <script src="lib/counterup/counterup.min.js"></script>
  <script src="lib/superfish/hoverIntent.js"></script>
  <script src="lib/superfish/superfish.min.js"></script>

  <!-- Contact Form JavaScript File -->
  <script src="contactform/contactform.js"></script>

  <!-- Template Main Javascript File -->
  <script src="js/main.js"></script>
</body>
</html>
