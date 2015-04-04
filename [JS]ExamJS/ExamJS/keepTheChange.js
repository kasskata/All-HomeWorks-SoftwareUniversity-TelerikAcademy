function solve(input) {
    var mood = input[1];
    var bill = Number(input[0]);
    var tip = calcChange(bill, mood);
    var first;
    var result = 1;
    console.log(tip);

    function calcChange(sum, mood) {
        switch (mood) {
            case 'happy':
                return (sum * 10 / 100).toFixed(2);
            case 'drunk':
                first = (sum * 15 / 100).toString()[0];
                var result = 1
                for (var i = 0; i < first; i += 1) {
                    result *= (sum * 15 / 100);
                }
                return result.toFixed(2);

            case 'married':
                return (sum * 0.05 / 100).toFixed(2);
            default :
                return (sum * 5 / 100).toFixed(2);
        }

    }
}

solve([
    1230.83,
    'drunk'
]);