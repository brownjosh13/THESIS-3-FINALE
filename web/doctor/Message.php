<?php 
session_start();
 $_SESSION['Inboxs']  = "";
 $_SESSION['Message'] = "";
 $_SESSION['Receive'] ="";
 $_SESSION['Sents']  = "";
 $Uname = $_SESSION['Username'];
$db = mysqli_connect("localhost", "root", "", "healthmonitoring");


$Sender = '';
$Messages = '';

if(isset($_GET['ButtonSend']))
{
date_default_timezone_set('Asia/Manila');
	$Sender = ($_GET['Receiver']);
	$Messages = ($_GET['Messages']);
	$Uname = $_SESSION['Username'];
	$Time = ( date("H:i:s"));
	$Date = ( date("Y/m/d") );

$query = mysqli_query($db,"SELECT Uname FROM accounts WHERE Uname='$Sender'");

if (mysqli_num_rows($query) != 0)
    {
	$sql = "INSERT INTO Messages(Sender, Message, Receiver, Dates, Timess) VALUES('$Uname', '$Messages', '$Sender' , '$Date' , '$Time')";
	mysqli_query($db,$sql);
         

	}
	else
	{
	}
}


$output = '';
$output1 = "";

$output1 .= '
        <span class="Rowss">
        Message
        </span>
        <span class="Rowss">
        Time
        </span>
        <span class="Rowss">
        Date
        </span>
        <br>
        <br>
        
        '
        ;

$query1 = "SELECT * FROM messages WHERE Sender = '$Uname' ORDER By Dates DESC"  ;
$result11 = mysqli_query($db, $query1);
if(mysqli_num_rows($result11) > 0)
{
    while($row1 =mysqli_fetch_array($result11))
    {

		

        $output1 .= '
        <form method="Get" action="Message.php">
        <span data-titles="Delete MessageID: '.$row1["MessageID"].' ">
       	<input type="submit" class ="Checkbox" value ="'.$row1["MessageID"].'" name="DeleteBox" >
       	</span>	
        <span data-title="Message: '.$row1["Message"].'">
        <span class="Open"> Message </span> 
        <input type="submit" class="Rowsss" value= "'.$row1["MessageID"].'" name="SearchMessageID" >
        </span>
        <span class="Rows1">
        '.$row1["Timess"].'
        </span>
        <span class="Rows1">
        '.$row1["Dates"].'
        </span>
        <br>
        </form>
        '
        ;
        $_SESSION['Sents']  = $output1;
    }      
}
else
{
}
	if(isset($_GET['SearchMessageID']))
	{
		$Text = ($_GET['SearchMessageID']);
		$Message = mysqli_query($db,"SELECT Message FROM messages WHERE MessageID='$Text'"); 
		$Sender = mysqli_query($db,"SELECT Sender FROM messages WHERE MessageID='$Text'"); 
		$Receiver = mysqli_query($db,"SELECT Receiver FROM messages WHERE MessageID='$Text'"); 
		$Time = mysqli_query($db,"SELECT Timess FROM messages WHERE MessageID='$Text'"); 
		$Date = mysqli_query($db,"SELECT Dates FROM messages WHERE MessageID='$Text'"); 
		while ($row = $Message->fetch_assoc())
		{
			while ($row1 = $Sender->fetch_assoc()) 
			{
				while ($row2 = $Receiver->fetch_assoc()) 
				{
					while ($row3 = $Date->fetch_assoc()) 
					{
						while ($row4 = $Time->fetch_assoc()) 
						{
		   					$_SESSION['Message']  =
		   					' 
		   					<span class = "TextBold">
		   					Sender: ' .$row1['Sender']. '
		   					</span>
		   					<br>
		   					<br>
		   					<span class = "TextMessage">
		   					&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp'.$row['Message'].'
		   					</span>
		   					<br>
		   					<br>
		   					<span class = "TextBold">
		   					Receiver: ' .$row2['Receiver']. '
		   					</span>
		   					<br>
		   					<span class = "TextBold">
		   					Time: ' .$row3['Dates']. '
		   					</span>
		   					<br>
		   					<span class = "TextBold">
		   					Date: ' .$row4['Timess']. '
		   					</span>
		   					';
            				
   						}
   					}
   				}
   			}
		}
	}
	if(isset($_GET['DeleteBox']))
	{
		$DeleteBtn = ($_GET['DeleteBox']);
		$Message = mysqli_query($db,"SELECT Message FROM messages WHERE MessageID='$DeleteBtn'"); 
		$Sender = mysqli_query($db,"SELECT Sender FROM messages WHERE MessageID='$DeleteBtn'"); 
		$Receiver = mysqli_query($db,"SELECT Receiver FROM messages WHERE MessageID='$DeleteBtn'"); 
		$Time = mysqli_query($db,"SELECT Timess FROM messages WHERE MessageID='$DeleteBtn'"); 
		$Date = mysqli_query($db,"SELECT Dates FROM messages WHERE MessageID='$DeleteBtn'"); 
		while ($row = $Message->fetch_assoc())
		{
			while ($row1 = $Sender->fetch_assoc()) 
			{
				while ($row2 = $Receiver->fetch_assoc()) 
				{
					while ($row3 = $Date->fetch_assoc()) 
					{
						while ($row4 = $Time->fetch_assoc()) 
						{
							$Message = $row['Message'];
							$Sender = $row1['Sender'];
							$Receiver = $row2['Receiver'];
							$Dates = $row3['Dates'];
							$Time = $row4['Timess'];
					
							
							$sqlDelete = " DELETE FROM messages WHERE MessageID = '$DeleteBtn'";
							mysqli_query($db,$sqlDelete);
							header("Location: http://localhost/web/doctor/message.php");


				          

						}
					}
				}
			}
		}
	}


