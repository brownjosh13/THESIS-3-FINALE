<?php
include('noaccount.php');
include('logout.php');


 ?>

<html>
<link rel="stylesheet" type="text/css" href="search.css">
  <head>
      <link rel="shortcut icon" type="image/x-icon" href="Admin.jpg">
    <script src="jquery.min.js"></script>
    <script src="bootstrap.min.js"></script>
    <link href="bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="staff.css">
   <title>Staff List</title>
  </head>
  <style>
    .t1 {
      font-family: verdana;
      font-size: 40px;
    }


  </style>
  <body>

    <nav class="nav__cont" style="background-color:#6E4201;">
      <ul class="nav">
        <img src="../logo/healthlogo.png" style="width: 150px; position:relative; left: -5px;">
        <br>
        <br>
        <br>
        <li class="nav__items ">
          <img src="../Logo/message.png" class="Logo">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/messenger.php">Message</a>
        </li>

        <li class="nav__items ">
          <img src="../Logo/patient.png" class="Logo">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/patientlist.php">Patient List</a>
        </li>
        <li class="nav__items ">
          <img src="../Logo/admit.png" class="Logo">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/monitoring.php">Admitted</a>
        </li>
        <li class="nav__items ">
          <img src="../Logo/patientlist.png" class="Logo">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/staff.php">Staff</a>
        </li>

        <li class="nav__items ">
          <img src="../Logo/Reports.png" class="Logo">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/report.php">Reports</a>
        </li>

      </ul>
      <form method="GET">
      <input type="submit" value="Sign-out" class="Buttons" name="Logout">
        </form>

    </nav>
    <div class="container">
      <br />
      <br />
      <br />

<span  class="t1">Staff List</span>

      <div class="form-group">

        <div class="input-group">
          <span class="input-group-addon" style="border-style: none">Search</span>
      <br>
          <input type="text" name="search_text" id="search_text" placeholder="Search Patient" class="form-control" style="margin-bottom: 30px;" />
        </div>
      </div>
      <br />
      <div id="result"></div>
    </div>

    <div style="clear:both"></div>
  </body>
</html>


<script>
$(document).ready(function(){
  load_data();
  function load_data(query)
  {
    $.ajax({
      url:"Stafflist.php",
      method:"post",
      data:{query:query},
      success:function(data)
      {
        $('#result').html(data);
      }
    });
  }

  $('#search_text').keyup(function(){
    var search = $(this).val();
    if(search != '')
    {
      load_data(search);
    }
    else
    {
      load_data();
    }
  });
});
var dropdown = document.getElementsByClassName("dropdown-btn");
var i;

for (i = 0; i < dropdown.length; i++) {
  dropdown[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var dropdownContent = this.nextElementSibling;
    if (dropdownContent.style.display === "block") {
      dropdownContent.style.display = "none";
    } else {
      dropdownContent.style.display = "block";
    }
  });
}

</script>
