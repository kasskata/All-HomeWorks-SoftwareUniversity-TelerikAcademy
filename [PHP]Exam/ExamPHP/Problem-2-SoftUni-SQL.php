<?php
$commands = $_GET['commands'];
$error;
$error = 0;
$users;
$users = [];
foreach ($commands as &$command) {
    if (substr($command, 0, 6) == 'INSERT') {
        insert($command);
    } else if (substr($command, 0, 6) == 'UPDATE') {
        update($command);
    } else if (substr($command, 0, 6) == 'DELETE') {
        delete($command);
    } else {
        $error++;
    }
}
foreach ($users as &$user) {
    krsort($user);
}


//FUNCTIONS
function delete($command){
    global $error;
    global $users;

    $pattern = '/\(\w*\s=\s*\w*\)/';
    preg_match_all($pattern, $command, $insertInfo);
    $insertInfo = $insertInfo[0];
    $whereTo = preg_split('/[\(\)=\s]/', $insertInfo[0], 0, PREG_SPLIT_NO_EMPTY);

    if ($whereTo[0] == 'user_id') {
        if (isset($users[$whereTo[1]])) {
            unset($users[$whereTo[1]]);
        } else {
            $error++;
        }
    } else {
        foreach ($users as $key => &$user) {
            if(array_key_exists($whereTo[0],$user)&& in_array($whereTo[1],$user)){
                unset($users[$key]);
            }
        }

    }
}

function update($command)
{
    global $error;
    global $users;

    $pattern = '/\(\w*\s=\s*\w*\)/';
    preg_match_all($pattern, $command, $insertInfo);
    $insertInfo = $insertInfo[0];
    $change = preg_split('/[\(\)=\s]/', $insertInfo[0], 0, PREG_SPLIT_NO_EMPTY);
    $whereTo = preg_split('/[\(\)=\s]/', $insertInfo[1], 0, PREG_SPLIT_NO_EMPTY);

    if ($whereTo[0] == 'user_id') {
        if (isset($users[$whereTo[1]])) {
            $users[$whereTo[1]][$change[0]] = $change[1];
        } else {
            $error++;
        }
    } else {
        foreach ($users as &$user) {
            foreach ($user as $field => $val) {
                if ($field == $whereTo[0] && $val == $whereTo[1]) {
                    $user[$change[0]] = $change[1];
                }
            }
        }

    }
}

function insert($command)
{
    global $users;
    global $error;

    $index_value = 0;
    $index = 0;
    preg_match('/(\(.*,.*\)\s)/', $command, $insertInfo);
    $escaper = preg_filter('/[() ]/', '', $insertInfo);
    $insertInfo = preg_split('/,/', $escaper[0]);
    if (in_array('login', $insertInfo)) {
        preg_match('/VALUES \(.*,.*\)/', $command, $values);
        $escaper = preg_filter('/[VALUES \(.*.*\)]/', '', $values);
        $values = preg_split('/,/', $escaper[0]);
        if (count($values) === count($insertInfo)) {
            if (in_array('user_id', $insertInfo)) {
                $index_value = $values[array_search('user_id', $insertInfo)];
                $index = array_search('user_id', $insertInfo);
                unset($insertInfo[$index]);
                unset($values[$index]);
                if (!isset($users[$index_value])) {
                    $users[$index_value] = array_combine($insertInfo, $values);
                } else {
                    $error++;
                }
            } else {
                $users[] = array_combine($insertInfo, $values);
                end($users);
                $index_value = (int)key($users);

            }
            if (!array_key_exists('age', $users[$index_value])) {
                $users[$index_value]['age'] = 'undefined';
            }
            if (!array_key_exists('gender', $users[$index_value])) {
                $users[$index_value]['gender'] = 'undefined';
            }
        } else {
            $error++;
        }
    } else {
        $error++;
    }
}
if(!empty($users)){
echo"<table><thead><tr><th>user_id</th><th>login</th><th>gender</th><th>age</th></tr></thead><tbody>";
       foreach ($users as $key => $user) {
        echo("<tr>");
        echo"<td>". $key ."</td>";
            foreach ($user as $field => $val) {
                echo("<td>$user[$field]</td>");
            }
            echo("</tr>");
         }
    echo("</tbody><tfoot><tr><td colspan=\"4\">Errors=$error</td></tr></tfoot></table>");
}else{
   echo("You have $error error/s");
}