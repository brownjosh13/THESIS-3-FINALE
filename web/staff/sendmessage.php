<?php
date_default_timezone_set('Asia/Manila');
$Time = (date("H:i:s"));
$Date = (date("Y/m/d"));

include('connection.php');

if(isset($_POST['Submit_Message']))
{
$Uname = $_SESSION['Username'];
$MessageBody = ($_POST['MessageBody']);

$sql = "INSERT INTO messages(Sender, Message, Receiver, Dates, Timess) VALUES('$Uname', '$MessageBody', 'Staff1' , '$Date' , '$Time')";
mysqli_query($db,$sql);
// History

header("Location: http://healthmonitoring.bcamp2017.com/staff/messenger.php");
}
?>
