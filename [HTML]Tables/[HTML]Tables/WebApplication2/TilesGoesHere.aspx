<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TilesGoesHere.aspx.cs" Inherits="WebApplication2.TilesGoesHere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center;">
    <table border="1" >
        <tr>
            <td colspan ="3" >
                Title goes here
            </td>
            <td>
                A
            </td>
            <td>
                B
            </td>
        </tr>
        <tr>
            <td rowspan ="3">
                C
            </td>
            <td>
                D
            </td>
            <td>
                E
            </td>
            <td>
                F
            </td>
            <td>
                G
            </td>
        </tr>
        <tr>
            <td>
                H
            </td>
            <td = colspan="2">
                I
            </td>
            <td rowspan="2">
                J
            </td>
        </tr>
        <tr>
            <td>
                K
            </td>
            <td>
                L
            </td>
            <td>
                M
            </td>
        </tr>
        <tr>
            <td>
                N
            </td>
            <td colspan="4">
                O
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
