<?php
/**
Write a PHP script GetFormData.php which retrieves the input
 * data from an HTML form, and displays it as string.
 * The input fields should hold name, age and gender (radio
 * buttons). The returned string should be a message containing
 * the information submitted by the form. 100% accuracy is NOT
 * required. Semantic HTML is required.
 */
$name = $_POST['name'];
$age = $_POST['age'];
$gender = $_POST['radio'];
?>
<p> My name is <?= $name ?>. I'm <?=$age?> years old. I am <?=$gender?></p>