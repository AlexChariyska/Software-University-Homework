<!--Write a PHP script StringModifier.php which receives a string from an input form and modifies it
 according to the selected option (radio button). You should support the following operations: palindrome
 check, reverse string, split to extract letters only, hash the string with the default PHP hashing algorithm,
 shuffle the string characters randomly. The result should be displayed right under the input field. Styling the
  page is optional. Think about which of the modification can be achieved with already built-in functions in PHP.
  Where necessary, write your own algorithms to modify the given string. Hint: Use the crypt() function for the
  "Hash String" modification.-->

<!DOCTYPE html>
<html>
<head>
    <title>String Modifier</title>
    <style>

    </style>
</head>
<body>
<form method="post">
    <input type="text" name="input">
    <input type="radio" id="palindrome" value="1" name="options"><label for="palindrome">Check palindrome</label>
    <input type="radio" id="reverse" value="2" name="options"><label for="reverse">Reverse string</label>
    <input type="radio" id="split" value="3" name="options"><label for="split">Split</label>
    <input type="radio" id="hash" value="4" name="options"><label for="hash">Hash String</label>
    <input type="radio" id="shuffle" value="5" name="options"><label for="shuffle">Shuffle String</label>
    <input type="submit" name="btn">
</form>
<p>
    <?php
    if (isset($_POST['input']) && isset($_POST['btn']) && !empty($_POST['input'])) {
        $input = $_POST['input'];
        if ($_POST['options'] == 1) {
            $reverse = strrev($input);
            if ($input == $reverse) {
                echo htmlentities($input) . '-> Is palindrome';
            } else {
                echo htmlentities($input) . '-> This is not a palindrome';
            }
        } else if ($_POST['options'] == 2) {
            echo strrev($input);
        } else if ($_POST['options'] == 3) {
            $result=preg_split('/[^a-zA-Z]/i', $input);
            foreach($result as $str){
            echo implode(' ', str_split($str))." ";
            }
        } else if ($_POST['options'] == 4) {
            echo hash('ripemd160', $input);
        } else if ($_POST['options'] == 5) {
            $shuffled = str_shuffle($input);
            echo htmlentities($shuffled);
        }
    }
    ?>
</p>
</body>
</html>