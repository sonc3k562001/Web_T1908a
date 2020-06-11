<?php
$salary = 8000;
if ($salary < 6000){
    echo "the salary: $salary <br>";
    exit;
}else{
    echo "the salary: $salary<br>";
    $bounus = $salary*0.8;
    echo "the bonus : $bounus<br>";
}
