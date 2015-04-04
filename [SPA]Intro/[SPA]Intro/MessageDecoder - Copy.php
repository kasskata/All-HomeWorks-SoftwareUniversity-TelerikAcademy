<?php
$input = json_decode($_GET['jsonTable']);

$colSize = $input[0];
$message = "";

foreach ($input[1] as $key=>$value) {
    preg_match_all('/(?<=time=)\d{1,3}(?=ms)/',$value, $matches);
    var_dump($matches);
    if(isset($matches[0][0]))
        $message .= chr($matches[0][0]);
}

$words = explode("*", $message);

printTable($words, $colSize);

function printTable($input, $colSize) {
    echo "<table border='1' cellpadding='5'>";
    foreach($input as $key=>$value) {
        printWord($value, $colSize);
    }
    echo "</table>";
}

function printWord($word, $colSize) {
    $rows = ceil(strlen($word)/$colSize);
    $currentChar = 0;
    for($i = 0; $i < $rows; $i++) {
        echo "<tr>";
        for($j = 0; $j < $colSize; $j++){
            if($currentChar < strlen($word) && $word[$currentChar] != ' ') {
                echo "<td style='background:#CAF'>";
                echo htmlspecialchars($word[$currentChar]);
            }else {
                echo "<td>";
            }
            echo "</td>";
            $currentChar++;
        }
        echo "</tr>";
    }
}