var input = '8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦';

console.log(findCardFrequency(input));

function findCardFrequency(inputString) {

    function getUniqueElements(arr) {
        var uniqueElements = [];

        for (var i in arr) {
            if (uniqueElements.indexOf(arr[i]) === -1) {
                uniqueElements.push(arr[i]);
            }
        }

        return uniqueElements;
    }

    var cards = inputString.split(/[♣♦♥♠ ]+/);
    var frequencies = [];

    cards.pop();
    for (var i in cards) {
        if (cards[i] in frequencies) {
            frequencies[cards[i]]++;
        } else {
            frequencies[cards[i]] = 1;
        }
    }

    var output = '';
    var cardsLength = cards.length;

    cards = getUniqueElements(cards);
    for (i in cards) {
        var percent = (frequencies[cards[i]] / cardsLength * 100).toFixed(2);
        output += cards[i] + ' -> ' + percent + '%\n';
    }

    return output;
}
