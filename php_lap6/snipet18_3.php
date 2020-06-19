<?php
$connect = mysqli_connect('127.0.0.1','root','','publiccations');
if($result = mysqli_query($connect,"Select * from customers"))
{
    $rows = mysqli_num_rows($result);
    echo "The table contains $rows rows.<br>";
}
?>