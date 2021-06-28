<?php
include('noaccount.php');
include('logout.php');
include('leftpanel.php');
include('searchmonitoring.php');

$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");

$output = '';

if (isset($_POST['update']))
{

  echo '<script>alert("Patient discharge...")</script>';
  header('location:http://localhost/web/staff/monitoring.php');
  $id = $_POST['update'];
  $sqlupdate = mysqli_query($db,"UPDATE patient SET Availability='Dismiss' WHERE id = '$id'");

  $quer = mysqli_query($db,"SELECT * FROM patient WHERE id = '$id'");
  while ($row = $quer ->fetch_assoc()) {
    $_SESSION['Fullname'] = $row['Fullname'];

  }
  //sms start
  require_once('smsGatewayV4.php');
  $token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhZG1pbiIsImlhdCI6MTYyNDM3NTY1OCwiZXhwIjo0MTAyNDQ0ODAwLCJ1aWQiOjg5MjUyLCJyb2xlcyI6WyJST0xFX1VTRVIiXX0.znNmtDXAZEtKYGdUPRjKtYzCuatzmOobhR7Cx7gTfbQ";

  $phone_number = "09169253807";
  $phone_number2 = "09282635199";
  $phone_number3 = "09777481427";
  $message = "Patient ".$_SESSION['Fullname']." has been discharge";
  $deviceID = 124865;
  $options = [];

  $smsGateway = new SmsGateway($token);
  $result = $smsGateway->sendMessageToNumber($phone_number, $message, $deviceID, $options);
  $result2 = $smsGateway->sendMessageToNumber($phone_number2, $message, $deviceID, $options);
  $result3 = $smsGateway->sendMessageToNumber($phone_number3, $message, $deviceID, $options);

  //sms end
}

 ?>

<html>
<link rel="stylesheet" type="text/css" href="search.css">
  <head>
      <link rel="shortcut icon" type="image/x-icon" href="Admin.jpg">
    <script src="jquery.min.js"></script>
    <script src="bootstrap.min.js"></script>
    <link href="bootstrap.min.css" rel="stylesheet" />
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
          <span class="input-group-addon" style="border-style: none" name="search">Search</span>
    <br>
          <input type="text" name="search_text" id="search_text" placeholder="Search Patient" class="form-control" style="margin-bottom: 30px;" />

        </div>
      </div>
      <br >
      <br>
    <?= @$_SESSION['SearchsMonitoring'] ?>
    </div>

    <div style="clear:both"></div>
  </body>
</html>
