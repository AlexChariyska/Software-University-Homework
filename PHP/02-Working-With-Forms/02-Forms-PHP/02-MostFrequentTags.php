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
    $assArr=[];
    for($i=0; $i<count($array);$i++){
        if(!(isset($assArr["$array[$i]"]))){
            $assArr["$array[$i]"]=0;
        }
        $assArr["$array[$i]"]+=1;
    }
    arsort($assArr);
   foreach($assArr as  $x=>$x_value){
        echo $x . " : " . $x_value;
        echo "<br>";
    }
}
?>