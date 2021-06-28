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
    <link rel="stylesheet" type="text/css" href="patientlist.css">
   <title>Patient Record</title>
  </head>
  <style>
    .t1 {
      font-family: verdana;
      font-size: 40px;
    }


  </style>
  <body>
    <nav class="nav__cont" style="background-color:#6E4201;">
      <ul class="navv">

        <img src="../logo/healthlogo.png" style="width: 150px; position:relative; right: 20px; margin-top: 50px">
        <br>
        <br>
        <br>
        <br>
         <li class="nav__items">
          <img src="../Logo/message.png" class="Logo" style="position:relative; left: -70px; top: 25px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/messenger.php"style="position:relative; top: -10px;">Message</a>
        </li>
        <br>
        <li class="nav__items ">
          <img src="../Logo/patient.png" class="Logo" style="position:relative; left:  -70px;  top: -25px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/patientlist.php" style="position:relative;top: -65px; left: 10px">Patient List</a>
        </li>
            <br>
        <li class="nav__items ">
          <img src="../Logo/babylist.png" class="Logo" style="position:relative; left:  -70px;  top: -75px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/infantview.php" style="position:relative;top: -105px; left: 10px; font-size: 19px">Toddlers</a>
        </li>
      <br>
        <li class="nav__items">
          <img src="../Logo/admit.png" class="Logo"style="position:relative; left:  -70px; top: -155px">
          <a href="http://healthmonitoring.bcamp2017.com/doctor/monitoring.php" style="position:relative;top: -185px; left: 10px;">Admitted</a>
        </li>
      <br>
      <br>


      </ul>
    <form method="GET">
    <input type="submit" value="Sign-out" class="Buttons" name="Logout" style="font-size: 20px; border: 1px solid black; border-radius: 3px; position:absolute; bottom: 8px; left: 75px; cursor: pointer;">
      </form>
  </nav>
    <div class="container">
      <br />
      <br />
      <br />
     <div class="bacoor">

    </div>
<span  class="t1">Patient Record</span>

      <div class="form-group">
          <button onclick="window.print();" class="btn btn-primary" style="" id="print-btn">Print</button>
        <div class="input-group">
          <span class="input-group-addon" style="border-style: none">Search</span>
          <br>
          <input type="text" name="search_text" id="search_text" placeholder="Search Patient" class="form-control" style="margin-bottom: 20px;" />
          </div>
      </div>
      <br >
      <br>
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
      url:"Searchs.php",
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
