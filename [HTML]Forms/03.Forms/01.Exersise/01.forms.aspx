<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01.forms.aspx.cs" Inherits="_01.Exersise.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            width: 291px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" cellspacing="0" cellpadding="1">
        <thead>
            <th align="right">
                Last Name:
            </th>
                <td class="auto-style5">
                <input type="text" name="LastName" value="Last Name" style="width: 283px" />
                </td>
        </thead>
            <thead>
            <th align="right">
                First Name:
            </th>
                <td class="auto-style5">
                <input type="text" name="FirstName" value="FirstName" style="width: 286px"/>
                </td>
            <thead>
            <th align="right">
                 Address:
            </th>
                <td class="auto-style5">
                    <textarea name="Adsress" style="width: 284px; height: 152px">Adress </textarea>
                </td>
            <thead>
            <th align="right">
                City
            </th>
                <td class="auto-style5">
                    <input name="City" type="text" value="City" style="width: 167px"/> 
                    State <input name="State" type="text" style="width: 69px; margin-left: 0px" />
                </td>
            <thead>
            <th align="right">
                Zip/Postal Code 
            </th>
                <td class="auto-style5">
                    <input name="ZipCode" type="number" style="width: 284px" />
                </td>
            <thead>
            <th align="right">
                Country
            </th>
                <td class="auto-style5" >
                    <select name="Country" style="width: 289px">
                        <option value="Bulgaria">Bulgaria</option>
                        <option value="Ukraine" >Ukraine</option>
                        <option value="Greese">Greese</option>
                    </select>
                </td>
            <thead>
            <th align="right">
                Phone(country code,
            <br/>
                area code,number)   
            </th>
                <td class="auto-style5" >
                       (+
                    <input name="CountryCode" type="tel" value="359"  style="width: 47px"/>
                        )
                    <input name="PhoneOperator" type="tel" value="88"  style="width: 81px" /> 
                       -
                    <input name="PhoneNumber" type="tel" required="true" value="8334343" style="width: 97px" />
                </td>
            <thead>
            <th align="right">
                E-mail
            </th>
                <td class="auto-style5" >
                    <input name="E-mail" type="email" required="true" pattern="[^ @]" value="nakov@gmail.org" style="width: 284px" />
                </td>
            <thead>
            <th align="right">
            Birth date
            </th>
                <td class="auto-style5">
                    <input type="month" name="Month" style="width: 109px" value="06.1980" />
                    <input type="number" min="1" max="31" value="14" style="width: 152px"/>
                </td>
            <thead>
            <th align="right">
                Gender
            </th>
                <td class="auto-style5">
                    <select name="Gender">
                        <option value="Male">Male</option>
                        <option value="Female">Female</option>
                    </select>
                </td>
            <thead>
                <th align="right">
                    Starting date
                </th>
                <td class="auto-style5">
                    Spring2006
                    <input type="radio" name="Spring" />
                    Summer 2006
                    <input type="radio" name="Summer"
                </td>
            </thead>
            <thead>
                <th align="right">
                    Comments/Questions
                </th>
                <td class="auto-style5">
                    <textarea name="Comments/Questions" style="width: 289px; height: 154px">Please send me more information about the lodging.
                    </textarea>
                </td>
            </thead>
                <tfoot>
                    <th colspan="2">
                        <input type="button" value="Submit" />
                        <input type="button" value="Clear This Form" />
                    </th>
                </tfoot>
    </table>
    </div>
    </form>
</body>
</html>
