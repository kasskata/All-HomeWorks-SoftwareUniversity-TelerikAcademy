var args = [
    'ooooo',
    'ooooo',
    'ooooo',
    'ooooo'
];
solve(args);

function solve(args) {
    var result = {"I": 0, "L": 0, "J": 0, "O": 0, "Z": 0, "S": 0, "T": 0};
    var arr = [];
    for (var i = 0; i < args.length; i++) {
        arr[i] = args[i].split('');
    }
    //search I ================================================
    for (var i = 0; i < arr.length - 3; i++) {
        for (var j = 0; j < arr[i].length; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i][j] == arr[i + 1][j] &&
                    arr[i + 1][j] == arr[i + 2][j] &&
                    arr[i + 2][j] == arr[i + 3][j]) {
                    result['I']++;
                }
            }
        }
    }
    //search L ================================================
    for (var i = 0; i < arr.length - 2; i++) {
        for (var j = 0; j < arr[i].length - 1; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i][j] == arr[i + 1][j] &&
                    arr[i + 1][j] == arr[i + 2][j] &&
                    arr[i + 2][j] == arr[i + 2][j + 1]) {
                    result['L']++;
                }
            }
        }
    }
    //search J ================================================
    for (var i = 0; i < arr.length - 2; i++) {
        for (var j = 1; j < arr[i].length; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i][j] == arr[i + 1][j] &&
                    arr[i + 1][j] == arr[i + 2][j] &&
                    arr[i + 2][j] == arr[i + 2][j - 1]) {
                    result['J']++;
                }
            }
        }
    }
    //search O ================================================
    for (var i = 0; i < arr.length - 1; i++) {
        for (var j = 0; j < arr[i].length - 1; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i][j] == arr[i + 1][j] &&
                    arr[i + 1][j] == arr[i + 1][j + 1] &&
                    arr[i + 1][j + 1] == arr[i][j + 1]) {
                    result['O']++;
                }
            }
        }
    }
    //search Z ================================================
    for (var i = 0; i < arr.length - 1; i++) {
        for (var j = 0; j < arr[i].length - 2; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i][j] == arr[i][j + 1] &&
                    arr[i][j + 1] == arr[i + 1][j + 1] &&
                    arr[i + 1][j + 1] == arr[i + 1][j + 2]) {
                    result['Z']++;
                }
            }
        }
    }
    //search S ================================================
    for (var i = 0; i < arr.length - 1; i++) {
        for (var j = 1; j < arr[i].length - 1; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i + 0][j + 0] == arr[i + 1][j - 1] &&
                    arr[i + 1][j - 1] == arr[i + 1][j + 0] &&
                    arr[i + 1][j + 0] == arr[i + 0][j + 1]) {
                    result['S']++;
                    //4
                }
            }
        }
    }
    //search T ================================================
    for (var i = 0; i < arr.length -1; i++) {
        for (var j = 0; j < arr[i].length-2; j++) {
            if (arr[i][j] == 'o') {
                if (arr[i][j] == arr[i + 0][j + 1] &&
                    arr[i + 0][j + 1] == arr[i + 0][j + 2] &&
                    arr[i + 0][j + 1] == arr[i + 1][j + 1]) {
                    result['T']++;
                    //1
                }
            }
        }
    }
    console.log(JSON.stringify(result));
}