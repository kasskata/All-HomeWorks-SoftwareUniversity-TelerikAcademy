var args = [
    '1.33',
    '1.35',
    '2.25',
    '13.00',
    '0.5',
    '0.51',
    '0.5',
    '0.5',
    '0.33',
    '1.05',
    '1.346',
    '20',
    '900',
    '1500.1',
    '1500.10',
    '2000'
];
solve(args);

function solve(args) {
    console.log("<table>");
    console.log("<tr><th>Price</th><th>Trend</th></tr>");
    for (var i = 0; i < args.length; i++) {
        var text = '';
        text += "<tr>";

        var moved = '';
        var proto1 = Number(args[i]);
        var number = proto1.toFixed(2);
        var proto2 = Number(args[i-1]);
        var before = proto2.toFixed(2);

        if (i == 0 || (Number(number) == Number(before) )) {
            moved = '<img src="fixed.png"/>';
        } else if (Number(number)  > Number(before) ) {
            moved = '<img src="up.png"/>';
        } else if (Number(number)  < Number(before) ) {
            moved = '<img src="down.png"/>';
        }

        text += "<td>" + number + "</td>" + "<td>" + moved + "</td>";
        text += "</td>";
        console.log(text);
    }

    console.log("</table>");
}