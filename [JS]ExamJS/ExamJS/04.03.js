var args = [
    'Sirius 16 2',
    'Alpha-Centauri 2.6 4.8',
    'Gamma-Cygni 1.6 7',
    '2 5',
    '4'
];
solve(args);

function solve(args) {
    var arr = [];
    for (var i = 0; i < args.length; i++) {
        arr[i] = args[i].split(/\s+/).filter(Boolean);
    }
    console.log(arr);
    var sirius = [];
    sirius.push(arr[0][1]);
    sirius.push(arr[0][2]);
    var alpha = [];
    alpha.push(arr[1][1]);
    alpha.push(arr[1][2]);
    var gamma = [];
    gamma.push(arr[2][1]);
    gamma.push(arr[2][2]);
    var path = [arr[3][0], arr[3][1]];
    for (var i = -1; i < Number(arr[4]); i++) {
        if (
            (parseFloat(path[0]) >= parseFloat(sirius[0] - 1) && parseFloat(path[0]) == parseFloat(sirius[0] + 1)) &&
                (parseFloat(path[1]) >= parseFloat(sirius[1] - 1) && parseFloat(path[1]) <= parseFloat(sirius[1] + 1))
            ) {
            console.log(arr[0][0]);
        }
        else if (
            (parseFloat(path[0]) >= parseFloat(alpha[0] - 1) && parseFloat(path[0]) == parseFloat(alpha[0] + 1)) &&
                (parseFloat(path[1]) >= parseFloat(alpha[1] - 1) && parseFloat(path[1]) <= parseFloat(alpha[1] + 1))
            ) {
            console.log(arr[1][0]);
        }
        else if (
            (parseFloat(path[0]) >= parseFloat(gamma[0] - 1) && parseFloat(path[0]) == parseFloat(gamma[0] + 1)) &&
                (parseFloat(path[1]) >= parseFloat(gamma[1] - 1) && parseFloat(path[1]) <= parseFloat(gamma[1] + 1))
            ) {
            console.log(arr[2][0]);
        }
        else {
            console.log("space");
        }
        path[1]++;
    }
}
//Sirius 3 7
//Alpha-Centauri 7 5
//Gamma-Cygni 10 10
//8 1
//6
//(shipX >= siriusX - 1 && shipX <= siriusX + 1) &&
//(shipY >= siriusY - 1 && shipY <= siriusY + 1)