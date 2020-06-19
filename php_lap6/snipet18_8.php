<?php
$server = "";
$username = "root";
$password = "";
$connect_mysql = mysqli_connect($server,$username,$password);
if ($connect_mysql){
    echo "Connection established<br>";
}else
{
    die("Unable to connect<br>");
}
$mysql_db = mysqli_select_db($connect_mysql,"publiccations");
if ($mysql_db)
{
    echo"Connected to the database<br>";
}else{
    die("Unable to connect to the database<br>");

}
$sql_disp = ("select * from customers;");
echo "<br> Displaying Records from the customers table:<br>";
$result = mysqli_query($connect_mysql,$sql_disp);
while ($row = mysqli_fetch_array($result)){
    echo" $row[name]";
    echo"$row[isbn]<br>";
}