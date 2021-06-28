<?php

include('noaccount.php');
include('logout.php');

$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");


if (isset( $_POST['update'] ) ) {
  @$kidID = $_POST['kidID'];
  $name = $_POST['name'];
  $age = $_POST['age'];
  $weight = $_POST['weight'];
  $height = $_POST['height'];
  $typeofvaccine = $_POST['typeofvaccine'];
  $month = $_POST['month'];
  $day = $_POST['day'];
  $year = $_POST['year'];
  $nextMonth = $_POST['nextMonth'];
  $nextDay = $_POST['nextDay'];
  $nextYear = $_POST['nextYear'];

  echo '<script>alert("Infant data updated.")</script>';
  $sqlupdate = mysqli_query($db,"UPDATE kidsvaccination SET name='$name', age='$age', weight='$weight', height='$height', typeofvaccine='$typeofvaccine', month='$month',day='$day',
    year='$year', nextMonth='$nextMonth', nextDay='$nextDay', nextYear='$nextYear' WHERE kidID = '$kidID'");


  $_SESSION['kidID'] = '';
  $_SESSION['name'] = '';
  $_SESSION['age'] = '';
  $_SESSION['weight'] = '';
  $_SESSION['height'] = '';
  $_SESSION['typeofvaccine'] = '';
  $_SESSION['month'] = '';
  $_SESSION['day'] = '';
  $_SESSION['year'] = '';
  $_SESSION['nextMonth'] = '';
  $_SESSION['nextDay'] = '';
  $_SESSION['nextYear'] = '';
}
if ( isset( $_POST['delete'] ) ) {
  @$kidID = $_POST['kidID'];



echo '<script>alert("Infant data deleted...")</script>';
  $sqlupdate = mysqli_query($db,"DELETE FROM kidsvaccination WHERE kidID = '$kidID'");

    $_SESSION['kidID'] = '';
    $_SESSION['name'] = '';
    $_SESSION['age'] = '';
    $_SESSION['weight'] = '';
    $_SESSION['height'] = '';
    $_SESSION['typeofvaccine'] = '';
    $_SESSION['month'] = '';
    $_SESSION['day'] = '';
    $_SESSION['year'] = '';
    $_SESSION['nextMonth'] = '';
    $_SESSION['nextDay'] = '';
    $_SESSION['nextYear'] = '';
}

include('infantlist.php');
 ?>

 <html>
 <link rel="stylesheet" type="text/css" href="">
   <head>
       <link rel="shortcut icon" type="image/x-icon" href="Admin.jpg">

     <link href="bootstrap.min.css" rel="stylesheet" />
     <link rel="stylesheet" type="text/css" href="../doctor/infantview.css" media="">
     <link rel="stylesheet" type="text/css" href="print.css" media="print">

    <title>Patient Records</title>
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
       <br>
       <img src="../logo/healthlogo.png" style="width: 150px; position:relative; margin-top: 20px; margin-right: 50px;">
       <br>
       <br>
       <br>
       <br>
        <li class="nav__items ">
         <img src="../Logo/message.png" class="Logo" style="position:relative; left: -60px; top: 25px">
         <a href="http://healthmonitoring.bcamp2017.com/doctor/messenger.php"style="position:relative; top: -3px;left: 10px">Message</a>
       </li>
 <br>
       <li class="nav__items ">
         <img src="../Logo/patient.png" class="Logo" style="position:relative; left: -65px; bottom: -4px; top: 15px">
         <a href="http://healthmonitoring.bcamp2017.com/doctor/patientlist.php" style="position:relative;top: -15px; left: 10px">Patient List</a>
       </li>
       <br>
       <li class="nav__items ">
         <img src="../Logo/babylist.png" class="Logo" style="position:relative; left: -65px; bottom: -4px; top: 25px">
         <a href="http://healthmonitoring.bcamp2017.com/doctor/infantview.php" style="position:relative;top: -5px; left: 10px">Toddlers</a>
       </li>
       <br>
       <li class="nav__items">
         <img src="../Logo/admit.png" class="Logo"style="position:relative; left: -65px; top: -2px">
         <a href="http://healthmonitoring.bcamp2017.com/doctor/monitoring.php" style="position:relative;top: -30px; left: 10px">Admitted</a>
       </li>
       <br>

 <br>

       <br>
     </ul>
     <form method="GET" >
     <input type="submit" value="Sign-out" class="Buttons" name="Logout" style="font-size: 20px; border: 1px solid black; border-radius: 3px; position:absolute; bottom: 8px; left: 75px;">
       </form>

   </nav>


    <div class="container">
   <span  class="t1">Infant Records </span>
           <button onclick="window.print();" class="btn btn-primary" style="position:absolute; top: 50px; left: 1450px;" id="print-btn">Print</button>
         <div class="form-group">
           <div class="input-group">
             <span class="input-group-addon" style="border-style: none; position:relative; left: 10px">Search</span>
             <br>
             <input type="text" name="search_text" id="search_text" placeholder="Search Patient" class="form-control" style="position:absolute; left: 80px; width: 20%; top: -2px" />
           </div>
         </div>
         <br />
         <div >
           <?= $_SESSION['InfantList'] ?>
         </div>
       </div>



       <div style="clear:both">
       </div>
     </body>
   </html>

   <script src="jquery.min.js"></script>
  <script src="bootstrap.min.js"></script>
