<?php
session_start();

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
    WHERE Fullname LIKE '%".$search."%'
    OR Status LIKE '%".$search."%'
    OR Room_No LIKE '%".$search."%'
    OR Year LIKE '%".$search."%'
    OR Month LIKE '%".$search."%'
    OR Address LIKE '%".$search."%'
    ";
}
else
{
    $query = "SELECT * FROM patient ORDER BY Year DESC, Month DESC, Day DESC  ";
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

                        </tr>';
    while($row = mysqli_fetch_array($result))
    {
        $output .= '
            <tr>
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
            </tr>
        ';
    }
    echo $output;
}
else
{
    echo 'Data Not Found';
}
?>
