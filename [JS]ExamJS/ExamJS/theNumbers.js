function solve(input) {
    var numbersInput = input[0].split(/[^\d]+/).filter(Boolean);
    var arrNew = [];
    var number = 0;
    var hex;
    var result;
    var output;

    for (var i = 0; i < numbersInput.length; i ++) {

        number = Number(numbersInput[i]);
        hex = number.toString(16);
        var pad = '0000';
        result = '0x' + ((pad + hex).slice(-pad.length)).toUpperCase();
        arrNew.push(result);
    }

    output = arrNew.join('-');

    console.log(output);
}

solve([ '5tffwj(//*7837xzc2---34rlxXP%$".' ]);