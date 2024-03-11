<?php 
include "databaseHandler.php";

$studentID = $_POST['studentID'];
$newForename = $_POST['newForename'];
$newSurname = $_POST['newSurname'];

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
                $update_query = "UPDATE dbo.locationTable SET forename = '$newForename', surname = '$newSurname' WHERE studentID LIKE $studentID";

                if(!sqlsrv_query($conn,$update_query))
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
