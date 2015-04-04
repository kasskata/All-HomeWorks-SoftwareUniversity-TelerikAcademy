"use strict";

var input = ['hello','mazni banici',2,33,45,654,1111];

console.log(findLargestBySumOfDigits(input));

function findLargestBySumOfDigits(input) {
    var sum = 0;
    var bestSum = 0;
    var bestValue = 0;
    for (var i = 0; i < input.length; i++) {
        if (input[i].length > 1 || input.length > 1) {
            input[i] = input[i].toString();
            if (input[i][0] === '-') {
                input[i] = (parseInt(input[i]) * -1).toString();
            }
            var value = input[i];
            for (var j = 0; j < input[i].length; j++) {
                sum += parseInt(input[i][j]);
            }
            if (bestSum < sum) {
                bestSum = sum;
                bestValue = value;
            }
            sum = 0;
        }
        else
        {
            return undefined;
        }
    }
    if (bestValue < 1) {
        return undefined;
    }
    return bestValue;
}