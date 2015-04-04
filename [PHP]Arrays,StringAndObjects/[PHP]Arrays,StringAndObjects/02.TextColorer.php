<form method="get">
    <textarea name="input">

    </textarea>
    <input type="submit">
</form>
<?php
/**
Write a PHP program TextColorer.php that takes a text from
 * a textfield, colors each character according to its
 * ASCII value and prints the result. If the ASCII value of
 * a character is odd, the character should be printed in
 * blue. If it’s even, it should be printed in red.
 */
if (isset($_GET['input'])) {
    $input = $_GET['input'];

    for ($i = 0; $i < strlen($input); $i++) {
        if ((ord($input[$i]) % 2 != 0)) {
            echo('<span style="color:blue">' . $input[$i] . '</span>');
        } else{
            echo('<span style="color:red">' . $input[$i] . '</span>');

        }
    }
}
?>
<span style="color:blue"></span>