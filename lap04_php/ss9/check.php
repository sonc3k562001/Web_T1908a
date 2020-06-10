<?php
$A = $_GET['name'];
if ($A > 60){
    echo 'you have got grade 1';
}
elseif ($A>40 && $A<60){
    echo 'you have got grade 2';
}else{
    echo 'sorry!';
}
