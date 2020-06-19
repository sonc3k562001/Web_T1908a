<?php
$connect_mysql = mysqli_connect('127.0.0.1','root','','publiccations');
$result = mysqli_query($connect_mysql,"select * from  customers");
$rows = $result->num_rows;
echo "The table contains $rows rows.<br>";
mysqli_close($connect_mysql);
echo "The connection to the database has been closed.";
?>