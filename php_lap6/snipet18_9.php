<?php
$server = "";
$username  = "root";
$password ="";
$connect_mysql = mysqli_connect($server,$username,$password);
if ($connect_mysql){
    echo "Connection established<br>";
}
else{
    die("Unable to connect<br>");
}
$mysql_db = mysqli_select_db($connect_mysql,"publiccations");

if ($mysql_db){
    echo "Connected to the database<br>";
}else{
    die("Uable to connect to the database<br>");
}
$sql_delete = ("Delete from customer where name = 'joe'");
$result = mysqli_query($connect_mysql,$sql_delete);
if($result){
    echo "Records deleted: $result<br>";
}
else{
    echo "Records not found in the table<br>";
    printf("error message: %s\n", mysqli_error($connect_mysql));
}
?>