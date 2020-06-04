<?php
class  Greeting{
    private $word = "Hello";

}
$clouse = function ($whom){
    echo "$this->word $whom <br>";
};
$obj = new Greeting();
$clouse->call($obj,'john');
$clouse->call($obj,'Nevin');
