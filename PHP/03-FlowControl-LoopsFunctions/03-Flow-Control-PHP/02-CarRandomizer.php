<!DOCTYPE html>
<html>
<head>
    <title>Cars</title>
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
<form method="post">
    Enter your cars:
    <input type="text" name="input">
    <input type="submit" name="btn">
</form>
<?php
if (isset($_POST['input']) && !empty($_POST['input'])) {
    $input = $_POST['input'];
    $arr = preg_split('/[, ]+/', $input);
    $colors = array('aqua', 'black', 'blue', 'fuchsia', 'gray', 'green', 'lime', 'maroon', 'navy',
        'olive', 'orange', 'purple', 'red', 'silver', 'teal', 'white', 'yellow');
    ?>
    <table>
        <tr>
            <th>Car</th>
            <th>Color</th>
            <th>Count</th>
        </tr>
        <?php
        foreach ($arr as $car) {
            $randomNum = mt_rand(0, count($colors) - 1);
            $randCar = mt_rand(1, 5);
            echo "<tr><td>$car</td><td>$colors[$randomNum]</td><td>$randCar</td></tr>";
        }
        ?>
    </table>
<?php
}
?>

</body>
</html>