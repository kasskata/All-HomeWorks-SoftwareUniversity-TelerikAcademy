<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04.Grid.aspx.cs" Inherits="_01.Exersise._04_Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css">
        .auto-style2 {
            width: 181px;
        }
        .auto-style4 {
            width: 168px;
        }
        .auto-style5 {
            width: 155px;
        }
        .auto-style6 {
            width: 165px;
        }
    </style>
     <!-->Dont know CSS<!-->
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Drag a column header and drop it here to group by that column</h2>
        <table border="1" cellpadding="0" cellspacing="0">
            <thead>
                <th>
                    ProductID
                </th>
                <th class="auto-style5">
                    Product name
                </th>
                <th class="auto-style4">
                    Unit price
                </th>
                <th>
                    Quantity per unit
                </th>
                <th class="auto-style2">
                    Units in stock
                </th>
                <th class="auto-style6">
                    Discontinued
                </th>
            </thead>
            <tr>
                <td>
                    <input type="number" name="ProductID" style="width: 75px"/>
                </td>
                <td class="auto-style5">
                    <input type="text" name="ProductNameBox" style="width: 274px"/>
                </td>
                <td class="auto-style4">
                    <input type="number" name="UnitPrice" style="width: 107px"/>
                    <input type="image" src="Untitled.png" name="Reset" />
                </td>
                <td>
                    <input type="text" name="QuantityPerUnit"/>
                </td>
                <td class="auto-style2">
                    <input type="number" name="UnitsInStock" style="width: 140px"/>
                    <input type="image" src="Untitled.png" name="Reset" />
                </td>
                <td class="auto-style6" align="center">
                    <input type="checkbox" name="DiscountedCheckBox" />
                    <input type="image" src="Untitled.png" name="Reset"/>
                </td>
            </tr>
            <tr>
                <td>
                    1
                </td>
                <td class="auto-style5">
                    Chai
                </td>
                <td>
                    $18.00
                </td>
                <td>
                    10 boxes x20 bags
                </td>
                <td>
                    39
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    2
                </td>
                <td class="auto-style5">
                    Chang
                </td>
                <td>
                    $19.00
                </td>
                <td>
                    24-12oz bottles
                </td>
                <td>
                    17
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    3
                </td>
                <td class="auto-style5">
                    Aniseed Syrup
                </td>
                <td>
                    $10.00
                </td>
                <td>
                    12-550ml bottles
                </td>
                <td>
                    13
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    4
                </td>
                <td class="auto-style5">
                    Chef Anton's Cajun Seasoning
                </td>
                <td>
                    $22.00
                </td>
                <td>
                    48-6 oz Jars
                </td>
                <td>
                    53
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    5
                </td>
                <td class="auto-style5">
                    Chef Anton's Gumbo Mix
                </td>
                <td>
                    $21.35
                </td>
                <td>
                    36 boxes
                </td>
                <td>
                    0
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    6
                </td>
                <td class="auto-style5">
                    Grandma's Boysenberry Spread
                </td>
                <td>
                    $25.00
                </td>
                <td>
                    12-8 oz jars

                </td>
                <td>
                    120
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    7
                </td>
                <td class="auto-style5">
                    Uncle Bob's Organic Dried Pears
                </td>
                <td>
                    $30.00
                </td>
                <td>
                    12 - 1 lb pkgs.
                </td>
                <td>
                    15
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    8
                </td>
                <td class="auto-style5">
                    Northwoo's Cranberry Souce
                </td>
                <td>
                    $40.00
                </td>
                <td>
                    12 - 12 oz jars.
                </td>
                <td>
                    6
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    9</td>
                <td class="auto-style5">
                    Mishi Kobe Niku
                </td>
                <td>
                    $97.00
                </td>
                <td>
                    18-500 g pkgs.
                </td>
                <td>
                    29
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>
            <tr>
                <td>
                    10
                </td>
                <td class="auto-style5">
                    Ikura
                </td>
                <td>
                    $31.00
                </td>
                <td>
                    12 - 200 ml jars
                </td>
                <td>
                    31
                </td>
                <td class="auto-style6">
                    <input type="checkbox">
                </td>
            </tr>


        </table>
    </div>
    </form>
</body>
</html>
