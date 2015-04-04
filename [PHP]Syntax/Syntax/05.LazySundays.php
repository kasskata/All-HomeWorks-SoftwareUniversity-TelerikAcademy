<p>
    Write a PHP script LazySundays.php which prints the dates
    of all Sundays in the current month.
</p>
<?php

$date = '-m-Y';

for ($day = 1; $day < 33; $day++) {
    $tempDate = date((string)$day . $date);
    if (date("w", strtotime($tempDate)) == 0) {
        echo $tempDate . '<br/>';
    }
}