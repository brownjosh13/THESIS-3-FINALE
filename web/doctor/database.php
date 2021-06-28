<?php
$connection = mysqli_connect("localhost","root","");
$db = mysqli_select_db($connection, 'healthmonitoring');


if(isset($_POST['insertdata']))
{

	$name = $_POST['name'];
	$civilstatus = $_POST['civilstatus'];
	$address = $_POST['address'];
	$status = $_POST['status'];
	$note = $_POST['note'];
	$roomno = $_POST['roomno'];
	$height = $_POST['height'];
	$weight = $_POST['weight'];
	$temperature = $_POST['temperature'];
	$bpm = $_POST['bpm'];
	$date = $_POST['date'];
	$time = $_POST['time'];
	$patientid = $_POST['patientid'];

	$query = "INSERT INTO patient (Fullname,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Date,Time,PatientID) VALUES ('$name','$civilstatus','$address','$status','$note','$roomno','$height','$weight','$temperature','$bpm',
	'$date','$time','$patientid')";
	$query_run = mysqli_query($connection,$query);

	if($query_run)
	{
		echo '<script> alert ("Data Saved"); </script>';
		header('location: doctordashboard.php');
	}
	else
	{
		echo '<script> alert("Data not saved");</script>';
	}
}
?>