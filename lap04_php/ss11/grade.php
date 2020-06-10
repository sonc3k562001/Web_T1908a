<html>
<head>
    <title>admin</title>
</head>
<body>
<?php
$name = $_GET['name'];
$grade = $_GET['grade'];
if ($name == ""){
    echo "Enter your name!!1";
}else{
    switch ($grade){
        case "" :
            echo "dear $name";
            echo"enter your grade";
            break;
        case "A":
            echo"Increment = 30% of basic salary <br>";
            echo"bonus = 20% of basic  <br>";
            echo"traveling allowance =$500 <br>";
            echo"Medical allowance =$500 <br>";
            break;
        case "B":
            echo"Increment = 20% of basic salary <br>";
            echo"bonus = 10% of basic  <br>";
            echo"traveling allowance =$300 <br>";
            echo"Medical allowance =$300 <br>";
            break;
        case "C":
            echo"Increment = 10% of basic salary <br>";
            echo"bonus = 5% of basic  <br>";
            echo"traveling allowance =$100 <br>";
            echo"Medical allowance =$100 <br>";
            break;
        default:
            echo "please enter A , B or C";
            break;
    }
}
?>
<br>
<a href="snipet11_2.php">Back</a>
</body>
</html>