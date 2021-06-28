<?php
include('noaccount.php');

include('logout.php');

include('searchmonitoring.php');
$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass = "Talaba07!";
$db = mysqli_connect($servername, $username,$dbpass,"healthmonitoring");
$output = '';

if (isset($_POST['update']))
{
  $id = $_POST['update'];

echo '<script>alert("Patient is dismiss.")</script>';
  $sqlupdate = mysqli_query($db,"UPDATE patient SET Availability='Dismiss' WHERE id = '$id'");

}

 ?>

<html>
<link rel="stylesheet" type="text/css" href="search.css">

  <head>
        <link rel="shortcut icon" type="image/x-icon" href="Admin.jpg">
    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

      <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="monitoring.css">
   <title>Patient List</title>
  </head>
  <style>
    .t1 {
      font-family: verdana;
      font-size: 40px;
    }


  </style>
  <body>
    <nav class="nav__cont" style="background-color:#6E4201;">
      <ul class="navv">

        <img src="../logo/healthlogo.png" style="width: 150px; position:relative; right: 20px;margin-top: 50px;">
        <br>
        <br>
        <br>
        <br>
         <li class="nav__items">
          <img src="../Logo/message.png" class="Logo" style="position:relative; left: -70px; top: 35px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/messenger.php"style="position:relative; top: 5px;">Message</a>
        </li>
        <br>
        <li class="nav__items ">
          <img src="../Logo/patient.png" class="Logo" style="position:relative; left:  -70px;  top: -25px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/patientlist.php" style="position:relative;top: -55px; left: 10px">Patient List</a>
        </li>
            <br>
        <li class="nav__items ">
          <img src="../Logo/babylist.png" class="Logo" style="position:relative; left:  -70px;  top: -75px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/infantview.php" style="position:relative;top: -105px; left: 10px; font-size: 19px">Toddlers</a>
        </li>
      <br>
        <li class="nav__items">
          <img src="../Logo/admit.png" class="Logo"style="position:relative; left:  -70px; top: -155px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/monitoring.php" style="position:relative;top: -185px; left: 10px;">Admitted</a>
        </li>
      <br>

      <br>

    </ul>
    <form method="GET">
    <input type="submit" value="Sign-out" class="" name="Logout" style="font-size: 20px; border: 1px solid black; border-radius: 3px; position:absolute; bottom: 8px; left: 75px; cursor: pointer;">
      </form>
    </nav>
    <div class="container">
      <br />
      <br />
      <br />
     <div class="bacoor">

    </div>
<span  class="t1">Patient Under Monitoring</span>

      <div class="form-group">
          <button onclick="window.print();" class="btn btn-primary" style="" id="print-btn">Print</button>
        <div class="input-group">
          <span class="input-group-addon" style="border-style: none">Search</span>
    <br>
          <input type="text" name="search_text" id="search_text" placeholder="Search Patient" class="form-control" style="margin-bottom: 30px;" />

        </div>
      </div>
      <br >
      <br>
      <?= $_SESSION['SearchsMonitoring'] ?>
    </div>

    <div style="clear:both"></div>
  </body>
</html>
