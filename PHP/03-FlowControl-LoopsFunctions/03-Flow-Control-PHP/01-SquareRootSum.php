<!DOCTYPE html>
<html>
<head>
    <title>Square</title>
    <style>
        table, th,tr,td {
            border:1px solid black;
            border-collapse: collapse;
            text-align: center;
            padding: 5px;;
        }
    </style>
</head>
<body>
<table>
    <thead>
    <tr>
        <th>Number</th>
        <th>Square</th>
    </tr>
    </thead>
    <tbody>
    <?php
    $arr=[];
    for($i=0;$i<=100;$i+=2){
        $square=round(sqrt($i),2);
        array_push($arr,$square);
        echo "<tr><td>$i</td><td>$square</td></tr>";
    }
    $sum=array_sum($arr);
    echo "<tr><th>Sum</th><th>$sum</th></tr>";
    ?>
    </tbody>
</table>
</body>
</html>