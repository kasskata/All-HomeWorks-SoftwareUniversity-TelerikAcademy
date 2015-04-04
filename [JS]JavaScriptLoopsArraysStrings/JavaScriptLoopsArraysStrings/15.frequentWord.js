"use strict";

var value = 'Welcome to SoftUni. Welcome to Java. Welcome everyone.';
findMostFreqWord(value);

function findMostFreqWord(input) {
    var text = input.toLowerCase().split(/\W/).filter(Boolean);
    var count = new Array(text.length);
    var maxCount=0;
    for (var i = 0; i < text.length; i++) {
        count[i] = 1;
    }
    for (var i = 0; i < text.length; i++) {
        for (var j = i + 1; j < text.length; j++) {
            if (text[i] === text[j]) {
                count[i]++;
            }
            if (maxCount < count[i]) {
                maxCount = count[i];
            }
        }
    }
    for (var i = 0; i < count.length; i++) {
        if (maxCount == count[i]) {
            console.log(text[i] + ' => '+maxCount+' times');
        }
    }
}