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
	<div class="locationForm">
		<form action="databaseInsert.php" method="POST" align = "center">

				<input name="studentID" placeholder="Student Number" class="textbox" required pattern="[0-9]{6}" title="Student ID"/>
				
				<div class="location" style:="width:276px;">
					<select name="location">
						<option value="">Location</option>
						<option value="Cohen">Cohen</option>
						<option value="Business School">Business School</option>
						<option value="Brynmore Jones Library">Brynmore Jones Library</option>
						<option value="Wilberforce">Wilberforce</option>
						<option value="Larkin">Larkin</option>
						<option value="Fenner">Fenner</option>
						<option value="Allam Medical Building">Allam Medical Building</option>
						<option value="Robert Blackburn">Robert Blackburn</option>
						<option value="Canham Turner">Canham Turner</option>
					</select>
				</div>
					
			<input name="submit" class="btn" type="submit" value="Submit">			
	</div>
	<img src="http://www.waynestevenjackson.co.uk/img/acklogos/hulluni.png" alt="University of Hull" style:"width:461.25px;height:126px;"
</body>
</html>