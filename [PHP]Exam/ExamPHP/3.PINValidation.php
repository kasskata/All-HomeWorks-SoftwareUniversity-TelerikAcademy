<?php
$name = explode(" ", $_GET['name']);
$gender = $_GET['gender'];
$pin = $_GET['pin'];

if (empty($name) || empty($gender)) {
    die("<h2>Incorrect data</h2>");
}
if (strlen($pin) < 10) {
    die("<h2>Incorrect data</h2>");
}
if (strtoupper($name[0][0]) !== $name[0][0] || strtoupper($name[1][0]) !== $name[1][0]) {
    die("<h2>Incorrect data</h2>");
}
if (validateFunction($pin, $gender)) {
    $result = array(
        "name" => $name[0] . ' ' . $name[1],
        "gender" => $gender,
        "pin" => $pin
    );
    echo json_encode($result);
} else {
    die("<h2>Incorrect data</h2>");
}

function validateFunction($pin, $gender)
{
    $arrWeights = [2, 4, 8, 5, 10, 9, 7, 3, 6];
    $year = ($pin[0] . $pin[1]);
    $month = ($pin[2] . $pin[3]);
    $day = ($pin[4] . $pin[5]);
    if ($month > 40) {
        $month -= 40;
        $year = "20" . $year;
    } else if ($month > 20) {
        $month -= 20;
        $year = "18" . $year;
    } else {
        $year = "19" . $year;
    }
    $dateString = $year.'-'.$month.'-'.$day;
    $date = date_create($year . "-" . $month . "-" . $day, timezone_open("Europe/Sofia"));
    if (!$date) {
        return false;
    }

    $gender1 = ($pin[strlen($pin) - 2] % 2 == 0) ? "male" : "female";
    if ($gender1 !== $gender) {
        return false;
    }
    $last = $pin[strlen($pin) - 1];
    $sum = 0;
    for ($i = 0; $i < strlen($pin) - 1; $i++) {
        $sum += $pin[$i] * $arrWeights[$i];
    }
    $sum = $sum % 11;
    if ($sum % 10 != $last) {
        return false;
    }
    return true;
}

