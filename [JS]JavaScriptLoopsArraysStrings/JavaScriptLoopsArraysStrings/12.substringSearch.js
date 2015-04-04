"use strict";

var keyValue = ['in', "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."];
console.log(countSubstringOccur(keyValue));
function countSubstringOccur(keyValue) {
    var substr = keyValue[0];
    var str = keyValue[1];
    var strToLower = str.toLowerCase();

    var re = new RegExp(substr, 'g'); //create a regex to match
    var count = strToLower.match(re);

    return count.length;
}
