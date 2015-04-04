<form method="get">
    <textarea name="input">

    </textarea>
    <input type="submit">
</form>
<?php
/**
 * Write a PHP program URLReplacer.php that takes a text from
 * a textarea and replaces all URLs with the HTML syntax
 * <a href= "…" ></a> with a special forum-style syntax
 * Q    1A`1Q21`[URL=…][/URL].
 */
if (isset($_GET['input'])) {
    $input = $_GET['input'];

    $input = preg_replace('/(<a\s+href=")/','[URL=',$input);
    $input = preg_replace('/(">)/',']',$input);
    $input = preg_replace('/<\/a>/','[/URL]',$input);

    echo htmlentities($input);
}
