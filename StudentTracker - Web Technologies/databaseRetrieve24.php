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
    <div class="retrieveForm">
        <form align = "center">
            <?php
                $studentID = $_POST['studentID'];

                $test = "SELECT * FROM locationTable WHERE studentID LIKE $studentID";
                $recent = "SELECT * FROM locationTable WHERE updateTime >= DATEADD(day, -1, GETDATE()) AND studentID LIKE $studentID";
                $results = sqlsrv_query($conn, $recent);

                if (!$results)
                {
                    if( ($errors = sqlsrv_errors() ) != null)
                    {
                        foreach( $errors as $error )
                        {
                            echo "<p>Error: ".$error[ 'message']."</p>";
                        }
                    }
                }
                else
                {
                    while($row = sqlsrv_fetch_array($results, SQLSRV_FETCH_ASSOC))
                    {
                        
                        echo '<p>'.$row['studentID'].' '.$row['forename'].' '.$row['surname'].' '.$row['location'].' '.$row['updateTime'] -> format ('Y-m-d H:i:s').'</p>';

                    }           
                }
                sqlsrv_close($conn);                
            ?>
        </form>
    </div>
    <img src="http://www.waynestevenjackson.co.uk/img/acklogos/hulluni.png" alt="University of Hull" style:"width:461.25px;height:126px;">
</body>
</html>

