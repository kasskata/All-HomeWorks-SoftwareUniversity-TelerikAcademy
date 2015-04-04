function solve(input) {
    var i;
     var x = input[0].split(' ').filter(Boolean);
     var y = input[1].split(' ').filter(Boolean);
     var move = input[2].split(' ').filter(Boolean);
     var normandyCoords = input[3].split(' ').filter(Boolean);
     var turns = Number(input[4]);
     var sirius = x[0].toLowerCase();
     var siriusX = Number(x[1]);
     var siriusY = Number(x[2]);
     var alpha = y[0].toLowerCase();
     var alphaX = Number(y[1]);
     var alphaY = Number(y[2]);
     var gamma = move[0].toLowerCase();
     var gammaX = Number(move[1]);
     var gammaY = Number(move[2]);
     var shipX = Number(normandyCoords[0]);
     var shipY = Number(normandyCoords[1]);
    for (i = 0; i <= turns; i += 1) {
        if (
            (shipX >= siriusX - 1 && shipX <= siriusX + 1) &&
            (shipY >= siriusY - 1 && shipY <= siriusY + 1)
            ) {
            console.log(sirius)
        } else if (
            (shipX >= alphaX - 1 && shipX <= alphaX + 1) &&
            (shipY >= alphaY - 1 && shipY <= alphaY + 1)
            ) {
            console.log(alpha)
        } else if (
            (shipX >= gammaX - 1 && shipX <= gammaX + 1) &&
            (shipY >= gammaY - 1 && shipY <= gammaY + 1)
            ) {
            console.log(gamma)
        } else {
            console.log('space')
        }
        shipY += 1;
    }
}

solve(
    [ 'Terra-Nova 16 2', 'Perseus 2.6 4.8', 'Virgo 1.6 7', '2 5', '4' ]
);