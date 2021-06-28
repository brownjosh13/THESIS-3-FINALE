<?php

session_start();
if ($_SESSION['Username'] == "")
{
  header("Location: http://healthmonitoring.bcamp2017.com/index.php");
}
?>
