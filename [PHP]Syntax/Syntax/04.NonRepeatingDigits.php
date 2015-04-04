<p>Write a PHP script NonRepeatingDigits.php that declares
an integer variable N, and then finds all 3-digit numbers that
 are less or equal than N (<= N) and consist
of unique digits. Print "no" if no such numbers exist. </p>
<?php
$n = 1234;

for ($i = 102; $i <= $n; $i++) {
    $iAsString = (string)$i;

    if ($i > 999) {
        break;
    }
    if (($iAsString[0] == $iAsString[1]) or
        $iAsString[1] == $iAsString[2] or
        $iAsString[0] == $iAsString[2]
    ) {
        continue;
    } else {
        print "<p> $i </p>";
    }
}