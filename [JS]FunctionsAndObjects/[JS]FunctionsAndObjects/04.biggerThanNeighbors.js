"use strict";

var input = ['2', '[1, 2, 5, 3, 4]'];

biggerThanNeighbors(input);

function biggerThanNeighbors(input) {
    var i = parseInt(input[0]);
    console.log(i);
    var arr = input[1].split(',');

    for (var j = 0; j < arr.length; j++) {
        arr[i] = parseInt(arr[i]);
    }
    
    if (arr[i-1] < arr[i] && arr[i]> arr[i+1]) {
        console.log("bigger");
    }
    else if (arr[i-1] >= arr[i] || arr[i] <= arr[i+1]) {
        console.log("not bigger");
    }
    else if (arr[i]<arr[0]||arr[i]>arr[arr.length-1]) {
        console.log("invalid index");
    }
    else if (arr[i]==arr[0]||arr[i]==arr[arr.length-1]) {
        console.log("invalid index");
    }
}