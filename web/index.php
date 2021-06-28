
<?php
// Session start to get the universal variable that been saved
session_start();

$_SESSION['MESSAGESSSS'] = '';
//Connection of the database
$db = mysqli_connect('sabinojohnrey72888.domaincommysql.com', 'talaba7', 'Talaba07!', 'healthmonitoring');

if(isset($_GET['login']))
{
	//Inputting variable that we get from the html
	$name = ($_GET['name']);
	$password = ($_GET['password']);

	//Query for Company Accounts
	$queryCompanyUser = mysqli_query($db,"SELECT Uname FROM accounts WHERE Uname='$name'");

	$queryCompanyPass = mysqli_query($db,"SELECT Pword FROM accounts WHERE Uname='$name'");

	//Query for Admin
	$queryAdminUser = mysqli_query($db,"SELECT Uname FROM doctor WHERE Uname='$name'");
	$queryAdminPass = mysqli_query($db,"SELECT Pword FROM doctor WHERE Uname='$name'");

	$_SESSION['Username'] = ($_GET['name']);

	// Checking the account if existing for Client Account
	if (mysqli_num_rows($queryCompanyUser) != 0)
	{

		while ($row = $queryCompanyPass->fetch_assoc())
  	 	{
  	 		$Pword = $row['Pword'];
  	 		// if the password that user type and the data in the database it will enter in client profile
  	 		if ($password  == $Pword)
  	 		{


  	 			header("Location: http://healthmonitoring.bcamp2017.com/staff/Patientlist.php");
  	 		}
  	 		//If not equal
  	 		else
  	 		{

  	 			 $_SESSION['MESSAGESSSS'] = "Wrong Credentials";
  	 			$_SESSION['Username'] = '';
  	 		}
		}
	}

  	//Querying Admin
  	elseif (mysqli_num_rows($queryAdminUser) != 0)
    {
      //Querying the Password of the user
      while ($row = $queryAdminPass->fetch_assoc())
      {
        $Password = $row['Pword'];
        // If the two password are equal it will send the user into the location of profile
        if ($password  == $password)
        {

          header("Location: http://healthmonitoring.bcamp2017.com/doctor/Patientlist.php");
        }
        // if not equal
        else
        {

          $_SESSION['MESSAGESSSS'] = "Wrong Credentials";
          $_SESSION['Uname'] = '';
        }
    }
    }
    else
    {

          $_SESSION['MESSAGESSSS'] = "Wrong Credentials";
          $_SESSION['Uname'] = '';
    }

}
// End of funtions when you click the submit button
?>


<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>HealthCenter</title>

	<link rel="stylesheet" type="text/css" href="../web/fontawesome-free-5.15.1-web/css/all.css">
	<link rel="stylesheet" type="text/css" href="animated.css">
</head>
<body>
	<div class="main-inner">
		<div class="photo">
			<img src="Logo/healthlogo.png" >
		</div>

		<div class="login-form">
			<h1>Welcome to Talaba VII <br> Barangay HealthCenter!</h1>

			<form class="input-form" method="GET">


				<div class="input-login">
					<input type="text" class="input" name="name" placeholder="Username" autocomplete="off" required>
					<span class="focus-input"></span>
					<span class="icon-input">
						<i class="fas fa-user" aria-hidden="true"></i>
					</span>
				</div>
				<div class="input-login">
					<input type="password" class="input" name="password" placeholder="Password" autocomplete="off" required>
					<span class="focus-input"></span>
					<span class="icon-input">
						<i class="fa fa-lock" aria-hidden="true"></i>

					</span>

				</div>
					<input type="submit" class="login-form-btn" name="login" value="Login">
				</form>
				<div class="bacoorss">
				<img src="Logo/bacoor.jpeg">
				</div>
				<div class="alaga">
					<img src="Logo/alaga.png">
				</div>


		</div>
	</div>

</body>
</html>
<script type="text/javascript">
$(document).on('click', '.formsubmitbutton', function(e) {
    e.preventDefault();
    $.ajax({
        type: "POST",
        url: $(".form").attr('action'),
        data: $(".form").serialize(),
        success: function(response) {
             if (response === "success") {
                  window.reload;
             } else {
                   alert("invalid username/password.  Please try again");
             }
        }
    });
});
</script>
