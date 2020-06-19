<?php
$server = "";
$username = "root";
$password = "";
$connect_sql = mysqli_connect($server,$username,$password);
if ($connect_sql){
    echo"Connection established<br>";
}else{
    die("Unable to connect <br>");
}
$mysql_db = mysqli_select_db($connect_sql,"publiccations");
if($mysql_db){
    echo "connected to the database<br>";
}else{
    die("Unable to connect to the database<br>");
}
$sql_update = ("Update customers set name='Jor' where isbn ='1040'") ;
$result = mysqli_query($connect_sql,$sql_update);
if ($result){
    echo "Records updated:$result<br>";
}else{
    echo "unale to update records<br>";
    printf("Error message: %s\n",mysqli_error($connect_sql));
}