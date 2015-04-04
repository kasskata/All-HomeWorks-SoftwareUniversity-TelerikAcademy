<?php
/**
 * Write a PHP script AwesomeCalendar.php which
 * creates a calendar in HTML for a given year.
 * Styling the calendar is optional. Semantic HTML is required.
 * Hint: Embed HTML in your PHP code. Use tables or divs for
 * structuring the calendar.
 * Look for a way to find the day of the week.
 */
$month = array(
    array('<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>'),
    array('<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>'),
    array('<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>'),
    array('<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>'),
    array('<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>', '<td></td>'));
echo '<table border="1">';
//for ($i = 1; $i < 13; $i++) {
    $i = 4;

    for ($day = 1; $day <= date('t', strtotime('1-' . (string)$i . '-2014')); $day++) {
        $tempDate = date((string)$day . '-' . (string)$i . '-' . '2014');
        $month[(int)date('W', strtotime($tempDate))-1][(int)date('N', strtotime($tempDate))] = '<td>' . date('d', strtotime($tempDate)) . '</td>';

        if((int)date('N', strtotime($tempDate)) <= 1){
            echo '<tr>';
        }

        echo $month[(int)date('W', strtotime($tempDate))-1][(int)date('N', strtotime($tempDate))];

        if((int)date('N', strtotime($tempDate)) >= 7){

            echo '</tr>';
        }


    }
//}
echo '</table>';

//for ($i = 0; $i < 5; $i++) {
//    echo implode(' , ',$month[$i]);
//}