<?php

$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass = "Talaba07!";
$dbh =mysqli_connect($servername, $username, $dbpass, "healthmonitoring");



if ( isset( $_POST['update'] ) ) {
  $id = $_POST['id'];
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


  $sqlupdate = mysqli_query($dbh,"UPDATE patient SET Availability='$avail', Fullname='$fulln', Age='$age', Civil_Status='$cs', Address='$addr', Status='$status', Note='$note',
  Room_No='$room', Temperature='$temp', BPM='$bpm', Month='$month',Day='$day',Year='$year', Timess='$time' WHERE id = $id");





}

 ?>
