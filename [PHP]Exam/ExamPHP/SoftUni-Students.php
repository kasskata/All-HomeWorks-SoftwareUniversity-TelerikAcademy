<?php
$students = $list = preg_split('/\n/', $_GET['students'], -1, PREG_SPLIT_NO_EMPTY);

$column = $_GET['column'];
$order = $_GET['order'];


$user = [];
$user[] = '';
$columns = ['id', 'username', 'email', 'type', 'result'];
$result = [];

for ($i = 0; $i < count($students); $i++) {
    $students[$i] = $i + 1 . ', ' . $students[$i];
    $students[$i] = trim($students[$i]);
    $students[$i] = htmlspecialchars($students[$i]);
    $user[] = explode(', ', $students[$i]);
}
unset($user[0]);

foreach ($user as $key => $val) {
    $result[] = array_combine($columns, $user[$key]);
}
switch ($order) {
    case 'ascending':
        ascendingBy($column);
        break;

    case 'descending':
        descendingBy($column);
        break;
}

function ascendingBy($column)
{
    global $result;
    switch ($column) {
        case'result':
        {
            $sortArray = array();
            foreach ($result as $person) {
                foreach ($person as $key => $value) {
                    if (!isset($sortArray[$key])) {
                        $sortArray[$key] = array();
                    }
                    $sortArray[$key][] = $value;
                }
            }
            $orderby = "result";
            array_multisort($sortArray[$orderby], SORT_ASC, $result);

        }
            break;
        case'username':
        {
            $sortArray = array();
            foreach ($result as $person) {
                foreach ($person as $key => $value) {
                    if (!isset($sortArray[$key])) {
                        $sortArray[$key] = array();
                    }
                    $sortArray[$key][] = $value;
                }
            }
            $orderby = "username";
            array_multisort($sortArray[$orderby], SORT_ASC ,$sortArray['id'],SORT_ASC, $result);
        }
            break;
        case'id':
        {
            $sortArray = array();
            foreach ($result as $person) {
                foreach ($person as $key => $value) {
                    if (!isset($sortArray[$key])) {
                        $sortArray[$key] = array();
                    }
                    $sortArray[$key][] = $value;
                }
            }
            $orderby = "id";
            array_multisort($sortArray[$orderby], SORT_ASC, $result);

        }
            break;
    }
}

function descendingBy($column)
{
    global $result;
    switch ($column) {
        case'result':
        {
            $sortArray = array();
            foreach ($result as $person) {
                foreach ($person as $key => $value) {
                    if (!isset($sortArray[$key])) {
                        $sortArray[$key] = array();
                    }
                    $sortArray[$key][] = $value;
                }
            }
            $orderby = "result";
            array_multisort($sortArray[$orderby], SORT_DESC,$sortArray['id'],SORT_DESC, $result);

        }
            break;
        case'username':
        {
            $sortArray = array();
            foreach ($result as $person) {
                foreach ($person as $key => $value) {
                    if (!isset($sortArray[$key])) {
                        $sortArray[$key] = array();
                    }
                    $sortArray[$key][] = $value;
                }
            }
            $orderby = "username";
            array_multisort($sortArray[$orderby], SORT_DESC, $result);

        }
            break;
        case'id':
        {
            $sortArray = array();
            foreach ($result as $person) {
                foreach ($person as $key => $value) {
                    if (!isset($sortArray[$key])) {
                        $sortArray[$key] = array();
                    }
                    $sortArray[$key][] = $value;
                }
            }
            $orderby = "id";
            array_multisort($sortArray[$orderby], SORT_DESC, $result);

        }
            break;
    }
}

function sortByResultD($a, $b)
{
    return $b['result'] - $a['result'];
}

function sortByResultA($a, $b)
{
    return $a['result'] - $b['result'];
}

function sortByIDA($a, $b)
{
    return $a['result'] - $b['result'];
}

function sortByIDD($a, $b)
{
    return $b['result'] - $a['result'];
}

echo "<table><thead><tr><th>Id</th><th>Username</th><th>Email</th><th>Type</th><th>Result</th></tr></thead>";
foreach ($result as $key => $user) {
    echo("<tr>");
    foreach ($user as $field => $val) {
        echo("<td>$user[$field]</td>");
    }
    echo("</tr>");
}
echo "</table>";
