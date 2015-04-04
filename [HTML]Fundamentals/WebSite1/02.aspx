<%@ Page Language="VB" AutoEventWireup="false" CodeFile="02.aspx.vb" Inherits="_02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ol type ="I">
        <li>list Item 1</li>
        <ol type ="a">
            <li>Nested Item 1.1</li>
            <li>Nested Item 1.2</li>
        </ol>
        <li>List Item 2</li>
        <ol type ="1">
            <li>Nested Item 2.1</li>
            <li>Nested Itme 2.2</li>
            <ul type ="circle">
                <li>Nested Item 2.2.1</li>
                <li>Nested Item 2.2.2</li>
                <ul type="square">
                    <li>Nested Item 2.2.2.1</li>
                    <li>Nested Item 2.2.2.2</li>
                </ul>
                <li>Nested Item 2.2.3</li>
            </ul>
            <li>Nested Item 2.3</li>
        </ol>
        <li>List Item 3</li>
        <ul type="disc">
            <li>Nested Item 3.1</li>
            <li>Nested Item 3.1</li>
            <li>Nested Item 3.1</li>
        </ul>
    </ol>
    </div>
    </form>
</body>
</html>
