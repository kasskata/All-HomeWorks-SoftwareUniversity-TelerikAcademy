<form>
    <label for="year">Enter number of year/s:</label>
    <input type="number" name="year"/>
    <input type="submit" name="submit" value="Show costs"/>
</form>
<table border="1">
    <tr>
        <td>
            Year
        </td>
        <td>
            January
        </td>
        <td>
            February
        </td>
        <td>
            March
        </td>
        <td>
            April
        </td>
        <td>
            May
        </td>
        <td>
            June
        </td>
        <td>
            July
        </td>
        <td>
            August
        </td>
        <td>
            September
        </td>
        <td>
            November
        </td>
        <td>
            December
        </td>
        <td>
            Total:
        </td>
    </tr>
<?php
if (isset($_GET['year'])) {
    $sum = 0;
    $year = 2014;
    $i = $year;
    for (; $i >= $year - $_GET['year']+1; $i--) {
        echo "<tr>";
        echo "<td>" . $i . "</td>";
        for ($j = 0; $j < 12; $j++) {
            if($j == 11){
                echo "<td>" . $sum . "</td>";
                $sum = 0;
                continue;
            }
            $rand = rand(0, 999);
            $sum += $rand;
            echo "<td>" . $rand . "</td>";
        }
        echo "</tr>";
    }
}
?>
</table>