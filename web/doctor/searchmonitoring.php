<?php

$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass= "Talaba07!";
$dbh = mysqli_connect($servername, $username, $dbpass,"healthmonitoring");
$output = '';


if(isset($_POST["query"]))
{
    $search = mysqli_real_escape_string($dbh, $_POST["query"]);
    $query = "
    SELECT * FROM patient
    WHERE Fullname LIKE '%".$search."%' AND Availability = 'Admitted'
    OR Status LIKE '%".$search."%' AND Availability = 'Admitted'
    OR Room_No LIKE '%".$search."%' AND Availability = 'Admitted'
    OR Year LIKE '%".$search."%' AND Availability = 'Admitted'
    OR Address LIKE '%".$search."%'AND Availability = 'Admitted'
    OR Month LIKE '%".$search."%' AND Availability = 'Admitted'
    OR Status LIKE '%".$search."%' AND Availability = 'Monitoring'
    OR Room_No LIKE '%".$search."%' AND Availability = 'Monitoring'
    OR Year LIKE '%".$search."%' AND Availability = 'Monitoring'
    OR Address LIKE '%".$search."%'AND Availability = 'Monitoring'
    OR Month LIKE '%".$search."%' AND Availability = 'Monitoring'
    ";
}
else
{
    $query = "SELECT * FROM patient WHERE Availability = 'Admitted' OR Availability = 'Monitoring' ORDER BY Year DESC, Month DESC, Day DESC  ";
}
$result = mysqli_query($dbh, $query);
if(mysqli_num_rows($result) > 0)
{
    $output .= '<div class="table-responsive">
                    <table class="table table bordered">
                        <tr>
                            <th>Patient RFID</th>
                            <th>Availability</th>
                            <th>Name</th>
                            <th>Address</th>
                            <th>Status</th>
                            <th>Room No.</th>
                            <th>Month</th>
                            <th>Day</th>
                            <th>Year</th>
                            <th>Time</th>
                            <th class="Notesss">Note</th>
                            <th>Action </th>
                        </tr>';
    while($row = mysqli_fetch_array($result))
    {
        $output .= '
            <tr>
            <form method="POST" action="monitoring.php">
                        <td>'.$row["PatientID"].'</td>
                        <td>'.$row["Availability"].'</td>
                        <td>'.$row["Fullname"].'</td>
                        <td>'.$row["Address"].'</td>
                        <td>'.$row["Status"].'</td>
                        <td>'.$row["Room_No"].'</td>
                        <td>'.$row["Month"].'</td>
                        <td>'.$row["Day"].'</td>
                        <td>'.$row["Year"].'</td>
                        <td>'.$row["Timess"].'</td>
                        <td class="Notesss">'.$row["Note"].'</td>
                        <td>
                        <input type="submit" name="update" value="'.$row["id"].'" class="updatebtn" style="background-image:url(../logo/ekis.png); background-repeat: no-repeat;
          background-size: 26px 26px; width: 28%; font-size:0px; height:30px;">
                        </td>
                        </form>
            </tr>
        ';
    }
    $_SESSION['SearchsMonitoring'] = $output;
}
else
{
    echo 'Data Not Found';
}
?>
