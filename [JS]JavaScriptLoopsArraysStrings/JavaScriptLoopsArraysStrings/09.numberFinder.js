"use strict";

var arr = [2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1];
console.log(findMaxSequence(arr));

function findMaxSequence(arr) {
    var count = 0;
    var value = 0;

    var maxSeq = 0;
    var maxSeqValue = 0;
    for (var i = 0; i < arr.length; i++) {
        for (var j = i+1; j < arr.length; j++) {
            if (parseInt(arr[i]) == parseInt(arr[j])) {
                count++;
                value = parseInt(arr[i]);
            }
            if (maxSeq < count) {
                maxSeq = count;
                maxSeqValue = value;
                count = 0;
                value=0;
            }
        }
    }
    if (maxSeq == 0) {
        return arr[0]+" ("+1+" times) ";
    }
    return maxSeqValue+" ("+maxSeq+" times) ";

}