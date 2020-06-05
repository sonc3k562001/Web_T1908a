<HTML>
<head>
    <title>employee details</title>
</head>
<body>
<H4>Enter your details</H4>
<form method="post" action="emp_details.php">
    <table>
        <tr>
            <td>
                Employee ID:
            </td>
            <td><input type="text" name="emp_ID"></td>
        </tr>
        <tr>
            <td>Name:</td>
            <td><input type="text" name="emp_name"></td>
        </tr>
        <tr>
            <td>Depaiment:</td>
            <td>
                <input type="radio" name="dept" value="finace ">Fincace
                <input type="radio" name="dept" value="maketing ">Maketing
                <input type="radio" name="dept" value="IT ">IT
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <input type="email" name="email">
            </td>
        </tr>
    </table>
    <br>
    <td><input type="submit" value="submit"></td>

</form>
</body>
</HTML>