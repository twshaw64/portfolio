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
        $query='create table cars ';
        $query .= ' (id int, make varchar(50), model varchar(50), doors int, price float)';
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
        

    ?>
</body>
</html>