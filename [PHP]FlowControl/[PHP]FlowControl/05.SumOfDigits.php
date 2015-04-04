<form method="get">
    <label for="input">Input string:</label>
    <input type="text" name="input">
    <input type="submit">
</form>
<table border="1">
    <?php
    if (isset($_GET['input'])) {
        $input = explode(', ', $_GET['input']);
        for ($i = 0; $i < count($input); $i++) {
            echo('<tr>');
            echo( '<td>'.$input[$i].'</td>');
            $sum = 0;
            if (is_numeric($input[$i])) {
                $inputVal = strval($input[$i]);
                for ($j = 0; $j < strlen($inputVal); $j++) {
                    $sum += (int)$inputVal[$j];
                }
                echo( '<td>'.$sum.'</td>');
            }else{
                echo('<td> I cannot sum that </td>');
            }
            echo('</tr>');
        }
    }
    ?>
</table>