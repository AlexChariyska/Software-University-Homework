<!DOCTYPE html>
<html>
<head>
    <title></title>
</head>
<body>
<form method="post">Enter tags:
    <input type="text" name="tags"/>
    <input type="submit" name="btn"></form>
</body>
</html>
<?php
if(isset($_POST['btn'])){
    $input=htmlentities($_POST['tags']);
    $array=explode(", ", $input);
    for($i=0; $i<count($array);$i++){
        echo "$i : $array[$i] <br/>";
    }
}
?>
