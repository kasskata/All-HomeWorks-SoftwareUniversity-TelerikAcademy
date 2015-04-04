<form method="get">
    <textarea name="input">

    </textarea>
    <input type="submit">
</form>
<table border="1">
    <?php
    /**
     * Write a PHP program WordMapper.php that takes a text from
     * a textarea and prints each word and the number of times
     * it occurs in the text. The search should be
     * case-insensitive. The result should be printed as an
     * HTML table
     */
    if (isset($_GET['input'])) {
        $input = $_GET['input'];
        $regEx = '/\\W+/';
        $input = mb_strtolower($input);
        $input = preg_split($regEx, $input);
        $input = array_count_values($input);
        foreach ($input as $key => $value) {
            if ($key == '') {
                unset($input[$key]);
            } else {
                echo("<tr> <td> $key </td><td> $value </td></tr>");
            }
        }
    }
    ?>
</table>