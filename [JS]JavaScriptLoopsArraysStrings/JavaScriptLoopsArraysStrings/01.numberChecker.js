"use strict";

printNumbers(13);

function printNumbers(value) {
    var arr = [];
    var devideFour = 4, devideFive = 5;
    for (var i = 0.; i <= value; i++) {
        if ((i % 4 !== 0) && (i % 5 !==0)) {
            arr.push(i);
        }
    }
    if (arr[0] == null) {console.log('no');}
    else {console.log(arr);}
}