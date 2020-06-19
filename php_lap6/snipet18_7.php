<?php
$server ="127.0.0.1";
$username = 'root';
$password = "";
$connect_mysql = mysqli_connect($server,$username,$password);
if ($connect_mysql){
    echo "Connection established";
}
else{
    die("<br>Unalbe to connect");
}
$db ="user";
$mysql_db = mysqli_select_db($connect_mysql,$db);
if ($mysql_db){
    echo "<br><br> Connected to the database.";
}else{
    die("<br>Unalbe to connect to the database");
}
$sql_insert = "insert into customers(name,isbn)
values ('john',1234567891012)";
$result = mysqli_query($connect_mysql,$sql_insert);
if($result){
    echo "<br><br> the records have been added to the table";
}else{
    echo "<br>Unable to insert records.";
    mysqli_error();
}