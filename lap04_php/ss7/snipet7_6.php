<?php
$amou_obj_class = new class{
     public $greting = 'hello';
     public $id = 754;
     const SETT='Some cofigration';
     public  function  getValue(){
         return 'Some return value';
     }
     public function GetValueWithArgs(string $s)
     {
         return 'return value is:' . $s;
     }
};
echo '<br>';
echo $amou_obj_class -> greting;
echo '<br>';
echo $amou_obj_class -> id;
echo '<br>';
echo $amou_obj_class ::SETT;
echo '<br>';
echo $amou_obj_class ->getValue();
echo '<br>';
echo $amou_obj_class ->GetValueWithArgs('T1908a');
?>
