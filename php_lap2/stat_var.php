<?php
/** @var TYPE_NAME $var1 */
$var1;
function sum(){
    static $var1 = 9;
    $var2 = $var1 + 8;
    echo "the value of the valiable is: $var1<br>";

    echo "the addition value of 9 +8 = $var2<br>";

}
sum();
?>

