<?php
date_default_timezone_set('Asia/Manila');
$Time = (date("H:i:s"));
$Date = (date("Y/m/d"));




if(isset($_POST['Submit_Message']))
{
$Uname = $_SESSION['Username'];
$MessageBody = ($_POST['MessageBody']);

$sql = "INSERT INTO messages(Sender, Message, Receiver, Dates, Timess) VALUES('$Uname', '$MessageBody', '$Receiver' , '$Date' , '$Time')";
mysqli_query($db,$sql);

header("Location: http://healthmonitoring.bcamp2017.com/doctor/messenger.php");
}
?>
