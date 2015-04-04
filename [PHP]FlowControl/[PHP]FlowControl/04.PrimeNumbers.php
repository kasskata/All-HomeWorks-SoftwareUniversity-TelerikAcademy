<form method="get">
    <label for="index">Starting index:</label>
    <input type="number" name="index">

    <label for="end">End:</label>
    <input name="end" type="text">

    <input type="submit" name="submit">
</form>
<?php
if (isset($_GET['index']) && isset($_GET['end'])) {
    $start = $_GET['index'];
    $fin = $_GET['end'];

    for ($i = $start; $i <= $fin; $i++) {
        if ($i % 2 != 0 &&
            $i % 3 !== 0 &&
            $i % 5 !== 0 &&
            $i % 7 !== 0 &&
            $i % 11 != 0
        ) {
            echo('<strong>' . $i . '</strong>' . ', ');
        } else {
            echo('<span>' . $i . '</span>' . ', ');
        }
    }
}