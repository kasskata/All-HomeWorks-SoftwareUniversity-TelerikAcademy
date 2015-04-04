<?php
$input = $_GET['text'];
$text = addslashes($input);
var_dump($text);
$lineLength = $_GET['lineLength'];

$arr = [];

for ($i = 0; $i < strlen($text); $i += $lineLength) {
    $temp = substr($text, $i, $lineLength);
    if (strlen($temp) < $lineLength) {
        $temp .= str_repeat(' ', $lineLength - strlen($temp));
    }
    $arr[] = $temp;
}
for ($r = 0; $r < 1; $r++) {
    for ($i = count($arr) - 2; $i >= 0; $i--) {
        for ($j = 0; $j < strlen($arr[$i]); $j++) {
            if ($arr[$i + 1][$j] === ' ') {
                $space = ' ';
                $arr[$i + 1][$j] = $arr[$i][$j];
                $arr[$i][$j] = $temp;
            }
        }
    }
}
echo("<table>");
for ($i = 0; $i < count($arr); $i++) {
    echo("<tr>");
    for ($j = 0; $j < strlen($arr[$i]); $j++) {
        echo("<td>" . htmlentities($arr[$i][$j]) . "</td>");
    }
    echo("</tr>");

}
echo("<table>");