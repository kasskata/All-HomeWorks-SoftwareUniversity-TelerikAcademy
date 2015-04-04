var args = [
    '<table>',
    '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
    '<tr><td>Sofia</td><td>0</td><td>-</td><td>0.0</td></tr>',
    '<tr><td>Yambol</td><td>-</td><td>0</td><td>-</td></tr>',
    '<tr><td>Sliven</td><td>-</td><td>0</td><td>-</td></tr>',
    '<tr><td>Kaspichan</td><td>0</td><td>-</td><td>-</td></tr>',
    '</table>'


];

solve(args);

function solve(args) {
    var arr = [];
    var bestSum;
    bestSum = -1000000;
    var text = '';

    for (var i = 0; i < args.length; i++) {
        var sum = null;
        arr[i] = args[i].split(/<td>|<\/td>|<tr>|<\/tr>/g).filter(Boolean);
        if (Number(arr[i][1])) {
            sum += Number(arr[i][1]);
        }
        if (Number(arr[i][2])) {
            sum += Number(arr[i][2]);
        }
        if (Number(arr[i][3])) {
            sum += Number(arr[i][3]);
        }
        if (sum > bestSum && i > 1 && i < args.length - 1 && sum !== null) {
            bestSum = sum;
            text = '' + sum + ' = ';
            if (arr[i][1] != '-') {
                if (arr[i][2] != '-') {
                    text += arr[i][1] + ' + ';
                } else if (arr[i][3] != '-') {
                    text += arr[i][1] + ' + ';
                } else {
                    text += arr[i][1];
                }
            } else {
                text += '';
            }
            if (arr[i][2] != '-') {
                if (arr[i][3] != '-') {
                    text += arr[i][2] + ' + ';
                } else {
                    text += arr[i][2];
                }
            } else {
                text += '';
            }
            if (arr[i][3] != '-') {
                if (arr[i][2] != '-') {
                    text += arr[i][3];
                } else {
                    text += arr[i][3];
                }
            } else {
                text += '';
            }
        }
    }
    if (text == '') {
        console.log("no data");
    } else {
        console.log(text);
    }
}
