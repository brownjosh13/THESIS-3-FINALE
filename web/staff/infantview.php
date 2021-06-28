<?php

include('noaccount.php');
include('logout.php');
include('leftpanel.php');
include('updateinfant.php');
include('connection.php');

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
     <link rel="stylesheet" type="text/css" href="../staff/infantview.css" media="">
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

   <div class="containerr">
     <form method="POST" action="http://healthmonitoring.bcamp2017.com/staff/infantview.php">
       <input type="text" placeholder="" name="kidID" style="background-color:rgba(255,255,255,0);border-color:rgba(255,255,255,0);color:rgba(255,255,255,0)" class="id" value="<?= @$_SESSION['kidID'] ?>" readonly>
<br>
     <h1 class="header" style="font-size: 30px;">Update Data</h1>
     <br>
             <label for="Firstname" ><b class="TextID">Name</b></label>
       <input type="text" placeholder="Baby name." name="name" class="name" value="<?= @$_SESSION['name'] ?>">

<br>

       <label for="Firstname" ><b class="TextFname">Age</b></label>
       <input type="text" placeholder="Age." name="age" class="fullname" value="<?= @$_SESSION['age'] ?>" >

 <br>
 <label for="Firstname" ><b class="TextFname">Weight</b></label>
 <input type="text" placeholder="kg" name="weight" class="age" value="<?= @$_SESSION['weight'] ?>" >

<br>

       <label for="Firstname" ><b class="TextCivilStatus">Height</b></label>
       <input type="text" placeholder="cm" name="height" class="civilstatus" value="<?= @$_SESSION['height'] ?>" >
<br>
       <label for="Firstname" ><b class="TextAddress">Vaccine</b></label>
       <input type="text" placeholder="Vaccine" name="typeofvaccine" class="address" value="<?= @$_SESSION['typeofvaccine'] ?>" >
<br>

       <label for="Firstname" ><b class="TextStatus"  style="position:relative; left:-86px;">Month</b></label>
       <input type="number"  min="1" max="12" placeholder="Today" style="position:relative; left:-46px; border: 3px solid black;" name="month" class="status" value="<?= @$_SESSION['month'] ?>" >

<br>
       <label for="Firstname" ><b class="TextNote"  style="position:relative; left:-90px;">Day</b></label>
       <input type="number" min="1" max="31" placeholder="Today"  name="day" class="note" value="<?= @$_SESSION['day'] ?>"  style="position:relative; left:-33px; border: 3px solid black;">
<br>
       <label for="Firstname" ><b class="TextRoomNo"  style="position:relative; left:-82px;">Year</b></label>
       <input type="number" max="2022" min="2015" placeholder="Today" name="year" class="Fname" value="<?= @$_SESSION['year'] ?>"   style="position:relative; left:-30px; border: 3px solid black;">
<br>
      <H1 style="font-size: 20px;"> Edit Next Vaccination Schedule </h1>

       <label for="Firstname" ><b class="TextTemperature"  style="position:relative; left:-56px;">Month</b></label>
       <input type="number" min="1" max="12" placeholder="YYYY" name="nextMonth" class="temperature" value="<?= @$_SESSION['nextMonth'] ?>"   style="position:relative; left:-46px; border: 3px solid black;">

<br>


       <label for="Firstname" ><b class="TextBPM" style="position:relative; left:-66px;">Day</b></label>
       <input type="number" min="1" max="31" placeholder="DD" name="nextDay" class="bpm" value="<?= @$_SESSION['nextDay'] ?>"   style="position:relative; left:-34px; border: 3px solid black;">
<br>
       <label for="Firstname" ><b class="TextDate" style="position:relative; left:43px;">Year</b></label>
       <input type="number" max="2022" min="2015" name="nextYear" value="<?= @$_SESSION['nextYear'] ?>" style="position:relative; left:68px; border: 3px solid black;" placeholder="YYYY">


             <button type="submit" name="update" style="position relative; bottom: -70px; left: -90px; width: 25%; font-size: 18px; background-color:#21466E" > Update </button>
             <button type="submit" name="delete" style="position relative; bottom: -70px; left: -50px; width: 25%; font-size: 18px; background-color:#21466E"> Delete </button>

     </form>

   </div>

    <div class="container">
   <span  class="t1">Infant Records </span>
           <button onclick="window.print();" class="btn btn-primary" style="position:absolute; top: 50px; left: 1050px;" id="print-btn">Print</button>
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
