"use strict";

var input = [3, 1451.78];

console.log(findNthDigit(input));

function findNthDigit(input) {
    if (((input[1].toString()).split('').reverse())[(input[0])]){
        return ((input[1].toString()).split('').reverse())[(input[0])];
    }else{
        return "The number doesn’t have "+input[0]+" digits";
    }
}