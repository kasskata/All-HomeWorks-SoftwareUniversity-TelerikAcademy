<form method="get">
    <input type="text" name="input">
    <input type="radio" value="palindrome" name="radio">
    <span>Check Palindrome</span>
    <input type="radio" value="reverse" name="radio">
    <span>Reverse String</span>
    <input type="radio" value="split" name="radio">
    <span>Split</span>
    <input type="radio" value="hash" name="radio">
    <span>Hash String</span>
    <input type="radio" value="shuffle" name="radio">
    <span>Shuffle String</span>
    <input type="submit" value="Submit" name="submit">
</form>
<?php
if(isset($_GET['input']) && isset($_GET['radio'])){
    $input = $_GET['input'];
    $radio = $_GET['radio'];

    if($radio == 'palindrome'){
        if($input === strrev($input)){
            echo("<p>$input is Palindrome</p>");
        }else{
            echo("<p>$input is not Palindrome</p>");
        }
    }
    if($radio =='reverse'){
        echo strrev($input);
    }
    if($radio =='hash'){
        echo hash("sha256",$input);
    }
    if($radio =='shuffle'){
        echo str_shuffle($input);
    }
    if($radio =='split'){
        $input = str_split($input);
        $input = implode(', ',$input);
        echo $input;
    }
}
?>
