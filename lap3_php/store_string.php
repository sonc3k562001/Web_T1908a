<HTML>
<head>
    <title></title>
</head>
<body>
<?php
$stringl ="I am learning PHP 5.";
function display(){
    global $stringl;
    echo $stringl;
}
display();
?>
</body>
</HTML>
