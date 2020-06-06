<HTML>
<head>
    <title> thu thuong cua mot so</title>

</head>
<body>
<?php
$number1 = 5;
$number2 = 30;
function division(){
    global $number1,$number2;
    $number3 = $number2/$number1;
    echo "the division : $number3";
}
division();
?>

</body>
</HTML>
