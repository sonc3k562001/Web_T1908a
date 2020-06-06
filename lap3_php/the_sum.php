<HTML>
<head>
</head>
<body>
<?php
$number1 = 54;
$number2 = 60;
function sum(){
    global $number1, $number2;
    $sum = $number1 + $number2;
    echo "the sum $number1 + $number2 = $sum";

}
sum();
echo 'are you ok!'
?>
</body>
</HTML>
