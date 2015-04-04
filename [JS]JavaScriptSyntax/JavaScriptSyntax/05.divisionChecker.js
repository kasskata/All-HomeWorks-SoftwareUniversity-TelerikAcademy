"use strict";

evenNumber(591);

function evenNumber(value){
    if (value % 3 === 0) {
        console.log('the number is divided by 3 without remainder');
    }
    else{
        console.log('the number is not divided by 3 without remainder');
    }
}