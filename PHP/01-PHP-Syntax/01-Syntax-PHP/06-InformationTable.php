<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Information Table</title>
    <style>
        table, td, th {
            border: 1px solid black;
            border-collapse: collapse;
            width: 200px;;
        }

        table tr td {
            text-align: right;
        }

        table tr th {
            background: orange;
            text-align: left;
        }
    </style>
</head>
<body>
<?php
if (isset($_POST['submit'])) {
    $phone = $_POST['phone'];
    $name = $_POST['name'];
    $age = $_POST['age'];
    $address = $_POST['address'];
    ?>
    <table>
        <tr>
            <th>Name</th>
            <td><?php echo $name ?></td>
        </tr>
        <tr>
            <th>Phone</th>
            <td><?php echo $phone ?></td>
        </tr>
        <tr>
            <th>Age</th>
            <td><?php echo $age ?></td>
        </tr>
        <tr>
            <th>Address</th>
            <td><?php echo $address ?></td>
        </tr>
    </table>
<?php
}
?>
</body>
</html>
