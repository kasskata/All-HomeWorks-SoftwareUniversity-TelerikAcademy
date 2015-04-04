var args = [
    'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
];

solve(args);

function solve(args) {
    var arr = [];
    for (var i = 0; i < args.length; i++) {
        arr[i] = args[i].split('|');
        for (var j = 0; j < arr[i].length; j++) {
            arr[i][j] = arr[i][j].trim();
        }
        arr[i].splice(2, 1);
    }
    var concertInfo = {};

    for (var val in arr) {
        var band = arr[val][0];
        var city = arr[val][1];
        var place = arr[val][2];

        if (!concertInfo[city]) {
            concertInfo[city] = {};
        }
        if (!concertInfo[city][place]) {
            concertInfo[city][place] = [];
        }
        if(concertInfo[city][place].indexOf(band)==-1){
            concertInfo[city][place].push(band);
        }
    }
    concertInfo = sortObjectProperties(concertInfo);
    for (var city in concertInfo) {
        concertInfo[city] = sortObjectProperties(concertInfo[city]);
        for (var place in concertInfo[city]) {
            concertInfo[city][place].sort();
        }
    }
    function sortObjectProperties(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }

    console.log(JSON.stringify(concertInfo));
}