
<html>
<body>
<?php
$name = $_GET['name'];
$age = $_GET['age'];
if ($name==""){
    echo"enter your name!";
}else{
    if($age ==""){
        echo "enter your age";
    }else{
        echo "Hello ".$name;
        echo "<br>" ;
        echo "$name 's age:".$age;
    }
}
?>
<br>
<a href="snipet11_1.php">back</a>
</body>
</html>
