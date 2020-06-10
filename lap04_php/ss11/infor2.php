
<html>
<head><title>in4</title></head>
<body>
<?php
$name = $_POST['name'];
$age= $_POST['age'];
if ($name ==""){
    echo"enter your name!!";
}else{
    if ($age ==""){
        echo "enter your age";
    }else{
        echo "Your name: $name <br> Your age: $age";
    }
}
?>
<br>
<a href="snipet11_3.php">back</a>
</body>
</html>
