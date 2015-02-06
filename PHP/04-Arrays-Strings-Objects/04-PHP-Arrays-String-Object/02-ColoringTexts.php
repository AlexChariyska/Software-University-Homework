<!DOCTYPE html>
<html>
<head>
    <title>Coloring Text</title>
</head>
<body>
<form method="post">
    <textarea type="text" name="input"></textarea><br/>
    <input type="submit" name="btn">
</form>
<p>
    <?php
    if (isset($_POST['btn']) && !empty($_POST['input'])) {
        $words = str_split(($_POST['input']));
        foreach($words as $letter){
            if(ord($letter)%2==0){
                echo "<span style='color:red'>$letter <span>";
            }else{
                echo "<span style='color:blue'>$letter <span>";
            }
        }
    }
    ?>
</p>
</body>
</html>