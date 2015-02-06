<!DOCTYPE html>
<html>
<head>
    <title>Primes</title>
    <style>
        p {
            font-size: 18px;
        }
        p strong {
            font-size: 20px;
        }
    </style>
</head>
<body>
<form method="post">
    Start: <input type="text" name="start">
    <br/>
    End:<input type="text" name="end">
    <input type="submit" name="btn">
</form>
<p>
    <?php
    if (isset($_POST['btn'])) {
        for ($i = $_POST['start']; $i <= $_POST['end']; $i++) {
            if (isPrime($i)) {
                echo "<strong>$i</strong>";
            } else {
                echo "$i";
            }
            if ($i != $_POST['end']){
                echo ", ";
            }
        }
    }
    ?>
</p>
</body>
</html>


<?php
function isPrime($num)
{
    if ($num == 1)
        return false;
    if ($num == 2)
        return true;
    if ($num % 2 == 0) {
        return false;
    }
    for ($i = 3; $i <= ceil(sqrt($num)); $i = $i + 2) {
        if ($num % $i == 0)
            return false;
    }
    return true;
}

?>