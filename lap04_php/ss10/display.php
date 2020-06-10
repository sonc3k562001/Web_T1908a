<?php
$a = $_GET['n1text'];
echo "Bonus: $";
echo $a;
echo "<br>";
if ($a >850){
    $bonus = $a *.1;
    echo "Bonus : $bonus";
    echo '<br>';
    $total = $a + $bonus;
    echo"total : $total";
}