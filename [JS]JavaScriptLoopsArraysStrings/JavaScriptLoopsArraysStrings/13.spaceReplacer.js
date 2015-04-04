"use strict";

var input = "But you were living in another world tryin' to get your message through";

console.log(replaceSpaces(input));

function replaceSpaces(input){
    var text = input.split(' ');
    return text.join('');
}