var args = [
    "<table>",
    "<tr><th>Product</th><th>Price</th><th>Votes</th></tr>",
    "<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>",
    "<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>",
    "<tr><td>Laptop Lenovo IdeaPad B5400</td><td>929.00</td><td>0</td></tr>",
    "<tr><td>Laptop ASUS ROG G550JK-CN268D</td><td>1939.00</td><td>+1</td></tr>",
    "<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>",
    "<tr><td>Coffee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>",
    "<tr><td>Kamenitza Lemon 1 l</td><td>1.65</td><td>+7</td></tr>",
    "<tr><td>Vodka Absolute 1 l</td><td>22.00</td><td>+2</td></tr>",
    "<tr><td>Laptop Dell Inspiron 3537</td><td>1199.0</td><td>+3</td></tr>",
    "<tr><td>Laptop HP 250 G2</td><td>629</td><td>-10</td></tr>",
    "<tr><td>Ariana Radler 1.5 l</td><td>2.79</td><td>+33</td></tr>",
    "<tr><td>Coffee Lavazza 250 gr.</td><td>8.73</td><td>+10</td></tr>",
    "</table>"
];

solve(args);

function solve(args) {
    var products = [];

    for (var i = 0; i < args.length; i++) {
        products[i] = args[i].split(/<td>|<\/td>|<tr>|<\/tr>|<th>|<\/th>|<table>|<\/table>/g).filter(Boolean);
    }
    products.pop();
    products.shift();
    products.shift();
    for (var i = 0; i < products.length; i++) {
        var temp = products[i][1];
        products[i][1] = Number(temp);
        console.log(products[i][1]);
        move(products[i], 0, 1);
    }
    products.sort(function (a, b) {
        a = parseFloat(a);
        b = parseFloat(b);

        return a - b;
    });
    for (var i = 0; i < products.length; i++) {
        move(products[i], 0, 1);
    }
    console.log("<table>");
    console.log("<tr><th>Product</th><th>Price</th><th>Votes</th></tr>");
    for (var i = 0; i < products.length; i++) {
        var text = "<tr>";
        for (var j = 0; j < products[i].length; j++) {
            text += "<td>" + products[i][j] + "</td>";
        }
        text += "</tr>";
        console.log(text);
    }
    console.log("</table>");
    function move(arr, old_index, new_index) {
        if (new_index >= arr.length) {
            var k = new_index - arr.length;
            while ((k--) + 1) {
                arr.push(undefined);
            }
        }
        arr.splice(new_index, 0, arr.splice(old_index, 1)[0]);
        return arr;
    }
}
