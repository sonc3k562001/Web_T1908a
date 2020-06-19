<?php
$connect_mysql = mysqli_connect('127.0.0.1','root','','publiccations');
$result = mysqli_query($connect_mysql,"select * from customers");
while ($row = mysqli_fetch_row($result)){
    echo("%s (%s)\n,$row[0],$row[1]");
}
?>