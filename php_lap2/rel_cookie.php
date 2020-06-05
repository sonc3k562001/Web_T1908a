<?php
if (iset($_COOKIE['Name'])){
    $last = $_COOKIE['Name'];
    echo ' Welcome back! <br> your name :'.$last;
}else{
    echo "welcome to site";
}
