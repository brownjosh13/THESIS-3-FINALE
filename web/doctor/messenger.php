<?php

include('noaccount.php');
include('logout.php');

include('sendmessagedoctor.php');
include('sendmessage.php');
?>
<!DOCTYPE html>
<html>
<link rel="stylesheet" type="text/css" href="messenger.css">
<head>
	<title></title>
</head>
<body>

	<div class="topnav">

			<h1>Message</h1>
	</div>
  <nav class="nav__cont" style="background-color:#6E4201;">
  <ul class="navv">
    <br>
    <img src="../logo/healthlogo.png" style="width: 150px; position:relative; margin-top: 20px; margin-right: 50px;">
    <br>
    <br>
    <br>
    <br>
     <li class="nav__items ">
      <img src="../Logo/message.png" class="Logo" style="top: 25px;">
      <a href="http://healthmonitoring.bcamp2017.com/doctor/messenger.php"style="position:relative; top: -3px;left: 10px">Message</a>
    </li>
<br>
    <li class="nav__items ">
      <img src="../Logo/patient.png" class="Logo" style="top: 18px;" >
      <a href="http://healthmonitoring.bcamp2017.com/doctor/patientlist.php" style="position:relative;top: -15px; left: 10px">Patient List</a>
    </li>
    <br>
    <li class="nav__items ">
      <img src="../Logo/babylist.png" class="Logo" style="top: 27px;" >
      <a href="http://healthmonitoring.bcamp2017.com/doctor/infantview.php" style="position:relative;top: -15px; left: 10px">Toddlers</a>
    </li>
    <br>
    <li class="nav__items">
      <img src="../Logo/admit.png" class="Logo">
      <a href="http://healthmonitoring.bcamp2017.com/doctor/monitoring.php" style="position:relative;top: -30px; left: 10px">Admitted</a>
    </li>
    <br>

<br>

    <br>
  </ul>
  <form method="GET">
  <input type="submit" value="Sign-out" class="Buttons" name="Logout" style="font-size: 20px; border: 1px solid black; border-radius: 3px; position:absolute; bottom: 8px; left: 75px;">
    </form>
</nav>
		<div class="container">
			<!-- Content ng inbox -->
			<div class="msg-inbox">
				<img src="../Logo/message.png" class="admin-img">
				<h1>Inbox</h1>
				<button>Compose</button>
				<br>
				<input type="text" placeholder="Search Name" name="">
				<div class="inbox-row">
					<img src="../logo/healthlogo.png" class="client-dp">
					<a href="">George</a>
				</div>


			</div>
			<!-- End ng content sa inbox -->

			<!-- bottom part ng content sa message -->
			<div class="textarea-sendbtn">
				<form  method="POST">
				<input type="text" placeholder="Type a message..." name="MessageBody">
				<button type="submit" name="Submit_Message">Send</button>
				</form>
			</div>
			<!-- End ng part ng textarea at send button -->
			<!-- Laman ng inbox or messages ng client -->
			<div class="messages">
				<div class="message-content">
					<?= $_SESSION['Message'] ?>
				</div>
			</div>
			<!-- end ng laman -->
			<!-- message info lang tropa -->
			<div class="msg-info">
				<div class="upper-content">
					<img src="../logo/healthlogo.png" class="client-icon">

					<h1 class="client-name">George</h1>

				</div>

			</div>
			<!-- end ng message info tropa -->
		</div>


</body>
</html>
