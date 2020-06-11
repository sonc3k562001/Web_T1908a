<html>
<head>
    <title>the admin</title>
</head>
<body>
<?php
$a = $_GET['num'];
if ($a==0){
    exit;
}else{
    $ans = 1/$a;
    echo"the ans 1/$a: $ans <br>";
}
?>
<br>
<button><a href="snipet13_4.php">back</a></button>
</body>
</html>