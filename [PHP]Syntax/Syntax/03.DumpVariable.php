<p>Write a PHP script DumpVariable.php that declares a
 variable. If the variable is numeric, print it by the built-in
  function var_dump(). If the variable
is not numeric, print its type at the input. Examples:</p>

<?php
$variable = true;
if (is_integer($variable) == true) {
    var_dump($variable);
} else if (is_float($variable == true)) {
    var_dump($variable);
} else{
    echo gettype($variable);
}