if (isset($_GET['Submitbox'])) 
{
$output .= '
        <span class="Rowss">
        MessageID
        </span>
        <span class="Rowss">
        Time
        </span>
        <span class="Rowss">
        Date
        </span>
        <span class="Rowss">
        Sender
        </span>
        <br>
        <br>
        
        '
        ;
$Searchbox = $_GET['Searchbox'];

$query = "SELECT * FROM messages WHERE Receiver = '$Uname' and Sender = '$Searchbox' ORDER By Dates DESC" ;
$result = mysqli_query($db, $query);
if(mysqli_num_rows($result) > 0)
{
    while($row =mysqli_fetch_array($result))
    {

	
        $output .= '

        <form method="Get" action="Message.php">
        <span data-titles="Delete MessageID: '.$row["MessageID"].' ">
        <input type="submit" class ="Checkbox" value ="'.$row["MessageID"].'" name="DeleteBox" >
        </span>
        <span data-title="Message: '.$row["Message"].'">
        <span class ="Open"> Message </span>
        <input type="submit" class="Rowsss" value= "'.$row["MessageID"].'" name="SearchMessageID" >
        </span>
        <span class="Rows1">
        '.$row["Timess"].'
        </span>
        <span class="Rows1">
        '.$row["Dates"].'
        </span>
        <span class="Rows1">
        '.$row["Sender"].'
        </span>
        <br>
        </form>
        '
        ;
        $_SESSION['Receive']  = $output;



    }   
}
else
{

$query = "SELECT * FROM messages WHERE Receiver = '$Uname' ORDER By Dates DESC"  ;
$result = mysqli_query($db, $query);
if(mysqli_num_rows($result) > 0)
{
    while($row =mysqli_fetch_array($result))
    {

	
        $output .= '

        <form method="Get" action="Message.php">
        <span data-titles="Delete MessageID: '.$row["MessageID"].' ">
        <input type="submit" class ="Checkbox" value ="'.$row["MessageID"].'" name="DeleteBox" >
        </span>
        <span data-title="Message: '.$row["Message"].'">
        <span class ="Open"> Message </span>
        <input type="submit" class="Rowsss" value= "'.$row["MessageID"].'" name="SearchMessageID" >
        </span>
        <span class="Rows1">
        '.$row["Timess"].'
        </span>
        <span class="Rows1">
        '.$row["Dates"].'
        </span>
        <span class="Rows1">
        '.$row["Sender"].'
        </span>
        <br>
        </form>
        '
        ;
        $_SESSION['Receive']  = $output;
    }   
}
else
{
}
}
}
else
{
	$output .= '
        <span class="Rowss">
        MessageID
        </span>
        <span class="Rowss">
        Time
        </span>
        <span class="Rowss">
        Date
        </span>
        <span class="Rowss">
        Sender
        </span>
        <br>
        <br>
        
        '
        ;


$query = "SELECT * FROM messages WHERE Receiver = '$Uname' ORDER By Dates DESC"  ;
$result = mysqli_query($db, $query);
if(mysqli_num_rows($result) > 0)
{
    while($row =mysqli_fetch_array($result))
    {

	
        $output .= '

        <form method="Get" action="Message.php">
        <span data-titles="Delete MessageID: '.$row["MessageID"].' ">
        <input type="submit" class ="Checkbox" value ="'.$row["MessageID"].'" name="DeleteBox" >
        </span>
        <span data-title="Message: '.$row["Message"].'">
        <span class ="Open"> Message </span>
        <input type="submit" class="Rowsss" value= "'.$row["MessageID"].'" name="SearchMessageID" >
        </span>
        <span class="Rows1">
        '.$row["Timess"].'
        </span>
        <span class="Rows1">
        '.$row["Dates"].'
        </span>
        <span class="Rows1">
        '.$row["Sender"].'
        </span>
        <br>
        </form>
        '
        ;
        $_SESSION['Receive']  = $output;
    }   
}
else
{
}
}	




 ?>
