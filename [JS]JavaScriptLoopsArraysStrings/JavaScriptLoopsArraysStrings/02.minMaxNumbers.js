"use strict";

var arr = [500, 1, -23, 0, -300, 28, 35, 12];
    arr.sort(function(a, b) {
        return a > b ? 1 : -1;
    });
findMinAndMax(arr);
function findMinAndMax(arr) {

    console.log('Min -> '+arr[0]);
    console.log('Max -> '+arr[arr.length-1]);
}

