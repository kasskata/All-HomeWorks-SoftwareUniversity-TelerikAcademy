<form method="get">
    <textarea name="input">

    </textarea>
    <br>
    <input type="text" name="extract"/>
    <br>
    <input type="submit">
</form>
<?php
/**
 * Write a PHP program 06.SentenceExtractor.php that takes a
 * text from a textarea and a word from an input field and
 * prints all sentences from the text, containing that word.
 * A sentence is any sequence of words ending with ., ! or ?.
 */
if (isset($_GET['input']) && isset($_GET['extract'])) {
    $input = preg_split('/[!.?] /',$_GET['input']);
    $extract = $_GET['extract'];

    for ($i = 0; $i < count($input); $i++) {
        if(preg_match('[:()]',$input[$i])){
            unset($input[$i]);
        }
    }
    for ($i = 0; $i < count($input); $i++) {
        if(preg_match('/is/',$input[$i])){
            echo $input[$i];
        }
    }
}