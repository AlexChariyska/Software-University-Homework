<!--Write a PHP script SumOfDigits.php which receives a comma-separated list of integers from an input
 form and creates a two-column table. The first column should contain each of the values from the input.
 The second column should contain the sum of the digits of each value. If the value is not an integer number,
  print "I cannot sum that".-->

<!DOCTYPE html>
<html>
<head>
    <title>Sum</title>
    <style>
        table, th, tr, td {
            border: 1px solid black;
            border-collapse: collapse;
            text-align: center;
            padding: 5px;;
        }
    </style>
</head>
<body>
<form method="get">
    Enter your numbers:
    <input type="text" name="input">
    <input type="submit" name="btn">
</form>
<?php
if (isset($_GET['btn']) && !empty($_GET['input'])) {
?>
<table>
    <thead>
    <tr>
        <th>Number</th>
        <th>Sum</th>
    </tr>
    </thead>
    <tbody>
    <?php
    $list = $_GET['input'];
    $input = preg_split('/[, ]+/', $list);

    for ($i = 0; $i < count($input); $i++) {
        $sum = 0;
        if (is_numeric($input[$i])) {
            $number = $input[$i];
            for ($l = 0; $l < strlen($number); $l++) {
                $digit = (int)$number[$l];
                $sum += $digit;
            }
            echo "<tr><td>$input[$i]</td><td>$sum</td></tr>";

        } else {
            echo "<tr><td>$input[$i]</td><td>I cannot sum this</td></tr>";
        }
    }
    }
    ?>
    </tbody>
</table>
</body>
</html>