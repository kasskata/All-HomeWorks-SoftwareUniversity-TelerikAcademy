function numbersOnly() {
    var inputNumbers = document.getElementById('numbers').value;

    if (inputNumbers.charCode < 48 || inputNumbers.charCode > 57) {
        document.getElementById('number').style.backgroundColor = "red";
    }
}