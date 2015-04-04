"use strict";

var arr = [3, 5, 4, 6, 1, 2, 3, 6, 10, 32];
findMaxSequence(arr);

function findMaxSequence(arr) {
    var count = 0;
    var value = 0;
    var temp = [];
    var maxSeq = 0;
    var maxSeqValue = [];
    for (var i = 0; i < arr.length; i++) {
        for (var j = i; j < arr.length; j++) {
            if (arr[j] < arr[j + 1]) {
                temp.push(arr[j]);
                count++;
            }
            else {
                if (temp[temp.length - 1] < arr[j]) {
                    temp.push(arr[j]);
                }
                maxSeqValue.push(temp);
                temp = [];
            }
        }
    }
    for (var i = 0; i < maxSeqValue.length; i++) {
        if (maxSeqValue[i].length > maxSeq) {
            maxSeq = maxSeqValue[i].length;
        }
    }
    for (var i = 0; i < maxSeqValue.length; i++) {
        if (maxSeq === 0) {
            console.log('no');
            break;
        }
        else if (maxSeqValue[i].length == maxSeq) {
            console.log(maxSeqValue[i]);
            break;
        }
    }

}