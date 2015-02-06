<!DOCTYPE html>
<html>
<head>
    <title>Info</title>
</head>
<body>
<form action="" method="POST">
    <input type="text" name="name" placeholder="Name"><br>
    <input type="text" name="age" placeholder="Age"><br>
    <label for="male">Male</label> <input id="male" type="radio" name="radio" value="male"><br/><label for="female">Female</label>
    <input id='female' type="radio" name="radio" value="female">
    <br/>
    <input type="submit" name="submit" value="Submit">
</form>
</body>
</html>
<?php
if (isset($_POST['submit'])) {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $radio = $_POST['radio'];
    echo "My name is $name and I am $age years old. I am $radio.";
}
?>
