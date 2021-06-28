<?php

$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass = "Talaba07!";
$dbh = mysqli_connect($servername, $username,$dbpass, "healthmonitoring");

if (isset($_POST['editbtn']))
{

  $IDmo = ($_POST['editbtn']);
  $query = "SELECT * FROM patient WHERE id = '$IDmo'";
  $result = mysqli_query($dbh, $query);
if(mysqli_num_rows($result) > 0)
{

  while($row = mysqli_fetch_array($result))
  {


        $_SESSION['id'] = $row['id'];
        $_SESSION['avail'] = $row["Availability"];
        $_SESSION['fulln'] = $row["Fullname"];
        $_SESSION['age'] = $row["Age"];
        $_SESSION['cs'] = $row["Civil_Status"];
        $_SESSION['addr'] = $row["Address"];
        $_SESSION['status'] = $row["Status"];
        $_SESSION['note'] = $row["Note"];
        $_SESSION['room'] = $row["Room_No"];
        $_SESSION['temp'] = $row["Temperature"];
        $_SESSION['bpm'] =$row["BPM"];
        $_SESSION['month'] = $row["Month"];
        $_SESSION['day'] = $row["Day"];
        $_SESSION['year'] = $row["Year"];
        $_SESSION['time'] = $row["Timess"];

}

}

}
?>
