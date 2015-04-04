<?php
/**

 */
$rem = strtotime('2015-01-01 00:00:00') - time();
$day = floor($rem / 86400);
$hr  = floor(($rem % 86400) / 3600);
$min = floor(($rem % 3600) / 60);
$sec = ($rem % 60);

$allSec = $sec + ($min * 60) + (($hr * 60)*60) + ((($day * 24)*60)*60);
$allHours =($day * 24);
$allMin =($hr * 60) + (($day * 24)*60);

print "Hours until new year:  $allHours <br>";
print "Minutes until new year:  $allMin <br>";
print "Seconds until new year:  $allSec <br>";


if($day) echo "$day Days ";
if($hr) echo "$hr Hours ";
if($min) echo "$min Minutes ";
if($sec) echo "$sec Seconds ";