<!DOCTYPE html>
<html>
<head>
    <title></title>
</head>
<body>
<form method="post">
    Enter amount: <input type="text" name="amount"/><br/>
    <input type="radio" value="BGN" name="currency">BGN</radio>
    <input type="radio" value="&#8364;" name="currency">EUR</radio>
    <input type="radio" value="$" name="currency">USD</radio>
    <br/>
    Compound interest amount:<input type="text" name="amountIntr"><br/>
    <select name="time">
        <option value="6">6 months</option>
        <option value="12">1 year</option>
        <option value="24">2 years</option>
        <option value="36">3 years</option>
    </select>

    <button type="submit" name="btn">Calculate</button>
</form>
</body>
</html>
<?php
if (isset($_POST["btn"])) {
    $amount = htmlentities($_POST['amount']);
    $interest = $_POST['amountIntr'];
    $currency =htmlentities($_POST['currency']);
    $time = $_POST['time'];
    $sum = $amount * pow((1 + ($interest / 100) / 12), $time);
    echo $currency . " " . round($sum, 2);
}
?>