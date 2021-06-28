<!-- PHP Starts  -->
<?php
include('noaccount.php');
include('leftpanel.php');
include('logout.php');


$_SESSION['Loopheight'] = '';
$_SESSION['Loopweight'] = '';
$_SESSION['Looptemp'] = '';
$_SESSION['Loopbpm'] = '';

$db = mysqli_connect('sabinojohnrey72888.domaincommysql.com', 'talaba7', 'Talaba07!', 'healthmonitoring');

$_SESSION['Availability'] = '';
$_SESSION['Fullname'] = '';
$_SESSION['Civil_Status'] = '';
$_SESSION['Address'] = '';
$_SESSION['Status'] = '';
$_SESSION['Note'] = '';
$_SESSION['Room_No'] = '';
$_SESSION['Height'] = '';
$_SESSION['Weight'] = '';
$_SESSION['Temperature'] = '';
$_SESSION['BPM'] = '';
$_SESSION['Month'] = '';
$_SESSION['Day'] = '';
$_SESSION['Year'] = '';
$_SESSION['Time'] = '';

for ($i=40; $i < 222;  $i++)
{
@$output .='
  <option>'.$i.'</option>
  ';
}

$_SESSION['Loopheight'] = $output;

for ($w=40; $w < 251; $w++)
{
@$output1 .='
  <option>'.$w.'</option>
  ';
}

$_SESSION['Loopweight'] = $output1;

for ($t=22; $t < 42; $t++)
{
@$output2 .='
  <option>'.$t.'</option>
  ';
}

$_SESSION['Looptemp'] = $output2;


for ($b=40; $b < 151; $b++)
{
@$output3 .='
  <option>'.$b.'</option>
  ';
}

$_SESSION['Loopbpm'] = $output3;




if(isset($_GET['registerbtn']))
{
  $availability = ($_GET['availability']);
  $fullname = ($_GET['fullname']);
  $civilstatus = ($_GET['civilstatus']);
  $address = ($_GET['address']);
  $status = ($_GET['status']);
  $note = ($_GET['note']);
  $roomno = ($_GET['roomno']);
  $height = ($_GET['height']);
  $weight = ($_GET['weight']);
  $temperature = ($_GET['temperature']);
  $bpm = ($_GET['bpm']);
  $month = ($_GET['month']);
  $day = ($_GET['day']);
  $year = ($_GET['year']);
  $time = ($_GET['time']);


  $sql = "INSERT INTO patient (Availability,Fullname,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Month,Day,Year,Timess)
   VALUES ('$availability','$fullname','$civilstatus','$address','$status','$note','$roomno','$height','$weight','$temperature','$bpm',
  '$month','$day','$year','$time')";
  mysqli_query($db,$sql);
  //sms start
  require_once('smsGatewayV4.php');
  $token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhZG1pbiIsImlhdCI6MTYyNDM3NTY1OCwiZXhwIjo0MTAyNDQ0ODAwLCJ1aWQiOjg5MjUyLCJyb2xlcyI6WyJST0xFX1VTRVIiXX0.znNmtDXAZEtKYGdUPRjKtYzCuatzmOobhR7Cx7gTfbQ";

  $phone_number = "09169253807";
  $phone_number2 = "09282635199";
  $phone_number3 = "09777481427";
  $message = "New patient inserted. Patient ".$fullname." data inserted, kindly register a new RFID for him/her.";
  $deviceID = 124865;
  $options = [];

  $smsGateway = new SmsGateway($token);
  $result = $smsGateway->sendMessageToNumber($phone_number, $message, $deviceID, $options);
  $result2 = $smsGateway->sendMessageToNumber($phone_number2, $message, $deviceID, $options);
  $result3 = $smsGateway->sendMessageToNumber($phone_number3, $message, $deviceID, $options);

  //sms end

  echo '<script>alert("New patient data inserted.")</script>';
header("location: addpatient.php");
}


?>
<!-- PHP Ends  -->

<!-- HTML Starts -->
<!DOCTYPE html>

<html>
<link rel="stylesheet" type="text/css" href="Addpatient.css">


<head>

<title> Add New Patient </title>
</head>
<script src="http://localhost/ProjectSaad/a076d05399.js"></script>
<!-- Body Starts -->
<body>




