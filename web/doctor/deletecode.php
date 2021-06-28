<?php

$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");

if(isset($_POST['deletedata']))
{
	$id = $_POST['delete_id'];

	$query = "DELETE FROM patient WHERE id='$id'";
	$query_run = mysqli_query($connection, $query);

	if($query_run)
	{
		echo '<script> alert ("Data deleted."); </script>';
		header("location: doctordashboard.php");
	}
	else
	{
		echo '<script>alert("Data not deleted"); </script>';
	}
}

?>
