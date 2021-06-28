<!-- PHP Starts  -->
<?php
include('noaccount.php');
include('leftpanel.php');
include('logout.php');

$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");


$_SESSION['name'] = '';
$_SESSION['age'] = '';
$_SESSION['birthday'] = '';
$_SESSION['address'] = '';
$_SESSION['birthplace'] = '';
$_SESSION['address'] = '';
$_SESSION['weight'] = '';
$_SESSION['height'] = '';
$_SESSION['Weight'] = '';
$_SESSION['mothersname'] = '';
$_SESSION['fathersname'] = '';
$_SESSION['contact'] = '';
$_SESSION['typeofvaccine'] = '';
$_SESSION['month'] = '';
$_SESSION['day'] = '';
$_SESSION['year'] = '';
$_SESSION['nextday'] = '';
$_SESSION['nextmonth'] = '';
$_SESSION['nextyear'] = '';

for ($i=39; $i < 75;  $i++)
{
@$output .='
  <option>'.$i.'</option>
  ';
}

$_SESSION['Loopheight'] = $output;

for ($w=2; $w < 22; $w++)
{
@$output1 .='
  <option>'.$w.'</option>
  ';
}
$_SESSION['Loopweight'] = $output1;

if(isset($_GET['registerbtn']))
{
  $name = ($_GET['name']);
  $age = ($_GET['age']);
  $birthday = ($_GET['birthday']);
  $birthplace = ($_GET['birthplace']);
  $address = ($_GET['address']);
  $weight = ($_GET['weight']);
  $height = ($_GET['height']);
  $mothersname = ($_GET['mothersname']);
  $fathersname = ($_GET['fathersname']);
  $contact = ($_GET['contact']);
  $typeofvaccine = ($_GET['typeofvaccine']);
  $month = ($_GET['month']);
  $day = ($_GET['day']);
  $year = ($_GET['year']);
  $nextmonth = ($_GET['nextmonth']);
  $nextday = ($_GET['nextday']);
  $nextyear = ($_GET['nextyear']);



  $sql = "INSERT INTO kidsvaccination (name,age,birthday,birthplace,address,weight,height,mothersname,fathersname,contact,typeofvaccine,month,day,year,nextmonth,nextday,nextyear)
  VALUES('$name','$age','$birthday','$birthplace','$address','$weight','$height','$mothersname','$fathersname','$contact','$typeofvaccine',
  '$month','$day','$year','$nextmonth','$nextday','$nextyear')";
  mysqli_query($db,$sql);
  //sms start
  require_once('smsGatewayV4.php');
  $token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhZG1pbiIsImlhdCI6MTYyNDM3NTY1OCwiZXhwIjo0MTAyNDQ0ODAwLCJ1aWQiOjg5MjUyLCJyb2xlcyI6WyJST0xFX1VTRVIiXX0.znNmtDXAZEtKYGdUPRjKtYzCuatzmOobhR7Cx7gTfbQ";

  $phone_number = "09169253807";
  $phone_number2 = "09282635199";
  $phone_number3 = "09777481427";
  $message = "Baby ".$name." data inserted, Kindly register a new RFID for him/her";
  $deviceID = 124865;
  $options = [];

  $smsGateway = new SmsGateway($token);
  $result = $smsGateway->sendMessageToNumber($phone_number, $message, $deviceID, $options);
  $result2 = $smsGateway->sendMessageToNumber($phone_number2, $message, $deviceID, $options);
  $result3 = $smsGateway->sendMessageToNumber($phone_number3, $message, $deviceID, $options);

  //sms end
echo '<script>alert("New patient data inserted.")</script>';
header("location: kidsvaccination.php");
}


?>
<!-- PHP Ends  -->

<!-- HTML Starts -->
<!DOCTYPE html>

<html>
<link rel="stylesheet" type="text/css" href="kidsvaccination.css">


<head>
    <link rel="shortcut icon" type="image/x-icon" >
<title> Add New Patient </title>
</head>

<!-- Body Starts -->
<body>





<div class="Border">
  <!-- Header Starts -->
  <h1 class="Header">NEW INFANT DATA</h1>
  <p class="Header">Please fill up the field with the data needed.</p>
  <!-- Header Ends -->

  <br>
  <br>
  <!-- Forms Starts -->
    <form method="get" action="kidsvaccination.php">


      <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextFname"  style="position:relative; left: 100px">Name</b></label>
      <input type="text" placeholder="Patient fullname." name="name" class="fullname" value="<?= $_SESSION['name'] ?>" required>

      <br>
       <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextCivilStatus" style="position:relative; left: 20px">Age</b></label>
      <select id="age" name="age" style="position:relative; left: -15px; border: solid black;">
                 <option value="Newborn">Newborn</option>
                 <option value="1 & 1/2 month old">1 & 1/2 month old</option>
                 <option value="2 & 1/2 month old">2 & 1/2 month old</option>
                 <option value="3 & 1/2 month old">3 & 1/2 month old</option>
                 <option value="9 months old">9 months old</option>
                 <option value="1 year old">1 year old</option>

             </select>

        <br>
       <br>
       <label for="Firstname" ><b class="TextFname" style="position:relative; left: 100px">Birthday</b></label>
       <input type="date" placeholder="Birthday" name="birthday" class="birthday" value="<?= $_SESSION['birthday'] ?>" required style="position:relative; left: -165px;">
