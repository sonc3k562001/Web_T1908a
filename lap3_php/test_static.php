<HTML>
<head>
    <title>
        hello
    </title>
</head>
<body>
<?php
function decrement(){
    static $static_int =99;
    $static_int --;
    echo"the decrement is $static_int";

}
decrement();
?>
</body>
</HTML>