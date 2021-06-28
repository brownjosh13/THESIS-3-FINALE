<?php

include('noaccount.php');
include('logout.php');
include('leftpanel.php');
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


</nav>
		<div class="container">
			<!-- Content ng inbox -->
			<div class="msg-inbox">
				<img src="../Logo/message.png" class="admin-img">
				<h1>Inbox</h1>

				<br>
				<input type="text" placeholder="Search Name" name="">
				<div class="inbox-row">
					<img src="../logo/healthlogo.png" class="client-dp">
					<a href="">Doctor</a>
				</div>

			</div>
			<!-- End ng content sa inbox -->

			<!-- bottom part ng content sa message -->
			<div class="textarea-sendbtn">
				<form method="POST">
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

					<h1 class="client-name">Doctor</h1>

				</div>

			</div>
			<!-- end ng message info tropa -->
		</div>
		<form method="GET" >
		<input type="submit" value="Sign-out" class="Buttons" name="Logout" style="position:relative;left: -600px;bottom: 250px;font-size: 20px; border: 1px solid black; border-radius: 3px; width: 5%;">
			</form>

</body>
</html>
