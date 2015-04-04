function sortTable(input) {
    var rows = [];
    for (var i = 2; i < input.length - 1; i++) {
        var rowData = input[i];
        var regex = /<td>.*?<\/td><td>(.*?)<\/td>/g;
        var match = regex.exec(rowData);
        var price = Number(match[1]);
        var row = { price: price, data: rowData };
        rows.push(row);
    }
    rows.sort(function (a, b) {
        if (a.price != b.price) {
            return a.price - b.price;
        } else {
            return a.data == b.data ? 0 : a.data < b.data ? -1 : 1;
        }
    });
    console.log(input[0]);
    console.log(input[1]);
    for (var i = 0; i < rows.length; i++) {
        console.log(rows[i].data);
    }
    console.log(input[input.length - 1]);
}


