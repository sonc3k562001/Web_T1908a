<?php
$fil1 = 0 ;
$fil2 = 1;
$sum = 0 ;
echo "$fil1<br>";
while ($sum <15){
    echo "$fil2 <br>";
    $sum = $fil1 + $fil2;
    $fil1 = $fil2;
    $fil2 = $sum;

}
echo "<br>";
return 0;
