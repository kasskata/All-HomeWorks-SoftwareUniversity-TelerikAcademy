<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02.TablesAndForms.aspx.cs" Inherits="_01.Exersise.TablesAndForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Students.thml</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table cellspacing="0" cellpadding="5" border="2">
            <tr>
                <td rowspan="2" class="auto-style1">
                    <h3>Order</h3>
                </td>

                <td colspan="3">
                    <h2>Personal Info</h2>
                </td>

                <td colspan="5">
                    <h2>University Marks</h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>First Name</h3>
                </td>
                <td>
                    <h3>Last Name</h3>
                </td>
                <td>
                    <h3>Faculty Number</h3>
                </td>
                <td>
                    <h3>English</h3>
                </td>
                <td>
                    <h3>Math</h3>
                </td>
                <td>
                    <h3>Biology</h3>
                </td>
                <td>
                    <h3>Physics</h3>
                </td>
                <td>
                    <h3>Total</h3>
                </td>
            </tr>
            <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="1"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="2"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
            
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="3"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="4"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="5"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="6"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="7"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="8"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="9"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
              <tr>
                <td>
                    <input name="OrderNo" type="number" style="width: 33px" value="10"/>
                </td>
                <td>
                    <input name="Name" type="text" value="Pesho"/>
                </td>
                <td>
                    <input name="LastName" type="text" value="Yordanov"/>
                </td>
                <td>
                    <input name="FacultyNumber" type="number" value="123456"/>
                </td>
                <td>
                    <input name="English" type="number" min="2" max="6" value="2"/>
                </td>
                <td>
                    <input name="Math" type="number" min="2" max="6" value="3"/>
                </td>
                <td>
                    <input name="Biology" type="number" min="2" max="6" value="4"/>
                </td>
                <td>
                    <input name="Physics" type="number" min="2" max="6" value="5"/>
                </td>
                <td>
                    <input name="Total" type="number" min="2" max="6" value="3.50"/>
                </td>
            </tr>
            <tr>
                <td colspan =" 4">
                <a href="TablesAndForms.aspx"><input type="button" value="Previous" /></a>
                
                <a href="TablesAndForms.aspx">1,</a>
                <a href="TablesAndForms.aspx">2,</a>
                <a href="TablesAndForms.aspx">3,</a>
                <a href="TablesAndForms.aspx">4,</a>
                <a href="TablesAndForms.aspx">...,</a>
                <a href="TablesAndForms.aspx">10</a>
                <a href="TablesAndForms.aspx"><input type="button" value="Next"</a>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
