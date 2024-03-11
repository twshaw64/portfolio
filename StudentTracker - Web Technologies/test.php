<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
  

    <table style="width:100%">
<?php
    $a = 5;
    $b = 6;
	$c = $a + $b;
    echo '<p>' . $a . '+' . $b .'=' . $c . '</p>';

	$simpleArray = array("Mars bar","Galaxy","Curly Wurly","Twix");for ($i=0;$i<4;$i++) {echo '<p>Item ' . $i . ' is a ' . $simpleArray[$i] .'</p>';}
	$associativeArray = array("item1"=>"orange", "item2"=>"apple", "item3"=>"kumquat", "item4"=>"banana");
	echo '<p>Item 3 is a ' . $associativeArray['item3'] .'</p>';
	foreach($associativeArray as $key=>$value)
	{echo '<p>Array entry ' . $key . ' is a ' . $value .'</p>';}

    <table>
        <thead>
        <tr>
            <th><?php echo implode('</th><th>', array_keys(current($associativeArray))); ?></th>
        </tr>
        </thead>
        <tbody>
        <?php foreach ($associativeArray as $key=>$value): array_map('htmlentities',$value); ?>
            <tr>
                <td><?php echo implode('</td><td>', $value); ?></td>
            </tr>
        <?php endforeach; ?>
        </tbody>
    </table>
?>  
    <table style="width:100%">
        <tr>
            <th>ID</th>
            <th>Item</th>
        </tr>
        <tr>
            <td>1<td>
            <td><p></p><td>
        <tr>
            <td>2<td>
            <td><p>$item2</p><td>
        </tr>
        <tr>
            <td>3<td>
            <td><p>$item3</p><td>
        </tr>
        <tr>
            <td>4<td>
            <td><p>$item4</p><td>
        </tr>
    </table>

</body>
</html>