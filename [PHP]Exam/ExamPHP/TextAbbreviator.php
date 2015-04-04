<?php
$list = preg_split('/\n/', $_GET['list'], -1, PREG_SPLIT_NO_EMPTY);
$maxSize = $_GET['maxSize'];
$lastLine = $list[count($list) - 1];
$newLastLine = '';

echo "<ul>";
foreach ($list as $key => &$val) {
    $val = trim($val);
    if (empty($val) || $val == ' ') {

        unset($list[$key]);
    } else {
        if (strlen($val) >= $maxSize) {
            $val = substr($val, 0, $maxSize);
            echo("<li>" . htmlentities($val . '...') . "</li>");
        } else {
            echo("<li>" . htmlentities($val) . "</li>");
        }
    }
}
echo "</ul>";