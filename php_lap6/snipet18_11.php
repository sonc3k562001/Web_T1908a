<html>
<head>
    <title>Hello day la bai cuoi roi</title>
</head>
<body>
<?php
$server = "";
$username="root";
$password = "";
$connect_sql = mysqli_connect($server,$username,$password);
if ($connect_sql){
    echo "Connection established";

};
$mysql_db = mysqli_select_db($connect_sql,"publiccations");
if($mysql_db)
    echo "<br><br> Connected to the database<br><br>";

echo "<table border bgcolor = 'WHITE'>";
echo "<tr><th>isbn</th><th>name</th>";
echo "<DBQUERY q>select * frome customers";
echo "<BDROW><tr><td><? q.isbn> </td><td><? q.name</td></tr>";
echo "</DBQUERY>";
echo "</tr>";
echo "</table>";
?>
</body>
</html>