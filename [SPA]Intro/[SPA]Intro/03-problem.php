<?php
$input = json_decode($_GET['jsonTable']);

$strSize = $input[0];
$message = "";
$printArray = [];
for ($i = 1; $i < count($input[1]); $i++) {
    preg_match_all('/\d*ms/', $input[1][$i], $matchTiming);
    preg_match_all('/\d*/', $matchTiming[0][0], $result);
    if (($result[0][0] >= 65 && $result[0][0] <= 90) || ($result[0][0] >= 97 && $result[0][0] <= 122) || $result[0][0] == 32) {
        if ($result[0][0] == 42) {
            $message .= str_repeat(' ', $strSize - strlen($message));
            $printArray[] = $message;
            $message = '';
            $message .= chr($result[0][0]);

            continue;
        }
        if ($strSize == strlen($message)) {
            $printArray[] = $message;
            $message = '';
            $message .= chr($result[0][0]);
            continue;
        }
        $message .= chr($result[0][0]);
    }
}

$message .= str_repeat(' ', $strSize - strlen($message));
$printArray[] = $message;

if ($printArray[0][0] == " ") {
    array_splice($printArray,0,1);
}

$diff = strlen($message) % $strSize;
$pluiKovro = "<table border='1' cellpadding='5'>";

for ($i = 0; $i < count($printArray); $i++) {
    $pluiKovro .= '<tr>';
    for ($j = 0; $j < strlen($printArray[$i]); $j++) {
        $pluiKovro .= ($printArray[$i][$j] != ' '?"<td style='background:#CAF'>".$printArray[$i][$j]:"<td>".''). "</td>";
    }
    $pluiKovro .= '</tr>';
}
$pluiKovro .= '</table>';
echo($pluiKovro);