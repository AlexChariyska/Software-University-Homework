<!DOCTYPE html>
<html>
<head>
    <title>Text Filter</title>
</head>
<body>
<form method="post">
    Text:<br/>
    <textarea type="text" name="text"></textarea>
    <br/>
    Ban-list:<input type="text" name="bans"><br/>
    <button type="submit" name="btn">Submit</button>
</form>
<p>
    <?php
    if (!empty($_POST['text'])) {
        $bans = explode(', ',strtolower($_POST['bans']));
        $text =strtolower($_POST['text']);
        foreach ($bans as $word) {
            $text = str_replace($word, str_repeat('*', strlen($word)), $text);
        }
        echo $text;
    }
    ?>
</p>

</body>
</html>