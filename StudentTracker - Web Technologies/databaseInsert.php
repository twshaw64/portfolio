<?php 
include "databaseHandler.php";
date_default_timezone_set('Europe/London');

$studentID = $_POST['studentID'];
$forename = $_POST['forename'];
$surname = $_POST['surname'];
$location = $_POST['location'];
$dateTime = date('Y-m-d H:i:s');

$redirect = true;
$redirect_page = "../557716/current.php";
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
    <div class="retrieveForm">
        <form align = "center">
            <?php 
                $insert_query = "INSERT INTO dbo.locationTable (studentID, forename, surname, location, updateTime) VALUES (?, ?, ?, ?, ?)";
			
                $var = array($studentID,$forename,$surname,$location,$dateTime);

                if(!sqlsrv_query($conn,$insert_query,$var))
                {
                    die(print_r(sqlsrv_errors(), true));
                }
                else
                {
                    header("Location : " .$redirect_page);
                }                

                sqlsrv_close($conn);
            ?>
        </form>
    </div>
</body>
