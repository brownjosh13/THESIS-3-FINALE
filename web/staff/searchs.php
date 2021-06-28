<?php

$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass = "Talaba07!"
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
    OR Month LIKE '%".$search."%'
    OR Address LIKE '%".$search."%'
    ";
}
else
{
    $query = "SELECT * FROM patient ORDER BY Year DESC, Month DESC, Day Desc";
}
$result = mysqli_query($dbh, $query);
if(mysqli_num_rows($result) > 0)
{
    $output .= '<div class="table-responsive">
                    <table class="table table bordered" style="	border: 1px solid black;">
                        <tr>
                            <th style="	padding: 8;">Availability</th>
                            <th style="	padding: 4">Name</th>
                            <th style="	padding: 4;">Age</th>
                            <th style="	padding: 4;">Civil Status</th>
                            <th style="	padding: 4;">Address</th>
                            <th style="	padding: 4;">Status</th>
                            <th class="Notesss" style="	padding: 4;">Note</th>
                            <th style="	padding: 4;">Room No.</th>
                            <th style="	padding: 4;">Temperature</th>
                            <th style="	padding: 4;">BPM</th>
                            <th style="	padding: 4;">Month</th>
                            <th style="	padding: 4;">Day</th>
                            <th style="	padding: 4;">Year</th>
                            <th style="	padding: 4;">Time</th>
                            <th style="	padding: 8  ;">Action </th>
                        </tr>';

    while($row = mysqli_fetch_array($result))
    {
        $output .= '

                <tr>
                <form method="POST">
                <td name="avail">'.$row["Availability"].'</td>
                <td name="fname">'.$row["Fullname"].'</td>
                <td name="age">'.$row["Age"].'</td>
                <td name="civil">'.$row["Civil_Status"].'</td>
                <td name="address">'.$row["Address"].'</td>
                <td name="status">'.$row["Status"].'</td>
                <td class="Notesss" name="notes">'.$row["Note"].'</td>
                <td name="roomno">'.$row["Room_No"].'</td>
                <td name="temp">'.$row["Temperature"].'</td>
                <td name="bpm">'.$row["BPM"].'</td>
                <td name="month">'.$row["Month"].'</td>
                <td name="day">'.$row["Day"].'</td>
                <td name="year">'.$row["Year"].'</td>
                <td name="time">'.$row["Timess"].'</td>
                <td>
                <input type="submit" name="editbtn" value="'.$row["id"].'" class="edit-btn" style="background-image:url(../img/edit.png); background-repeat: no-repeat;
  background-size: 26px 26px; width: 45%; font-size:0px; height:30px;">
                </td>
                  </form>
                </tr>

        ';


}

       $_SESSION['Searchs'] = $output;

}


?>
