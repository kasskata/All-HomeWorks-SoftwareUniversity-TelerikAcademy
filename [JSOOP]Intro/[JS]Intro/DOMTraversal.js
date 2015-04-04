"use strict";

function getDescendantWithClass(element, clName) {
    var children = document.getElementsByClassName(clName).childNodes;
    for (var i = 0; i < children.length; i++) {
        if (children[i].className &&
            children[i].className.split(' ').indexOf(clName) >= 0)
        {
            return children[i];
        }
    }
    for (var i = 0; i < children.length; i++) {
        var match = getDescendantWithClass(children[i], clName);
        if (match !== null) {
            return match;
        }
    }
    return null;
}

var selector = ".birds";
selector = selector.split('').splice(1,selector.length-1).join('');
var results = getDescendantWithClass("article",selector);
console.log(results);