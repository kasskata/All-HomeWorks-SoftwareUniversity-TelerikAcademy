<table border="1">
<?php
$sum = 0;
for ($i = 0; $i <= 100; $i+=2) {
    $temp = sqrt($i);
    $sum += $temp;
    echo '<tr>' . '<td>' . $i . '</td>' . '<td>' . number_format($temp,2) . '</td>' . '</tr>';
}
?>
    <tr>
        <td> Total:</td>
        <td>
            <?=number_format($sum,2)?>
        </td>
    </tr>
</table>