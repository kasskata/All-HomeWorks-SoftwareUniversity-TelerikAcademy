"use strict";
 var input = 'There is a man, his name was Bob.';

console.log(findPalindromes(input));

function findPalindromes(input) {
    var value = input.toLowerCase().split(/\W/).filter(Boolean);
   console.log(value);
    var results = [];
    for (var i = 0; i < value.length;i++){
        if (checkPalindrom(value[i])) {
            results.push(value[i]);
        }
    }
    return results;
}
function checkPalindrom(str) {
    return str == str.split('').reverse().join('');
}