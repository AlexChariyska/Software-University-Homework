<!DOCTYPE html>
<html>
<head>
    <title>Sentence Finder</title>
</head>
<body>
<form method="post">
    Text:<br/>
    <textarea type="text" name="text"></textarea>
    <br/>
    Word:<input type="text" name="word"><br/>
    <button type="submit" name="btn">Submit</button>
</form>
<?php
if (!empty($_POST['text']) && !empty($_POST['word'])) {
    $word = $_POST['word'];
    $text = preg_split('/(?<=[.?!])\s*/', $_POST['text'], -1, PREG_SPLIT_NO_EMPTY);
    foreach ($text as $sentence) {
        if (preg_match("/\b($word)(.*)[.?!]/", $sentence)) {
            echo "<p>$sentence</p>";
        }
    }
}
?>
</body>
</html>