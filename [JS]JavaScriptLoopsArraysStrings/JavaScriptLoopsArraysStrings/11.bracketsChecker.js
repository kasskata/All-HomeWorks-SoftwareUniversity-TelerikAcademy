"use strict";

var input = '( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )';
bracketsChecker(input);

function bracketsChecker(input) {
    var count = 0;
    for (var i = 0; i < input.length;i++){
        if (input[i] == '(') {
            count++;
        }
        else if(input[i]==')'){
            count--;
        }
    }
    if (count == 0) {
        console.log('Correct');
    }
    else{
        console.log('Incorrect');
    }
}