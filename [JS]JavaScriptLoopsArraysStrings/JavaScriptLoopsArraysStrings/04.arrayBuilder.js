"use strict";

var arr = new Array(20);
createArray(arr);
console.log(arr);
function createArray(arr) {
    for (var i = 0; i < arr.length; i++) {
        arr[i]=i*5;
    }
    return arr;
}