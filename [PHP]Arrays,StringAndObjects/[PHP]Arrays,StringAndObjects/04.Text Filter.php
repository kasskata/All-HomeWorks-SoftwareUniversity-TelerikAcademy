<form method="get">
    <label for="input">Text:</label>
    <br>
    <textarea name="input"></textarea>
    <br>
    <label for="list">Banned List</label>
    <br>
    <textarea name="list"></textarea>
    <br>
    <input type="submit">
</form>
<?php
/**
 * Write a PHP program TextFilter.php that takes a text
 * from a textfield and a string of banned words from a
 * text input field. All words included in the ban list
 * should be replaced with asterisks "*", equal to the word’
 * s length. The entries in the banlist will be separated
 * by a comma and space ", ".
 */
if (isset($_GET['input'])) {
    $list =  explode(', ',strtolower($_GET['list']));
    $input = strtolower($_GET['input']);

    for ($i = 0; $i < count($list); $i++) {
        $input = str_replace($list[$i],str_repeat('*',strlen($list[$i])),$input);
    }

    echo($input);
}
//It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux!
//Sincerely, a Windows client
