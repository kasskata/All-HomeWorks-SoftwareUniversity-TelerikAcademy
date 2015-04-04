"use strict";

var input = ['<!DOCTYPE html>',
    '<html>',
    '<head lang="en">',
    '<meta charset="UTF-8">',
    '<title>index</title>',
    '<script src="/yourScript.js" defer></script>',
    '</head>',
    '<body>',
    '<div id="outerDiv">',
    '<div',
    'class="first">',
    '<div><div>hello</div></div>',
    '</div>',
    '<div>hi<div></div></div>',
    '<div>I am a div</div>',
    '</div>',
    '</body>',
    '</html>'];

countOfDivs(input);

function countOfDivs(input) {
    var html = input.join(' ');
    var count = 0;
    for (var i = 0; i < html.length; i++) {
        if (html.indexOf("<div",i) != -1) {
            count ++;
            i = html.indexOf("<div",i);
        }
    }
    console.log(count);
}