<!DOCTYPE html>
<html>
<head>
    <title></title>
</head>
<body>
<form method="post">
    <label for="input">Enter HTML tags</label> <input id="input" type="text" name="input"/><br/>
    <input type="submit" name="btn">
</form>
</body>
</html>
<?php
$arrTags = array("!doctype", "a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "big",
    "blockquote", "body", "br", "button", "canvas", "caption", "center", "cite", "code", "col", "colgroup", "command",
    "datalist", "dd", "del", "details", "dfn", "dir", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption",
    "figure", "font", "footer", "form", "frame", "frameset", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header",
    "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label", "legend", "li", "link",
    "map", "mark", "menu", "meta", "meter", "nav", "noframes", "noscript", "object", "ol", "optgroup", "option", "p",
    "param", "pre", "progress", "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source",
    "span", "strike", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td", "textarea", "tfoot", "th",
    "time", "title", "tr", "track", "tt", "u", "ul", "var", "video", "wbr");
$count = 0;
if (isset($_POST["btn"])) {
    $input = htmlentities($_POST['input']);
    session_start();
    if (in_array($input, $arrTags)) {
        if (isset($_SESSION['counter'])) {
            $_SESSION['counter']++;
        } else {
            $_SESSION['counter'] = 1;
        }
        echo "<p>Valid HTML Tag!<br>";
        echo "Score: " . $_SESSION['counter'] . "</p>";
    } else {
        $_SESSION['counter'] = 0;
        echo "<p>Invalid HTML Tag!</p>";
        echo "<p>Score: " . $_SESSION['counter'] . "</p>";
    }
}
?>