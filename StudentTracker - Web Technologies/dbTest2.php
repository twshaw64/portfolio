<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <?php
        $server = 'sql.rde.hull.ac.uk';
		$connectionInfo = array( "Database"=>"rde_557716");
		$conn = sqlsrv_connect($server,$connectionInfo);

		$insert_query = "INSERT INTO cars (id, make, model, doors, price) VALUES (?, ?, ?, ?, ?)";
		$params = array(1,"Ford","Fiesta",3,1000);
		$result = sqlsrv_query($conn,$insert_query,$params);
		$params = array(2,"Ford","Mondeo",5,6000);
		$result = sqlsrv_query($conn,$insert_query,$params);
		
		$describeQuery='select make, model, price from cars';
		$results = sqlsrv_query($conn, $describeQuery);
		
		while($row = sqlsrv_fetch_array($results, SQLSRV_FETCH_ASSOC))
		{
			echo '<p>'.$row['make'].' '.$row['model'].': £'.$row['price'].'</p>'; 
		} 
		sqlsrv_close($conn);
    ?>
</body>
</html>