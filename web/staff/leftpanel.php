
<?php
include('connection.php');

?>
<html>

<link rel="stylesheet" type="text/css" href="leftpanel.css">

<head>

</head>
<body>
  <div class="containermo">
  <nav>


  		<ul class="mcd-menu">
  			<li>
  				<a href="">
  					<i class="fa fa-home"></i>
  					<strong>Talaba VII</strong>
  					<small>HealthCenter</small>
  				</a>
  			</li>

  			<li>
  				<a href="">
  					<i class="fa fa-comments-o"></i>
  					<strong>Insert New Data</strong>
  					<small>Patient</small>
  				</a>
  				<ul>
  					<li><a href="http://healthmonitoring.bcamp2017.com/staff/addpatient.php"><i class="fa fa-globe"></i>New Patient Data</a></li>

  					<li><a href="http://healthmonitoring.bcamp2017.com/staff/kidsvaccination.php"><i class="fa fa-trophy"></i>New Infant Data</a></li>

  				</ul>
  			</li>
        <li>
          <a href="">
            <i class="fa fa-comments-o"></i>
            <strong>View Data</strong>
            <small>check</small>
          </a>
          <ul>
            <li><a href="http://healthmonitoring.bcamp2017.com/staff/patientlist.php"><i class="fa fa-globe"></i>Adults</a></li>

            <li><a href="http://healthmonitoring.bcamp2017.com/staff/infantview.php"><i class="fa fa-trophy"></i>Toddlers</a></li>
            <li><a href="http://healthmonitoring.bcamp2017.com/staff/monitoring.php"><i class="fa fa-trophy"></i>Admitted</a></li>
          </ul>
        </li>
  			<li>
  				<a href="http://healthmonitoring.bcamp2017.com/staff/messenger.php">
  					<i class="fa fa-picture-o"></i>
  					<strong>Message</strong>
  					<small>inbox</small>
  				</a>
  			</li>

  			<li class="float">
  <img src="../logo/healthlogo.png" style="width: 150px; position:relative; right: 10px;margin-top: 100px; margin-right: 0 ">
  				<a href="" class="search-mobile">
  					<i class="fa fa-search"></i>
  				</a>
  			</li>
        <form method="GET" >
        <input type="submit" value="Sign-out" class="Buttons" name="Logout" style="position:relative;left: -20px;bottom: -100px;font-size: 20px; border: 1px solid black; border-radius: 3px;">
          </form>
  		</ul>
  	</nav>
  </div>
</body>
