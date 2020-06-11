<?php
$counter = 0;
while($counter<5){
    $counter++;
    if ($counter==3){
        echo"the continues the loop<br>";
        continue;
    }
    echo $counter."<br>";
}