<!DOCTYPE html>
<html>
<head>
    <title>Word Mapping</title>
    <style>
        table,th,tr,td{
            border: 1px solid black;
            text-align: center;
            padding: 5px;;
        }
    </style>
</head>
<body>
<form method="post">
    <textarea type="text" name="input"></textarea>
    <input type="submit" name="btn">
</form>
<p>
    <?php
    if (isset($_POST['btn']) && !empty($_POST['input'])) {
        $words = preg_split('/\W+/', strtolower($_POST['input']), -1, PREG_SPLIT_NO_EMPTY);
        $wordList = [];
        foreach ($words as $word) {
            if (isset($wordList[$word])) {
                $wordList[$word]++;
            } else {
                $wordList[$word] = 1;
            }
        }
    }
    ?>
<table>
    <tr>
        <th>Word</th>
        <th>Count</th>
    <?php foreach ($wordList as $word => $value) : ?>
        <tr>
            <td><?=$word?></td>
            <td><?=$value?></td>
        </tr>
    <?php endforeach; ?>
</table>
</p>
</body>
</html>