<!DOCTYPE html>
<html>
<link rel="stylesheet" type="text/css" href="Message.css">
<link rel="shortcut icon" type="image/x-icon" href="../../../Admin/AdminHomepage/Admin.jpg">
<head>
<title>Message</title>
</head>
<body>
    <div class="bacoor">
        <img src="../logo/bacoor.jpeg">
        <div class="header">
        <h1> TALABA VII HEALTH CENTER </h1>
      </div>
      <div class="bacoor1">
        <img src="../logo/healthlogo.png">
    </div>
    </div>
	<div class="Border">
		<div class="topborder">
			<h1 class="TextInbox">Inbox</h1>
			<form method="get">
                
			<input type="text" name="Searchbox" class="Searchbox" placeholder="Search here....">
			<input type="submit" name="Submitbox" class="Submitbox" value="Search">
			</form>
			
		</div>
		<div class="Inboxesss">
			 <?= $_SESSION['Receive'] ?> 
		</div>
	</div>

	<div class="Borders3">
		<div class="topborder3">
			<h1 class="TextSent">Sent Messages</h1>
		</div>

		<div class="Inboxess">
			 <?= $_SESSION['Sents'] ?> 
		</div>
	</div>

	<div class="Border1">
		<div class="topborder1">
			<div class="SearchBTN">
			<button id="myBtn" class="New" >Create A Message</button>
			<button onclick="location.href='http://localhost/web/doctor/doctor.php'" class="Backs">BACK</button>
			</div>
			<div class="Border2">
			<?= $_SESSION['Message'] ?>
			</div>
		</div>
	</div>




<!-- message modal -->
<div id="myModal" class="modal">

  <!-- Modal content -->
<form method="Get">
  	<div class="modal-content">
    	<span class="close">&times;</span>
    		<input type="text" name="Receiver" class="Username">
    		<input type="submit" class="ButtonSend" name="ButtonSend" value="Send Message">
		    <br>
		    <br>
		    <textarea name="Messages" class="Message"></textarea>
		   	Date:
		    <span id="output"></span>
			<br>
		    Time:
		<span id="outputs"></span>
  	</div>
	

</form>
</div>




</body>
<script>
var myVar = setInterval(myTimer, 1000);
function myTimer()
{
	var today = new Date();
	var dd = today.getDate();
	var mm = today.getMonth()+1; //The Months Start With 0
	var yyyy = today.getFullYear();
	todays = yyyy+'-'+mm+'-'+dd;
	var times = today.getHours()
	var Minutes = today.getMinutes()
	var second = today.getSeconds()
	var time = times+'-'+Minutes+'-'+second;
    document.getElementById('output').innerHTML = todays;
    document.getElementById("outputs").innerHTML = today.toLocaleTimeString();    
}
	// Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal
btn.onclick = function() {
  modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
  modal.style.display = "none";
}
// When the user clicks anywhere outside of the modal, close i
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
} 
		</script>
</html>