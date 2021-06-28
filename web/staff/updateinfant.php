<?php

$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass = "Talaba07!";
$dbh = mysqli_connect($servername, $username, $dbpass, "healthmonitoring");

if (isset($_POST['Editbutton']))
{

  $IDmos = ($_POST['Editbutton']);
  $query1 = "SELECT * FROM kidsvaccination WHERE kidID = '$IDmos'";
  $result1 = mysqli_query($dbh, $query1);
if(mysqli_num_rows($result1) > 0)
{

  while($row = mysqli_fetch_array($result1))
  {

        $_SESSION['kidID'] = $row['kidID'];
        $_SESSION['name'] = $row['name'];
        $_SESSION['age'] = $row['age'];
        $_SESSION['weight'] = $row['weight'];
        $_SESSION['height'] = $row['height'];
        $_SESSION['typeofvaccine'] = $row['typeofvaccine'];
        $_SESSION['month'] = $row['month'];
        $_SESSION['day'] = $row['day'];
        $_SESSION['year'] = $row['year'];
        $_SESSION['nextMonth'] = $row['nextMonth'];
        $_SESSION['nextDay'] = $row['nextDay'];
        $_SESSION['nextYear'] = $row['nextYear'];

}

}

}
?>
