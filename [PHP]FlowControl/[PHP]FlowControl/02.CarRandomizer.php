<form method="post">
    <input type="text" name="cars"/>
    <input type="submit" name="submit" value="Calc!"/>
</form>

<table border="1">
    <tr>
        <td>
            Car
        </td>
        <td>
            Color
        </td>
        <td>
            Count
        </td>
    </tr>
    <?php
    if (isset($_POST['cars'])) {
        $cars = explode(', ', $_POST['cars']);
        $color = array('yellow', 'green', 'black', 'pink', 'magenta', 'gold');
        $count = array(2, 1, 3, 1, 3, 4, 5);
        foreach ($cars as $car) {
             echo "<tr><td>". $car. "</td><td>" . $color[array_rand($color)] . "</td><td>". $count[array_rand($count)] . "</td></tr>";
        }
    }
?>
</table>