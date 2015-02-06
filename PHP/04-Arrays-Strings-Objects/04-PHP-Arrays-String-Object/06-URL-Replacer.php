<!DOCTYPE html>
<html>
<head>
    <title>URL Finder</title>
</head>
<body>
<form method="post">
    Text:<br/>
    <textarea type="text" name="input"></textarea>
    <br/>
    <button type="submit" name="btn">Generate</button>
</form>
<?php
if (!empty($_POST['input'])) {
    $input=$_POST['input'];
    $input = preg_replace('/<a href="(.*?)">/', '[URL=\1]', $input);
    $input = str_replace('</a>', '[/URL]', $input);
    echo $input;
}
?>
</body>
</html>