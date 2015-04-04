"use strict"

function f(names, age, id) {
    console.log(f.toString());
    console.log(f.length);
    console.log(typeof names);
    console.log(typeof age);
    console.log(typeof id);
    console.log(this);
    print();

    function print() {
        console.log(this);
    }
}

f.call("name", 12, "id");
f.call("name");
f.call(12);
var r = f.apply(["id", "name", "Pesho"]);
console.log(this);