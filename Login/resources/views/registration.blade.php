<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>registraion</title>
</head>
<body>

<form  class = "col-xs-12 col-md-12" action="registration" method="post" enctype="multipart/form-data">
    <input type="hidden" name="_token" value="{{csrf_token()}}">
    {{csrf_field()}}
    <label for="first_name">First Name:</label><br>
    <input class = "col-xs-12 col-md-12" type="text" id="first_name" name="first_name" placeholder="Van A" required><br><br>

    <label for="last_name">Last Name:</label><br>
    <input class = "col-xs-12 col-md-12" type="text" id="last_name" name="last_name" placeholder="Nguyen" required><br><br>


    <label class = "col-xs-12 col-md-12" for="birthday-time">Birthday:</label><br>
    <input class = "col-xs-12 col-md-12" type="date" id="birthday-time" name="birthday"><br>


    <label for="cmnd">Citizen ID:</label><br>
    <input class = "col-xs-12 col-md-12" type="text" id="cmnd" name="cmnd" maxlength="12" placeholder="123123123123" required><br><br>

    <label for="numberphone">Phone:</label><br>
    <input class = "col-xs-12 col-md-12" type="text" id="numberphone" name="numberphone" placeholder="012345678900"
           pattern="[0-9]{12}" title="Phone number with the giving pattern(12 numbers)"  required><br><br>

    <label for="address">Address:</label><br>
    <input class = "col-xs-12 col-md-12" type="text" id="address" name="address" placeholder="191 KD Street" required><br><br>

    <label for="email">Email:</label><br>
    <input class = "col-xs-12 col-md-12" type="email" id="email" name="email" placeholder="nguyenvanA@gmail.com" required><br><br>

    <label for="password">Password:</label><br>
    <input class = "col-xs-12 col-md-12" type="password" id="password" name="password" placeholder="******" required><br><br>
    <label for="confirm_password">Confirm Password:</label><br>
    <input class = "col-xs-12 col-md-12" type="password" id="confirm_password" name="confirm_password" placeholder="******" required><br><br>
    <input class = "col-xs-12 col-md-12" id = "submit" type="submit" value="Sign Up">
</form>

</body>
</html>
