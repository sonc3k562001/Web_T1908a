<?php
session_start();
$myname = $_SESSION['myname'];
session_unset();
session_destroy();
echo "session destroyed!";
?>
<html>
<head>
    <title>Session</title>
</head>
<body>
<br>
<a href="mypage.php">Homepage of Mypage.com</a>
</body>
</html>
