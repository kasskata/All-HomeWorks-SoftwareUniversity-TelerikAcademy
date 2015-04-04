"use strict";

console.log(isPrime(997));

function isPrime(value){
    if (value % 2 !==0 && value % 3 !== 0 && value % 5 !== 0 && value % 7 !== 0){
        value = true;
    }
    else{
        value = false;
    }
    return value;
}