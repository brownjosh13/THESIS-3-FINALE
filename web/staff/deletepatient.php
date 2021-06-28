<?

if ( isset( $_POST['delete'] ) ) {
  $id = $_POST['id'];
    $patientid = $_POST['PatientID'];
  $avail = $_POST['Availability'];
  $fulln = $_POST['Fullname'];s
  $addr = $_POST['Address'];
  $status = $_POST['Status'];
  $note = $_POST['Note'];
  $room = $_POST['Room_No'];
  $month = $_POST['Month'];
  $day = $_POST['Day'];
  $year = $_POST['Year'];
  $time = $_POST['Time'];

  $sqlupdate = mysqli_query($db,"DELETE FROM patient WHERE id = '$id'");

}

?>
