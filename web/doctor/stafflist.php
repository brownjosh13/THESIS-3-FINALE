<?php
session_start();
$servername = "sabinojohnrey72888.domaincommysql.com";
$username = "talaba7";
$dbpass = "Talaba07!";
$dbh = mysqli_connect($servername, $username, $dbpass,"healthmonitoring");
$output = '';


if(isset($_POST["query"]))
{
    $search = mysqli_real_escape_string($dbh, $_POST["query"]);
    $query = "
    SELECT * FROM user
    WHERE Name LIKE '%".$search."%'
    OR Position LIKE '%".$search."%'
    OR Adress LIKE '%".$search."%'
    OR Sex'%".$search."%'

    ";
}
else
{
    $query = "SELECT * FROM accounts ORDER BY Position";
}
$result = mysqli_query($dbh, $query);
if(mysqli_num_rows($result) > 0)
{
    $output .= '<div class="table-responsive">
                    <table class="table table bordered">
                        <tr>
                            <th>Name</th>
                            <th>Username</th>
                            <th>Password</th>
                            <th>Address</th>
                            <th>Email</th>
                            <th>Address</th>
                            <th>Position</th>

                        </tr>';
    while($row = mysqli_fetch_array($result))
    {
        $output .= '
            <tr>
                <td>'.$row["name"].'</td>
                <td>'.$row["Uname"].'</td>
                <td>'.$row["Pword"].'</td>
                <td>'.$row["Address"].'</td>
                     <td>'.$row["Email"].'</td>
                      <td>'.$row["Address"].'</td>
                      <td >'.$row["Position"].'</td>

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
