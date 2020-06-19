<?php
$server ="127.0.0.1";
$username = "root";
$password="";
$connect_mysql = mysqli_connect($server,$username,$password ,'publiccations');
if($connect_mysql){
    echo "Connection established<br>";

}else {
    die("unable to connect <br>");
}
$mysql_db = mysqli_select_db($connect_mysql,"customers");
if($mysql_db){
    echo "Connected to the database";
}else{
    die("Unable to connect to the database<br>");
}
$sql_table ="Create table user_contact("."user_id int not null primary key,"."user_name char(25_) not null,".")";
if (mysqli_query($connect_mysql,$sql_table)){
    echo "Table is created<br>";
}else{
    die("Unable to create the table<br>");
}
