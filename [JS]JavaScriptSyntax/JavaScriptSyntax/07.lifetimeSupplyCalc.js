"use strict";

var myFavoriteFood = {age: 38, maxAge: 118, favoriteFood: "chocolate", amount:0.5};

console.log(calcSupply(myFavoriteFood));

function calcSupply(value){

    return (value.amount * ((value.maxAge - value.age)*365)+"kg of "+value.favoriteFood+" would be enough until I am "+ value.maxAge+" years old.");
}