<?php
$unit = $_GET['units'];
if ($unit >1000){
    $rate = $unit *3;
    echo "rate:".$rate."<br>";
    $Service = $unit *.1;
    echo "sevice:".$Service."<br>";
    $total = $rate + $Service;
    echo "total :".$total."<br>";
}elseif ($unit>500 && $unit <=1000){
    $rate = $unit *2;
    echo "rate:".$rate."<br>";
    $Service = $unit *.1;
    echo "sevice:".$Service."<br>";
    $total = $rate + $Service;
    echo "total :".$total."<br>";
}else{
    $rate = $unit *1.5;
    echo "rate:".$rate."<br>";
    $Service = $unit *.1;
    echo "sevice:".$Service."<br>";
    $total = $rate + $Service;
    echo "total :".$total."<br>";
}
