<!DOCTYPE html>
<html>
<head>
    <title>Sidebar generator</title>
    <style>
        aside {
            width: 150px;
            border: 1px solid black;
            border-radius: 15px;
            padding: 5px;
            margin: 10px;
            background: #B1C9E9;
        }
        h1 {
            line-height: 1.4;
            margin:5px;
        }
        ul li {
            list-style: circle
        }
        a{
            color: black;
        }
    </style>
</head>
<body>
<form method="post">
    Categories<input type="text" name="categories"><br/>
    Tags<input type="text" name="tags"><br/>
    Months<input type="text" name="months"><br/>
    <button type="submit" name="btn">Generate</button>
</form>
<?php
if (!empty($_POST['categories'])) {
    $categories = preg_split('/[, ]+/', $_POST['categories']);?>
    <aside>
        <h1>Categories</h1>
        <hr/>
        <ul>
            <?php
            foreach ($categories as $value) {
                echo "<li><a href=\"#\">$value</a></li>";
            }
            ?>
        </ul>
    </aside>
<?php }; ?>
<?php
if (!empty($_POST['tags'])) {
    $tags = preg_split('/[, ]+/', $_POST['tags']);?>
    <aside>
        <h1>Tags</h1>
        <hr/>
        <ul>
            <?php
            foreach ($tags as $value) {
                echo "<li><a href=\"#\">$value</a></li>";
            }
            ?>
        </ul>
    </aside>
<?php } ?>
<?php
if (!empty($_POST['months'])) {
    $months = preg_split('/[, ]+/', $_POST['months']);?>
    <aside>
        <h1>Months</h1>
        <hr/>
        <ul>
            <?php
            foreach ($months as $value) {
                echo "<li><a href=\"#\">$value</a></li>";
            }
            ?>
        </ul>
    </aside>
<?php } ?>

</body>
</html>