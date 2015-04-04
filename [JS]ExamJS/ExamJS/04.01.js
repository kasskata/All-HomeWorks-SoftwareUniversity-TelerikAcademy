var args = [
    '1230.83',
    'drunk'
];
solve(args);

function solve(args) {
    var number=Number(args[0]);
    var mood = args[1];

    if(mood == 'happy'){
        number = number * 10 / 100;
        console.log(number.toFixed(2));
    }else if(mood == 'married'){
        number = number * 0.05 / 100;
        console.log(number.toFixed(2));
    } else if(mood == 'drunk'){
        var  first = (number * 15 / 100).toString()[0] != 0 ?(number * 15 / 100).toString()[0] :1;
        number = (number * 15 / 100);
        number = Math.pow(number,first);
        console.log(number.round((number*100))/100);
    }else{
        number = number * 15 / 100;
        console.log(number.toFixed(2));
    }
}
    //Math.round((lessons[val]['avgGrade'] / stud[val]['visited'].length) * 100)}