var input = [
    "bb",
    "bbb",
    "bbbb",
    "a",
    "aaa",
    "aaaa",
    "xxxxx",
    "aaxxxa"
];
solve(input);
//____________________________________________________________________


function solve(args) {
    var input = args;
    var count = 0;
    var bestCount = 0;
    for (var i = 0; i < input.length; i++) {
        count = input[i].length;
        if (count > bestCount) {
            bestCount = count;
        }
    }
    for (var i = 0; i < input.length; i++) {
        if (input[i].length < bestCount) {
            var temp = new Array(bestCount + 1 - input[i].length).join(' ');
            input[i] = input[i] + temp;
        }
    }
    var result = new Array(input.length);
    for (var i = 0; i < input.length; i++) {
        result[i] = input[i];
    }
    for (var i = 0; i < input.length - 1; i++) {
        for (var j = 1; j < input[i].length - 1; j++) {

            if ((input[i][j] == input[i + 1][j + 1] &&
                input[i][j] == input[i + 1][j - 1] &&
                input[i][j] == input[i + 1][j]) &&
                input[i][j] !== ' ')
            {

                result[i] = replaceAt(result[i], j, '*');
                result[i + 1] = replaceAt(result[i + 1], j + 1, '*');
                result[i + 1] = replaceAt(result[i + 1], j - 1, '*');
                result[i + 1] = replaceAt(result[i + 1], j, '*');
            }
        }
    }
    for (var val in result) {
        console.log(result[val].trim());
    }
    function replaceAt(s, n, t) {
        return s.substring(0, n) + t + s.substring(n + 1);
    }
}
