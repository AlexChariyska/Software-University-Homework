<!DOCTYPE html>
<html>
<head>
    <title>Annual expenses</title>
    <style>
        table, th, tr, td {
            border: 1px solid black;
            text-align: center;
        }
    </style>
</head>
<body>
<form method="post">
    Enter number of years:
    <input type="text" name="input"> <input type="submit" name="btn">
</form>
</body>
</html>
<?php
function tableGenerator(){
    $arr = [];
    for ($i = 1; $i <= 12; $i++) {
        $random = rand();
        array_push($arr, $random);
        echo "<td>$random</td>";
    }
    $sum=array_sum($arr);
    echo "<th>$sum</th>";
}


if (isset($_POST['btn'])) {
    $yearCurr = date("Y");

    echo "<table><tr>
    <th>Year</th>
    <th>January</th>
    <th>February</th>
    <th>March</th>
    <th>April</th>
    <th>May</th>
    <th>June</th>
    <th>July</th>
    <th>August</th>
    <th>September</th>
    <th>October</th>
    <th>November</th>
    <th>December</th>
    <th>Total</th>
    </tr>";

    for ($i = 1, $y = 0; $i <= $_POST['input']; $i++, $y++) {
        $year = $yearCurr - $y;
        echo "<tr><th>$year</th>";
        echo tableGenerator();
        echo "</tr>";
    }
    echo "</table>";
}
?>

