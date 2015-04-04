var args = [
    '<!DOCTYPE html>',
    '<html>',
    '<head>',
    '  <title>Hyperlinks</title>',
    '<link href="theme.css" rel="stylesheet" />',
    '</head>',
    '<body>',
    '<ul><li><a   href="/"  id="home">Home</a></li><li><a',
    'class="selected" href=/courses>Courses</a>',
    '</li><li><a href =',
    '\'/forum\' >Forum</a></li><li><a class="href"',
    'onclick="go()" href= "#">Forum</a></li>',
    '<li><a id="js" href =',
    'javascript:alert(\'hi yo\')" class="new">click</a></li>',
    '<li><a id=\'nakov\' href =',
    'http://www.nakov.com class=\'new\'>nak</a></li></ul>',
    '<a href="#empty"></a>',
    '<a id="href">href=\'fake\'<img src=\'http://abv.bg/i.gif\'',
    'alt=\'abv\'/></a><a href="#">&lt;a href=\'hello\'&gt;</a>',
    '<!-- This code is commented:',
    '<a href="#commented">commentex hyperlink</a> -->',
    '</body>'
];
solve(args);

function solve(args) {
    var input = args;
    var matches = [];
    var pattern = /<a\s+([^>]+\s+)?href\s*=\s*('([^']*)'|"([^"]*)|([^\s>]+))[^>]*>/;
    for (var i = 0; i < input.length; i++) {
        matches[i] = input[i].match(pattern);
        if (input[i].match(pattern) !== null) {
            if (matches[i][3] !== undefined) {
                console.log(matches[i][3]);
            }
            if (matches[i][4] !== undefined) {
                console.log(matches[i][4]);
            }
            if (matches[i][5] !== undefined) {
                console.log(matches[i][5]);
            }
        }
    }
//    matches = matches.filter(function(e){return e});
}