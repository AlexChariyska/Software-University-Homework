<?php
if(isset($_POST['submit'])) {
   $input = $_POST['input'];

    if(is_numeric($input)){
        echo var_dump($input);
    }else {
       echo gettype($input);
    }
}
?>