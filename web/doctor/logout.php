<?php

$db = mysqli_connect("sabinojohnrey72888.domaincommysql.com", "talaba7", "Talaba07!", "healthmonitoring");


if (isset($_GET["Logout"]))
{
  session_destroy();
  header("Location: http://healthmonitoring.bcamp2017.com/index.php");
}



?>
