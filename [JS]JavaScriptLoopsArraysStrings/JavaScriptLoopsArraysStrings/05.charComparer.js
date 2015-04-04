"use strict";

var arr1 = ['3', '5', 'g', 'd'];
var arr2 = ['5', '3', 'g', 'd'];
compareChars(arr1, arr2);

function compareChars(arr1, arr2){
    var bool = true;
    if (arr1.length != arr2.length) {
        bool = false;    }
    else{
        for (var i = 0; i < arr1.length; i++) {
            if (arr1[i]!==arr2[i]) {
                bool = false;
                break;
            }
        }
    }
    return bool? console.log('Equal'):console.log('Not Equal');
}