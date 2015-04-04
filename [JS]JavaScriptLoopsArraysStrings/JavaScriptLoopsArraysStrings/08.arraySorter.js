"use strict";

var arr = [12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3];
arr.sort(function(a, b) {
    return a > b ? 1 : -1;
});
sortArray(arr);
function sortArray(arr) {
    console.log(arr);
}

