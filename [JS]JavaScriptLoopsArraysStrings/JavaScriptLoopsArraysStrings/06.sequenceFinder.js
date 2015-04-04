"use strict";

var arr = [2,3,5,15,5,5,5,1,6,16,7,4,1,2,23,4,1,2,3,3,3,333,3,3,3,,3,3,3,3,3,3,3,333,3,,3,3,,3,3,33,3,3,,3];
console.log(findMaxSequence(arr));

function findMaxSequence(arr) {
    var count= 0;
    var value = 0;

    var maxSeq = 0;
    var maxSeqValue = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === arr[i+1]) {
            count++;
            value=arr[i];
        }
        else if (arr[i] !== arr[i+1]) {
            if (maxSeq < count) {
                maxSeq = count;
                maxSeqValue = value;
                count=0;
            }
        }
    }
    var bestSeq = [];
    for (var i = 0; i < maxSeq; i++) {
        bestSeq.push(maxSeqValue);
    }
    return bestSeq;
}