<?php
include "databaseHandler.php";
?>
<html>

<head>
    <title>Form</title>
    <link rel="stylesheet" href="Form.css">
</head>

<body>
	<nav>
        <ul>
            <li>			
					<a href="index.php">Change Location</a>
                    <a href="current.php">Current Location</a>
                    <a href="recent.php">Recent Locations</a>                    
                    <a href="check.php">Location Checker</a>
                    <a href="details.php">Edit Details</a>
            </li>        
		</ul>
	</nav>
	<div class="detailsForm">
		<form action="databaseUpdate.php" method="POST" align = "center">

				<input name="studentID" placeholder="Student Number" class="textbox" required pattern="[0-9]{6}" title="Student ID"/>
				<input name="newForename" placeholder="New Forename" class="textbox" required pattern="[A-za-z]{0-50}" title="Forename"/>
				<input name="newSurname" placeholder="New Surname" class="textbox" required pattern="[A-za-z]{0-50}" title="Surname"/>
									
			<input name="submit" class="btn" type="submit" value="Submit">			
	</div>
	<img src="http://www.waynestevenjackson.co.uk/img/acklogos/hulluni.png" alt="University of Hull" style:"width:461.25px;height:126px;"
</body>
</html>