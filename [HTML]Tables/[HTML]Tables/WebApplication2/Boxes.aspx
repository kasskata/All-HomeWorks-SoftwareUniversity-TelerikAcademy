<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Boxes.aspx.cs" Inherits="WebApplication2.Boxes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:justify">
    <table style="height: 199px; width: 111px">
        <thead>
            <tr>
                <th>
                    Member name:
                </th>
                <td>
                    <form >
                    <input name="q" type="text" placeholder="search" value="" tabindex="1" autocomplete="off" maxlength="240" style="width: 205px; max-width: 188px; height: 21px;">
                    </form>
                </td>
                <td>
                    <strong>*req</strong>
                </td>
            </tr>
            <tr>
                <th>
                    Email:
                </th>
                <td>
                    <form >
                    <input name="q" type="text" placeholder="search" value="" tabindex="1" autocomplete="off" maxlength="240" style="width: 205px; max-width: 188px; height: 21px;">
                    </form>
                </td>
                <td>
                    <strong>*req</strong>
                </td>
            </tr>
            <tr>
                <th>
                    School:
                </th>
                <td>
                    <form >
                    <input name="q" type="text" placeholder="search" value="" tabindex="1" autocomplete="off" maxlength="240" style="width: 205px; max-width: 188px; height: 21px;">
                    </form>
                </td>
                <td>
                    <strong>*req</strong>
                </td>
            </tr>
            <tr>
                <td>
                    <img src="http://www.clker.com/cliparts/R/J/H/8/D/q/submit-button-md.png" style="height: 36px; width: 54px" />
                </td>
            </tr>
        </thead>
    </table>
    </div>
    </form>
</body>
</html>
