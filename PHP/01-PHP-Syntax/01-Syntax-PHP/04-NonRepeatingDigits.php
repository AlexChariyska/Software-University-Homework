<?php
if (isset($_POST['submit'])) {
    $num = (int)$_POST['number'];
    $check=false;
    for ($i = 100; ($i <= 1000) && ($i<$num); $i++) {
        $numToCheck = (string)$i;
        if (($numToCheck[0] != $numToCheck[1]) && ($numToCheck[1] != $numToCheck[2]) && ($numToCheck[2] != $numToCheck[0])) {
            echo "$numToCheck ";
            $check=true;
        }
    }
    if($check==false){
        echo 'no';
    }
}
?>