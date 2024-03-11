<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <?php
        $server = 'sql.rde.hull.ac.uk'; $connectionInfo = array("Database"=>"rde_557716");
        $conn = sqlsrv_connect($server,$connectionInfo);
        $query='create table crimeDevon ';
        $query .= '(Month varchar(10), ASB int, Burglary int, Robbery int, Vehicle int, Shoplifting int, CDandA int, OtherTheft int, Drugs int, BikeTheft int, TheftFromThePerson int, Weapons int, PublicOrder int, Other int, Total int)';
        $result = sqlsrv_query($conn, $query);

        if (!$result)
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
            echo "<p>DB successfully created</p>";
        }
        
        $insert_query = "INSERT INTO crimeDevon (Month, ASB, Burglary, Robbery, Vehicle, Shoplifting, CDandA, OtherTheft, Drugs, BikeTheft, TheftFromThePerson, Weapons, PublicOrder, Other, Total) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		$params = array("sept 2018",12,12,3,1000,12,12,3,1000,12,12,3,1000,18,3180);
        $result = sqlsrv_query($conn,$insert_query,$params);
        $params = array("nov 2018",12,12,3,1000,12,12,3,1000,12,12,3,1000,18,3180);
        $result = sqlsrv_query($conn,$insert_query,$params);
        
        if (!$result)
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
            echo "<p>DB successfully populated</p>";
        }

		$describeQuery='select Month, ASB, Burglary, Robbery, Vehicle, Shoplifting, CDandA, OtherTheft, Drugs, BikeTheft, TheftFromThePerson, Weapons, PublicOrder, Other, Total from crimeDevon';
        $results = sqlsrv_query($conn, $describeQuery);
        
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
                echo '<p>'.$row['Month'].' '.$row['ASB'].' '.$row['Burglary'].' '.$row['Robbery'].' '.$row['Vehicle'].' '.$row['Shoplifting'].' '.$row['CDandA'].' '.$row['OtherTheft'].' '.$row['Drugs'].' '.$row['BikeTheft'].' '.$row['TheftFromThePerson'].' '.$row['Weapon'].' '.$row['PublicOrder'].' '.$row['Other'].' '.$row['Total'].'</p>'; 
            }           
        }
        sqlsrv_close($conn);
    ?>
</body>
</html>