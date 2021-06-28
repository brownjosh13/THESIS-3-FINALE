<?php
include('noaccount.php');
include('logout.php');
include('leftpanel.php');
include('updatedata.php');
include('connection.php');


$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");




if ( isset( $_POST['update'] ) ) {
  @$id = $_POST['id'];
  $avail = $_POST['Availability'];
  $fulln = $_POST['Fullname'];
  $age = $_POST['Age'];
  $cs = $_POST['Civil_Status'];
  $addr = $_POST['Address'];
  $status = $_POST['Status'];
  $note = $_POST['Note'];
  $room = $_POST['Room_No'];
  $temp= $_POST['Temperature'];
  $bpm = $_POST['BPM'];
  $month = $_POST['Month'];
  $day = $_POST['Day'];
  $year = $_POST['Year'];
  $time = $_POST['Time'];

echo '<script>alert("Patient data updated.")</script>';
  $sqlupdate = mysqli_query($db,"UPDATE patient SET Availability='$avail', Fullname='$fulln', Age='$age', Civil_Status='$cs', Address='$addr', Status='$status', Note='$note',
  Room_No='$room', Temperature='$temp', BPM='$bpm', Month='$month',Day='$day',Year='$year', Timess='$time' WHERE id = '$id'");


  $_SESSION['id'] = '';
  $_SESSION['avail'] = '';
  $_SESSION['fulln'] = '';
  $_SESSION['age'] = '';
  $_SESSION['cs'] = '';
  $_SESSION['addr'] = '';
  $_SESSION['status'] = '';
  $_SESSION['note'] = '';
  $_SESSION['room'] = '';
  $_SESSION['temp'] = '';
  $_SESSION['bpm'] = '';
  $_SESSION['month'] = '';
  $_SESSION['day'] = '';
  $_SESSION['year'] ='';
  $_SESSION['time'] = '';
  require_once('smsGatewayV4.php');
  $token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhZG1pbiIsImlhdCI6MTYyNDM3NTY1OCwiZXhwIjo0MTAyNDQ0ODAwLCJ1aWQiOjg5MjUyLCJyb2xlcyI6WyJST0xFX1VTRVIiXX0.znNmtDXAZEtKYGdUPRjKtYzCuatzmOobhR7Cx7gTfbQ";

  $phone_number = "09169253807";
  $phone_number2 = "09282635199";
  $message = "Patient ".$fulln ." data updated";
  $deviceID = 124865;
  $options = [];

  $smsGateway = new SmsGateway($token);
  $result = $smsGateway->sendMessageToNumber($phone_number, $message, $deviceID, $options);
  $result2 = $smsGateway->sendMessageToNumber($phone_number2, $message, $deviceID, $options);

}


if ( isset( $_POST['delete'] ) ) {
  @$id = $_POST['id'];
  $avail = $_POST['Availability'];
  $fulln = $_POST['Fullname'];
  $age = $_POST['Age'];
  $cs = $_POST['Civil_Status'];
  $addr = $_POST['Address'];
  $status = $_POST['Status'];
  $note = $_POST['Note'];
  $room = $_POST['Room_No'];
  $temp= $_POST['Temperature'];
  $bpm = $_POST['BPM'];
  $month = $_POST['Month'];
  $day = $_POST['Day'];
  $year = $_POST['Year'];
  $time = $_POST['Time'];


echo '<script>alert("Patient data deleted...")</script>';
  $sqlupdate = mysqli_query($db,"DELETE FROM patient WHERE id = '$id'");

  $_SESSION['id'] = '';
  $_SESSION['avail'] = '';
  $_SESSION['fulln'] = '';
  $_SESSION['age'] = '';
  $_SESSION['cs'] = '';
  $_SESSION['addr'] = '';
  $_SESSION['status'] = '';
  $_SESSION['note'] = '';
  $_SESSION['room'] = '';
  $_SESSION['temp'] = '';
  $_SESSION['bpm'] = '';
  $_SESSION['month'] = '';
  $_SESSION['day'] = '';
  $_SESSION['year'] ='';
  $_SESSION['time'] = '';
}

include('searchs.php');
?>

<html>

  <head>
      <link rel="shortcut icon" type="image/x-icon" href="Admin.jpg">
      <meta charset="utf-8">
          <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="patientlist.css" media="">
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

    <div class="containerrr">
      <form method="POST" action="http://healthmonitoring.bcamp2017.com/staff/Patientlist.php" >
        <input type="text" placeholder="" name="id" style="background-color:rgba(255,255,255,0);border-color:rgba(255,255,255,0);color:rgba(255,255,255,0)" class="availbility" value="<?= @$_SESSION['id'] ?>" readonly>
<br>
      <h1 class="header" style="font-size: 30px;">Update Data</h1>
      <br>
              <label for="Firstname" ><b class="TextID">Availability</b></label>
        <input type="text" placeholder="Still under monitoring?" name="Availability" class="availbility" value="<?= @$_SESSION['avail'] ?>">

<br>

        <label for="Firstname" ><b class="TextFname">Fullname</b></label>
        <input type="text" placeholder="Patient fullname." name="Fullname" class="fullname" value="<?= @$_SESSION['fulln'] ?>" required>

  <br>
  <label for="Firstname" ><b class="TextFname">Age</b></label>
  <input type="text" placeholder="Age" name="Age" class="age" value="<?= @$_SESSION['age'] ?>" required>

<br>

        <label for="Firstname" ><b class="TextCivilStatus">Civil Status</b></label>
        <input type="text" placeholder="Patient civil status." name="Civil_Status" class="civilstatus" value="<?= @$_SESSION['cs'] ?>" required>

<br>


        <label for="Firstname" ><b class="TextAddress">Barangay</b></label>
        <input type="text" placeholder="Patient address." name="Address" class="address" value="<?= @$_SESSION['addr'] ?>" required>
<br>

        <label for="Firstname" ><b class="TextStatus">Status</b></label>
        <input type="text" placeholder="Patient condition." name="Status" class="status" value="<?= @$_SESSION['status'] ?>" required>

<br>

        <label for="Firstname" ><b class="TextNote">Note</b></label>
        <input type="text" placeholder="Medication Note" name="Note" class="note" value="<?= @$_SESSION['note'] ?>" required>

<br>

        <label for="Firstname" ><b class="TextRoomNo">Room No.</b></label>
        <input type="text" placeholder="Patient room number." name="Room_No" class="Fname" value="<?= @$_SESSION['room'] ?>" required>

<br>



        <label for="Firstname" ><b class="TextTemperature">Temperature</b></label>
        <input type="text" placeholder="Patient temperature" name="Temperature" class="temperature" value="<?= @$_SESSION['temp'] ?>" required>

<br>


        <label for="Firstname" ><b class="TextBPM">BPM</b></label>
        <input type="text" placeholder="Beats per minute." name="BPM" class="bpm" value="<?= @$_SESSION['bpm'] ?>" required>

<br>
        <label for="Firstname" ><b class="TextDate" style="position:relative; left: -85px">Month</b></label>
        <input type="number" max="12" min="1" name="Month" value="<?= @$_SESSION['month'] ?>" style="position:relative; left:-46px; " placeholder="MM">



<br>
<label for="Firstname" ><b class="TextDate"  style="position:relative; left:-85px">Day</b></label>
<input type="number" max="31" min="1" name="Day" value="<?= @$_SESSION['day'] ?>" style="position:relative; left: -34px;" placeholder="DD">


<br>

<label for="Firstname" ><b class="TextDate"  style="position:relative; left:-75px">Year</b></label>
<input type="number" max="2022" min="2015" name="Year" value="<?= @$_SESSION['year'] ?>" style="position:relative; left:-31px;" placeholder="YYYY"  >

<br>
        <label for="Firstname" ><b class="TextTime" style="position:relative; left: 20px;">Time</b></label>
        <input type="time" placeholder="Time of check-up" name="Time" class="time" value="<?= @$_SESSION['time'] ?>" required>

              <button type="submit" name="update" style="position relative; bottom: -50px; left: 10px; width: 25%; font-size: 18px; background-color:#21466E" > Update </button>
              <button type="delete" name="delete" style="position relative; bottom: -17px; left: 60px; width: 25%; font-size: 18px; background-color:#21466E"> Delete </button>

      </form>

    </div>

    <div class="containers">

      <br />
      <br />
      <br />


<span  class="t1">Patient Records </span>
        <button onclick="window.print();" class="btn btn-primary" style="" id="print-btn">Print</button>
      <div class="form-group">
        <div class="input-group">
          <span class="input-group-addon" style="border-style: none;">Search</span>
          <br>
          <input type="text" name="search_text" id="search_text" placeholder="Search Patient" class="form-control" style="margin-bottom: 30px; margin-left: 80px; width: 60%" />
        </div>
      </div>
      <br />
      <div >
        <?=

        $_SESSION['Searchs'] ?>
      </div>
    </div>



    <div style="clear:both">
    </div>
  </body>
</html>
