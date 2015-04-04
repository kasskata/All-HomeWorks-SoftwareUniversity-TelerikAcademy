<html>
<head>
    <title></title>
</head>
<body>
<?php
/**
 * Write a PHP script InformationTable.php which generates an HTML
 * table by given information about a person (name, phone
 * number, age, address). Styling the table is optional.
 * Semantic HTML is required.
 */
$firstName = 'Gosho';
$phoneNumber = '08878965543';
$age = 26;
$address = 'Hadji Dimityr';

?>
<table>
<tr style="border:1px solid black">
    <td style="background-color:orange; text-align:left">
        Name:
    </td>
    <td style="text-align:right">
        <?=$firstName?>
    </td>
</tr>
<tr style="border:1px solid black">
    <td style="background-color:orange; text-align:left">
       Phone Number:
    </td>
    <td style="text-align:right">
        <?=$phoneNumber?>
    </td>
</tr>
<tr style="border:1px solid black">
    <td style="background-color:orange; text-align:left">
        Age:
    </td>
    <td style="text-align:right">
        <?=$age?>
    </td>
</tr>
<tr style="border:1px solid black">
    <td style="background-color:orange; text-align:left">
        Address:
    </td>
    <td style="text-align:right">
        <?=$address?>
    </td>
</tr>
</table>
</body>