"use strict";

var input = [
 'Life is pretty good, isn’t it?'
];
reverseWordsInString(input);

function reverseWordsInString(input) {
    var text = input[0].split(' ').filter(Boolean);
    for (var i = 0; i < text.length; i++) {
        text[i] = text[i].split('').reverse().join('');
    }
    console.log(text.join(' '));
}