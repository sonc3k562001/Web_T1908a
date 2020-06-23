<?php
$val1 = $_GET['logname'];
$val2 = $_GET['pass'];

setcookie("logname",$val1);

if($val1 =="")
{
    echo "please enter the name!";
    echo "<html>";
    echo "<head>";
    echo "<title>validate</title>";
    echo "</head>";
    echo "<body>";
    echo "<a href='snipet1.php'>Back</a>";
    echo "</body>";
    echo "</html>";

}elseif ($val2==""){
    echo "please enter the password!";
    echo "<html>";
    echo "<head>";
    echo "<title>validate</title>";
    echo "</head>";
    echo "<body>";
    echo "<a href='snipet1.php'>Back</a>";
    echo "</body>";
    echo "</html>";
}
else {
    Header("Location : homepage.php");
}