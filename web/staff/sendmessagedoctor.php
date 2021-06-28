<?php

$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");


$output1 = '';
$_SESSION['Username'] = 'George';
$Uname = $_SESSION['Username'];
$query1 = "SELECT * FROM messages WHERE Sender = '$Uname' OR Receiver = '$Uname' "  ;
$result1 = mysqli_query($db, $query1);
if(mysqli_num_rows($result1) > 0)
{
		//Getting the password to compare it if it is the password of the account
	while ($row = mysqli_fetch_array($result1))
  	 {
    	$Sender = $row['Sender'];
    	$Receiver = $row['Receiver'];
    	if ($Uname == $Sender)
    	{
    	$output1 .= '
		<div class="me">
			<h4 class="me-h4">'.$row["Message"].'</h4>
		</div>
        '
        ;
        $_SESSION['Message']  = $output1;
    	}
    	else if ($Uname == $Receiver)
    	{
    	$output1 .= '
        <div class="Client">
			<img src="../logo/healthlogo.png">
			<h4>'.$row["Message"].'</h4>
		</div>
        '
        ;
        $_SESSION['Message']  = $output1;
    	}
    }
}
else
{
}

?>
