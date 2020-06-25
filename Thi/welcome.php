<html>
<head>
    <title>Welcome</title>
</head>
<body>
<?php
$hn = '127.0.0.1';
$un = 'root';
$pw = '';
$db = 'publiccations';

$connect = new mysqli($hn,$un,$pw,$db);
if ($connect->connect_error){
    die("Fail!!".$conn->connect_error);
    exit();
}
$username="";
$password ="";
$fullname ="";
$email ="";

if ($_SERVER["REQUEST_METHOD"]== "POST"){
    if (isset($_POST['username'])){$username = $_POST['username'];}
    if (isset($_POST['password'])){$password = $_POST['password'];}
    if (isset($_POST['fullname'])){$fullname = $_POST['fullname'];}
    if (isset($_POST['email'])){$email = $_POST['email'];}

    $sql = "insert into information(uname,pw,fulname,email)
    values ('$username','$password','$fullname','$email')";

    if ($connect->query($sql)=== TRUE){
        echo "Add data successfully!!";
    }else{
        echo "Error:".$sql."<br>".$connect->error;
    }
}
$connect->close();

if (session_id()==='')
    session_start();
if (isset($_SESSION['counter'])){
    $_SESSION['counter']+=1;
}else{
    $_SESSION['counter']=1;
}
$msg = "<p>You have entered: ".$_SESSION['counter']." in turn</p>";
echo $msg;

$a = $_POST['username'];
$b = $_POST['fullname'];
setcookie("name","$fullname",time()+3600,"/","",0);

if (isset($_COOKIE["name"]))
    echo "Welcome ".$_COOKIE["name"]."<br>";
else
    echo "not null.<br>";
setcookie("user","",time()-60,"/","",0);

?>
<br>
<a href="register.php">back</a>
</body>
</html>
