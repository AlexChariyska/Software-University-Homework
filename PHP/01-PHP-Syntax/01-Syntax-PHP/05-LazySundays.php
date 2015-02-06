<?php
$monthCurr = date("F");
$year = date("Y");
$days = date("t");

for ($i = 1; $i <= $days; $i++) {
    $date = strtotime("$i $monthCurr $year");
    if (date("l", $date) == "Sunday") {
        echo date("jS F, Y", $date) . "\n";
    }
}

?>