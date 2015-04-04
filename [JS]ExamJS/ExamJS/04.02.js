var args = [
    '482vMWo(*&^%$213;k!@41341((()&^>><///]42344p;e312   '

];
solve(args);

function solve(args) {
    var text = args[0].split(/\D+/g).filter(Boolean);
    for (var i = 0; i < text.length; i++) {
        text[i] = Number(text[i]).toString(16).toUpperCase();
    }
    for (var i = 0; i < text.length; i++) {
        if (text[i].length < 4) {
            if (text[i].length < 2) {
                text[i] = '0x'+'000' + text[i];
            }else if (text[i].length < 3) {
                text[i] = '0x'+'00' + text[i];
            }else if (text[i].length < 4) {
                text[i] = '0x'+'0' + text[i];
            }
        }else if(text[i].length == 4){
            text[i] = '0x' + text[i];
        }
    }
    console.log(text.join('-'));
}