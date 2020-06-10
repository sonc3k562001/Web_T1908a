<?php
$a = $_GET['sal'];
if ($a >5000){
    $bonus = $a *.1;
    $total = $bonus + $a;
    echo "Salary:".$a."<br>";
    echo "Bonus:".$bonus."<br>";
    echo "Total:".$total."<br>";
}elseif ($a>=2000 && $a <=5000){
    $bonus = $a *.07;
    $total = $bonus + $a;
    echo "Salary:".$a."<br>";
    echo "Bonus:".$bonus."<br>";
    echo "Total:".$total."<br>";
}else{
    $bonus = $a *.05;
    $total = $bonus + $a;
    echo "Salary:".$a."<br>";
    echo "Bonus:".$bonus."<br>";
    echo "Total:".$total."<br>";
}