<div class="Border">
  <!-- Header Starts -->
  <h1 class="Header">ADD NEW PATIENT DATA</h1>
  <p class="Header">Please fill up the field with the data needed.</p>
  <!-- Header Ends -->

  <br>
  <br>
  <!-- Forms Starts -->
    <form method="get" action="Addpatient.php">

            <label for="Firstname" style="position: relative; left: 100px;"><b class="TextID">Availability</b></label>
            <select id="availability"  name="availability">
            <option value="Admitted">Admitted</option>
            <option value="Discharge">Discharge</option>

            </select>
      <br>
      <br>
      <!-- Fullname Starts -->
      <label for="Firstname" style="position: relative; left: 100px;"><b class="TextFname" >Fullname</b></label>
      <input type="text" placeholder="Patient fullname." name="fullname" class="fullname" value="<?= $_SESSION['Fullname'] ?>" required>

      <!-- Fullname Ends -->

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextCivilStatus" style="position: relative; left: 50px;">Civil Status</b></label>
      <select id="civilstatus"  name="civilstatus">
                 <option value="Single">Single</option>
                 <option value="Married">Married</option>
                 <option value="Widowed">Widowed</option>
                 <option value="Divorced">Divorced</option>
             </select>

        <br>
       <br>


       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextAddress" style="position: relative; left: 50px;">Address</b></label>
      <select id="address" name="address">
 <option value="Alima">  Alima </option>
 <option value="Aniban I">  Aniban I</option>
 <option value="Aniban II">  Aniban II</option>
 <option value="Aniban III">  Aniban III</option>
 <option value="Aniban IV">  Aniban IV</option>
 <option value="Aniban V">  Aniban V</option>
 <option value="Banalo">  Banalo</option>
<option value="Bayanan">  Bayanan</option>
<option value="Camposanto">  Camposanto</option>
<option value="Daang Bukid">  Daang Bukid</option>
<option value="Digman">  Digman</option>
<option value="Dulong-Bayan">  Dulong-Bayan</option>
<option value="Habay I">  Habay I</option>
<option value="Habay II">  Habay II</option>
<option value="Kaingin">  Kaingin</option>
<option value="Ligas I">  Ligas I</option>
<option value="Ligas II">  Ligas II</option>
<option value="Ligas III">  Ligas III</option>
<option value="Mabolo I">  Mabolo I</option>
<option value="Mabolo II">  Mabolo II</option>
<option value="Mabolo III">  Mabolo III</option>
<option value="Maliksi I">  Maliksi I</option>
<option value="Maliksi II">  Maliksi II</option>
<option value="Maliksi III"> Maliksi III</option>
<option value="Mambog I">  Mambog I</option>
<option value="Mambog II">  Mambog III</option>
<option value="Mambog III">  Mambog IV</option>
<option value="Mambog IV">  Mambog V</option>
<option value="Molino I">  Molino I</option>
<option value="Molino II">  Molino II</option>
<option value="Molino III">  Molino III</option>
<option value="Molino IV">  Molino IV</option>
<option value="Molino V">  Molino V</option>
<option value="Molino VI">Molino VI</option>
<option value="Molino VII">  Molino VII</option>
<option value="Niog I">  Niog I</option>
<option value="Niog II">  Niog II</option>
<option value="Niog III">  Niog III</option>
<option value="Panapaan I">  Panapaan I</option>
<option value="Panapaan II"> Panapaan II</option>
<option value="Panapaan II">  Panapaan III</option>
<option value="Panapaan IV">  Panapaan IV</option>
<option value="Panapaan V"> Panapaan V </option>
<option value="Panapaan VI">  Panapaan VI </option>
<option value="Panapaan VII">  Panapaan VII </option>
<option value="Panapaan VIII">  Panapaan VIII </option>
<option value="Real I">  Real I</option>
<option value="Real II">  Real II</option>
<option value="Salinas I">  Salinas I</option>
<option value="Salinas II">  Salinas II</option>
<option value="Salinas III">  Salinas III</option>
<option value="Salinas IV">  Salinas IV</option>
<option value="San Nicolas I">  San Nicolas I</option>
<option value="San Nicolas II">  San Nicolas II</option>
<option value="San Nicolas III">  San Nicolas III</option>
<option value="Sineguelasan">  Sineguelasan</option>
<option value="Tabing-Dagat">  Tabing-Dagat</option>
<option value="Talaba I">  Talaba I</option>
<option value="Talaba II">  Talaba II</option>
<option value="Talaba III">  Talaba III</option>
<option value="Talaba IV">  Talaba IV</option>
<option value="Talaba V">  Talaba V</option>
<option value="Talaba VI">  Talaba VI</option>
<option value="Talaba VII">  Talaba VII</option>
<option value="Queens Row Central">  Queens Row Central</option>
<option value="Queens Row East">  Queens Row East</option>
<option value="Queens Row West">  Queens Row West</option>
<option value="Zapote I">  Zapote I</option>
<option value="Zapote II">  Zapote II</option>
<option value="Zapote III">  Zapote III</option>
<option value="Zapote IV">  Zapote IV</option>
<option value="Zapote V">  Zapote V</option>
</select>

      <!-- Fullname Ends -->

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextStatus" style="position: relative; left: 50px;">Status</b></label>
      <select id="status"  name="status">
                 <option value="Normal">Normal</option>
                 <option value="Sick">Sick</option>
                 <option value="Monitoring">Monitoring</option>

             </select>

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextNote" style="position: relative; left: 50px;">Note</b></label>
      <input type="text" placeholder="Medication Note" name="note" class="note" value="<?= $_SESSION['Note'] ?>" required>

      <!-- Fullname Ends -->

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextRoomNo" style="position: relative; left: 50px;">Room No.</b></label>
      <select id="roomno" name="roomno">
                  <option value="N/A">N/A</option>
                 <option value="Room 1">Room 1</option>
                 <option value="Room 2">Room 2</option>
                 <option value="Room 3">Room 3</option>
                 <option value="Room 4">Room 4</option>
                 <option value="Room 5">Room 5</option>
                 <option value="Room 6">Room 6</option>
                 <option value="Room 7">Room 7</option>
                 <option value="Room 8">Room 8</option>
                 <option value="Room 9">Room 9</option>
             </select>

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextHeight" style="position: relative; left: 50px;">Height(cm)</b></label>
      <select  name="height">
                 <?= $_SESSION['Loopheight'] ?>
             </select>
      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextWeight" style="position: relative; left: 50px;">Weight (kg)</b></label>
      <select name="weight">
                 <?= $_SESSION['Loopweight'] ?>
             </select>

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextTemperature" style="position: relative; left: 50px;">Temperature (°C)</b></label>
      <select  name="temperature">
            <?= $_SESSION['Looptemp'] ?>
             </select>

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextBPM" style="position: relative; left: 50px;">BPM</b></label>
      <select   name="bpm">
                 <?= $_SESSION['Loopbpm'] ?>
             </select>
      <br>
       <br>

       <label for="Firstname" ><b class="TextDate" style="position: relative; left:-50px;">Month</b></label>
       <select id="month"  name="month" style="position: relative; left: -52%;top: -2px;width:10%;">
                  <option value="01">01</option>
                  <option value="02">02</option>
                  <option value="03">03</option>
                  <option value="04">04</option>
                  <option value="05">05</option>
                  <option value="06">06</option>
                  <option value="07">07</option>
                  <option value="08">08</option>
                  <option value="09">09</option>
                  <option value="10">10</option>
                  <option value="11">11</option>
                  <option value="12">12</option>
              </select>
