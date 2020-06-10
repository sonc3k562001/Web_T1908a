<?php
$s = 2011;
if(($s % 4== 0 && $s%100 !=0) || ($s%400 == 0))
{
    echo "$s is leap year";
}else{
    echo "$s not leap year";
}
?>
