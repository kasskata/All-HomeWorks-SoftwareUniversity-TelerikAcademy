"use strict";

var persons = [
    { firstName: 'George', lastName: 'Kolev', age: 32},
    { firstName: 'Bay', lastName: 'Ivan', age: 81},
    { firstName: 'Baba', lastName: 'Ginka', age: 40}
]
findYoungestPerson(persons);

function findYoungestPerson() {
    var age = 0;
    var best = 200;
    for (var i = 0; i < persons.length; i++) {
        age = persons[i].age;
        if (best > age) {
            best = age;
        }
    }
    for (var i = 0; i < persons.length; i++) {
        age = persons[i].age;
        if (age == best) {
            console.log('The youngest person is ' + persons[i].firstName + ' ' + persons[i].lastName);
        }
    }
}