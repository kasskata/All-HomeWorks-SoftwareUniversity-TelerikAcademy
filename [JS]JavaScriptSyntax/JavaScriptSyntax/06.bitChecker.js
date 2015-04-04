"use strict";

console.log(bitChecker(2567564754));

function bitChecker(value){
    var bitValue = value.toString(2);
    console.log(bitValue);
    if (bitValue[bitValue.length-4] === '1') {
        value = true;
    }
    else{
        value = false;
    }

    return value;
}