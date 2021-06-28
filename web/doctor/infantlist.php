<?php



$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass ="Talaba07!";
$dbh = mysqli_connect($servername, $username, $dbpass,"healthmonitoring");
$output = '';



if(isset($_POST["query"]))
{
    $search = mysqli_real_escape_string($dbh, $_POST["query"]);
    $query = "
    SELECT * FROM kidsvaccination
    WHERE name LIKE '%".$search."%'
    OR address LIKE '%".$search."%'
    OR age LIKE '%".$search."%'
    OR nextmonth '%".$search."%'
    OR month LIKE '%".$search."%'
    ";
}
else
{
    $query = "SELECT * FROM kidsvaccination ORDER BY Year DESC, Month DESC, Day Desc";
}
$result = mysqli_query($dbh, $query);
if(mysqli_num_rows($result) > 0)
{
    $output .= '<div class="table-responsive">
                    <table class="table table bordered" style="	border: 1px solid black;">
                        <tr>
                            <th>Name</th>
                            <th style="">Age</th>
                            <th style="">Birthday</th>
                            <th style="">Address</th>
                            <th >Weight</th>
                            <th >Height</th>
                            <th >Vaccine</th>
                            <th >Month of Vaccination</th>
                            <th >Day</th>
                            <th>Year</th>
                            <th >Next Vaccination</th>
                            <th >Day</th>
                            <th>Year</th>


                        </tr>';

    while($row = mysqli_fetch_array($result))
    {
        $output .= '

                <tr>

                <td name="name">'.$row["name"].'</td>
                <td name="age">'.$row["age"].'</td>
                <td name="birthday">'.$row["birthday"].'</td>
                <td name="address">'.$row["address"].'</td>
                <td name="weight">'.$row["weight"].'</td>
                <td name="height">'.$row["height"].'</td>
                <td name="typeofvaccine">'.$row["typeofvaccine"].'</td>
                <td name="month">'.$row["month"].'</td>
                <td name="day">'.$row["day"].'</td>
                <td name="year">'.$row["year"].'</td>
                <td name="nextmonth">'.$row["nextMonth"].'</td>
                <td name="nextday">'.$row["nextDay"].'</td>
                <td name="nextyear">'.$row["nextYear"].'</td>


                </tr>


        ';


}

       $_SESSION['InfantList'] = $output;

}


?>
