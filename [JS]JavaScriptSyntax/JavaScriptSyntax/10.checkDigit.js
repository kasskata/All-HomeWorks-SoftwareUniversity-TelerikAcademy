"use strict";

console.log(checkDigit(25368));

function checkDigit(value){
    var numberToString = value.toString();
    if (numberToString[numberToString.length-3] === '3' ) {
        return true;
    }
    else{
        return false;
    }
}