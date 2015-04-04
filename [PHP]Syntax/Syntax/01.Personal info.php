<p>Write a PHP script PersonalInfo.php. Declare a
few variables. The first variable should hold your
 first name, the second should hold your last name,
 the third - your age, and the last one should hold your
 full name (use concatenation). The result should be printed.</p>
<?php
$first = 'Irahim';
$second = 'Nebestniii';
$age = 24;

$fullName = "My name is $first $second and I am $age years old.";
?>
<p><?= $fullName ?></p>
