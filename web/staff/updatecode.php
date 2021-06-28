<?php
	
$connection = mysqli_connect("localhost","root","");
$db = mysqli_select_db($connection, 'healthmonitoring');

$id = 0;
	if(isset($_POST['updatedata']))

	{
		$id = $_POST['update_id'];

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
	
		
		$query = "UPDATE patient SET 
		Fullname='$name', 
		Civil_Status='$civilstatus',
		Address='$address', 
		Status='$status', 
		Note='$note',
		Room_No='$roomno', 
		Height='$height',
		Weight='$weight',
		Temperature='$temperature',
		BPM='$bpm',
		Date='$date',
		Time='$time' 
		WHERE id=$id";
		$query_run = mysqli_query($connection,$query);

		if($query_run)
		{
			echo '<script> alert ("Data updated"); </script>';
			header("location: staffinsertdata.php");
		}
		else
		{
			echo '<script> alert("Data not updated"); </script>';
		}
	}


?>