<br>
<br>
<label for="Firstname" ><b class="TextFname" style="position:relative; left: 98px">Birthplace</b></label>
<input type="text" placeholder="Birthplace" name="birthplace" class="fullname" value="<?= $_SESSION['birthplace'] ?>" required style="position:relative; left: -168px;">

<br>
<br>
      <label for="Firstname" ><b class="TextAddress" style="position:relative; left: 5px">Barangay</b></label>
      <select id="address" style="position:relative; left: -31px; border: 3px solid black; width: 10%;" name="address">
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


      <br>
       <br>

       <label for="Firstname" ><b class="TextHeight" style="position:relative; left: 5px" >Weight(kg)</b></label>
       <select  style="position:relative; left: -30px; border: 3px solid black; width: 10%;" name="weight">
                  <?= $_SESSION['Loopweight'] ?>
              </select>
<br>
<br>
              <label for="Firstname" ><b class="TextHeight"  style="position:relative; left: 5px">Height(cm)</b></label>
              <select  style="position:relative; left: -30px; border: 3px solid black; width: 10%;" name="height">
                         <?= $_SESSION['Loopheight'] ?>
                     </select>
    <br>
    <br>

       <!-- Fullname Starts -->
      <label for="Firstname" ><b class="TextNote" style="position:relative; left: 98px">Mothers Name</b></label>
      <input type="text" placeholder="Medication Note" name="mothersname" class="note" value="<?= $_SESSION['mothersname'] ?>" required>
       <br>
       <br>

       <label for="Firstname" ><b class="TextNote"style="position:relative; left: 98px">Fathers Name</b></label>
       <input type="text" placeholder="Medication Note" name="fathersname" class="note" value="<?= $_SESSION['fathersname'] ?>" required>
        <br>
        <br>

        <label for="Firstname" ><b class="TextNote" style="position:relative; left: 98px">Contact</b></label>
        <input type="text" placeholder="Medication Note" name="contact" class="note" value="<?= $_SESSION['contact'] ?>" required>
         <br>
         <br>
         <br>

         <label for="Firstname" ><b class="TextNote" style="position:relative; left: -210px; font-family: lucida console;">Type of Vaccine</b></label>
         <br>

         <select id="vacc" style="position:relative; left: -215px;bottom: -10px; border: 3px solid black; width: 18%;" name="typeofvaccine">
                    <option value="BCG">BCG</option>
                    <option value="HEPATITIS B">HEPATITIS B</option>
                    <option value="DPT-Hep B-HiB">DPT-Hep B-HiB</option>
                    <option value="OPV">OPV</option>
                    <option value="PCV">PCV</option>
                    <option value="MMR">MMR</option>

                </select>
<br>
<br>
                <label for="Firstname" ><b class="TextDate" style="position:relative; left:-160px">Month</b></label>
                <select id="month" style="position:relative; left: -285px; border: 3px solid black; width: 10%;" name="month">
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

               <label for="Firstname" ><b class="TextDate"  style="position:relative; left:-160px">Day</b></label>
               <select id="day" style="position:relative; left: -285px; border: 3px solid black; width: 10%;" name="day">
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

               <label for="Firstname" ><b class="TextDate"  style="position:relative; left:-160px">Year</b></label>
               <select id="year"  style="position:relative; left: -285px; border: 3px solid black; width: 10%" name="year">
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

               <h2 style="position:absolute; bottom: 255px; left: 495px; font-family: Lucida Console;"> Next Vaccine Schedule </h2>
               <br>
               <label for="Firstname" ><b class="TextDate" style="position:absolute; bottom: 220px; left: 550px">Month</b></label>
               <select id="month" style="position:absolute; left: 630px; bottom: 220px; border: 3px solid black; width: 10%;" name="nextmonth">
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

         <label for="Firstname" ><b class="TextDate"  style="position:absolute; bottom: 190px; left: 550px">Day</b></label>
         <select id="day" style="position:absolute; left: 630px; bottom: 190px; border: 3px solid black; width: 10%;" name="nextday">
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

         <label for="Firstname" ><b class="TextDate" style="position:absolute; bottom: 160px; left: 550px">Year</b></label>
         <select id="year"  style="position:absolute; left: 630px; bottom: 160px; border: 3px solid black; width: 10%" name="nextyear">
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



      <!-- Button Starts -->
      <input type="submit"  class="signup" name="registerbtn" value="Add"></button>
      <span>
      <button id="back" class="back"  onclick="location.href = 'http://healthmonitoring.bcamp2017.com/staff/report.php';">Back</button>
      </span>
      <!-- Button Ends -->

    </form>
    <!-- Form Ends -->

</div>
<!-- Border Ends -->
</body>
<!-- Body Ends -->

<!-- JavaScript Starts -->
