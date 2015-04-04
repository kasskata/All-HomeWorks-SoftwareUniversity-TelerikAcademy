<form>
    <input type="text" name="text"/>
    <input type="text" name="key"/>
    <input type="submit"/>
</form>
<?php
$text = $_GET['text'];
$in = $_GET['key'];

$patternKey = '';
$pattern = '';

if (!ctype_digit($in[0]) && !ctype_alpha($in[0])){
    $patternKey .= '\\' . $in[0];
}else{
    $patternKey .= $in[0];
}

for ($i = 1; $i < strlen($in)-1; $i++) {
    if (ctype_digit($in[$i])) {
        $patternKey .= '[0-9]*';
    } elseif (ctype_lower($in[$i])) {
        $patternKey .= '[a-z]*';
    } elseif (ctype_upper($in[$i])) {
        $patternKey .= '[A-Z]*';
    } else {
        $patternKey .= '\\' . $in[$i];
    }
}

if (!ctype_digit($in[strlen($in)-1]) && !ctype_alpha($in[strlen($in)-1])){
    $patternKey .= '\\' . $in[strlen($in)-1];
}else{
    $patternKey .= $in[strlen($in)-1];
}
$pattern = '/'.$patternKey.'(.{2,6})'.$patternKey.'/';
$matchAll = [];
preg_match_all($pattern,$text,$matchAll);

print_r(implode($matchAll[1]));