<br>

 <label for="Firstname" ><b class="TextDate" style="position: absolute; left: 90px; top: 71.5%; left: 50%">Day</b></label>
 <select id="day"  name="day" style="position: absolute; left: 56%;top: 71.2%;width:10%;">
          <option value="01">01</option>
          <option value="02">02</option>
          <option value="03">03</option>
          <option value="04">04</option>
          <option value="05">05</option>
          <option value="06">06</option>
          <option value="07">07</option>
          <option value="08">08</option>
          <option value="09">09</option>
          <option value="10">10</option>
          <option value="11">11</option>
          <option value="12">12</option>
          <option value="13">13</option>
          <option value="14">14</option>
          <option value="15">15</option>
          <option value="16">16</option>
          <option value="17">17</option>
          <option value="18">18</option>
          <option value="19">19</option>
          <option value="20">20</option>
          <option value="21">21</option>
          <option value="22">22</option>
          <option value="23">23</option>
          <option value="24">24</option>
          <option value="25">25</option>
          <option value="26">26</option>
          <option value="27">27</option>
          <option value="28">28</option>
          <option value="29">29</option>
          <option value="30">30</option>
          <option value="31">31</option>
      </select>

<br>

 <label for="Firstname" ><b class="TextDate"  style="position:absolute; left: 68%; top: 71.5%;">Year</b></label>
 <select id="year"  name="year" style="position: absolute; left: 75%;top: 71.2%;width:10%;">
 <option value="2015">2015</option>
 <option value="2016">2016</option>
 <option value="2017">2017</option>
 <option value="2018">2018</option>
 <option value="2019">2019</option>
 <option value="2020">2020</option>
 <option value="2021">2021</option>
 <option value="2022">2022</option>
 </select>
<br>

 <br>


         <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextTime" style="position:relative; left: -50px; top: -40px;">Time</b></label>
      <input type="time" placeholder="Time of check-up" name="time" class="time" value="<?= $_SESSION['Time'] ?>" required style="position: relative;left: -37.8%;top: -40px;width:10%;">

      <br>
       <br>
      <br><br><br>




      <!-- Button Starts -->
      <input type="submit"  class="signup" name="registerbtn" value="Add"></button>
      <span>
      <button id="back" class="back"  onclick="location.href = 'http://localhost/web/staff/report.php';">Back</button>
      </span>
      <!-- Button Ends -->

    </form>
    <!-- Form Ends -->

</div>
<!-- Border Ends -->
</body>
<!-- Body Ends -->

<!-- JavaScript Starts -->
<script>

// For Date so the 18 years below cant create (Start)
var today = new Date();
var dd = today.getDate();
var mm = today.getMonth()+1; //The Months Start With 0
var yyyy = today.getFullYear();

if(dd<10)
{
  dd='0'+dd
}
if(mm<10)
{
  mm='0'+mm
}

today = yyyy-18+'-'+mm+'-'+dd;
document.getElementById("Bdate").setAttribute("max", today);
// For Date so the 18 years below cant create (END)


</script>
<!-- JavaScript Starts -->

</html>
<!-- HTML Ends -->
