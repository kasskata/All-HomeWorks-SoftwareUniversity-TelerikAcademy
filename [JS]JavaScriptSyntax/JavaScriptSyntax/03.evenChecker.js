"use strict";

console.log(evenNumber(588));

function evenNumber(value){
    if (value % 2 === 0) {
        value = true;
    }
    else{
        value = false;
    }
    return value;
}