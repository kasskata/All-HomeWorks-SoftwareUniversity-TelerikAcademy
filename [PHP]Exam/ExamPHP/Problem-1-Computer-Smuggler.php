<?php
$list = preg_split('/[, ]+/', $_GET['list'],0,PREG_SPLIT_NO_EMPTY);
$list = array_count_values($list);
$min = 0;
$sum = 0;
$soldPC = 0;
$soldParts = 0;

if (count($list) == 4) {
    $min = min($list);
    $soldPC = $min * 420;
}
foreach ($list as $key => $value) {
    switch ($key) {
        case 'CPU':
            if ($value >= 5) {
                $sum += ($value * 85) / 2;
            } else {
                $sum += $value * 85;
            }
            break;
        case 'ROM':
            if ($value >= 5) {
                $sum += ($value * 45) / 2;
            } else {
                $sum += $value * 45;
            }
            break;
        case 'RAM':
            if ($value >= 5) {
                $sum += ($value * 35) / 2;
            } else {
                $sum += $value * 35;
            }
            break;
        case 'VIA':
            if ($value >= 5) {
                $sum += ($value * 45) / 2;
            } else {
                $sum += $value * 45;
            }
            break;
    }
}
$left = 0;
foreach ($list as $key => $value) {
    $value -= $min;
    $left += $value;
    switch ($key) {
        case 'CPU':
            $soldParts += ($value * 85) / 2;
            break;
        case 'ROM':
            $soldParts += ($value * 45) / 2;
            break;
        case 'RAM':
            $soldParts += ($value * 35) / 2;
            break;
        case 'VIA':
            $soldParts += ($value * 45) / 2;
            break;
    }
}
$result = (($soldParts + $soldPC) - $sum);
if($result <= 0){
    $result = "Nakov lost $result leva";
}elseif($result > 0){
    $result = "Nakov gained $result leva";
}
echo "<ul><li>" . $min . " computers assembled</li><li>$left parts left</li></ul><p>" . $result . "</p>";