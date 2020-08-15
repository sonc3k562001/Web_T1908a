<?php

?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/create.css')}}" media="all">
@endsection

@section('main')
<section class = "user-create col-xs-12 col-md-12">
    <div class = "container">
        <div class = "row">

            <div class = "create-section col-xs-6 col-md-6">
                <h2>Open up a OnlineBanking Account now</h2>
                <h3>Already signed up? <a href = "#">Log in</a></h3>

                <form class = "col-xs-12 col-md-12" action = "{{url('create')}}" method = "post">
                    {{csrf_field()}}
                    <label for="first_name">First Name:</label><br>
                    <input class = "col-xs-12 col-md-12" type="text" id="first_name" name="first_name" required><br><br>

                    <label for="last_name">Last Name:</label><br>
                    <input class = "col-xs-12 col-md-12" type="text" id="last_name" name="last_name" required><br><br>

                    <div class = "text-center col-xs-12 col-md-12">
                        <div class = "col-xs-6 col-md-6">
                            <label class = "col-xs-12 col-md-12" for = "sex">Sex:</label><br>
                            <select class = "col-xs-12 col-md-12" type="text" id="sex" name="sex" required>
                                <option value="male">Male</option>
                                <option value="female">Female</option>
                            </select>
                        </div>
                        <div class = "col-xs-6 col-md-6">
                            <label class = "col-xs-12 col-md-12" for="birthday-time">Birthday:</label><br>
                            <input class = "col-xs-12 col-md-12" type="date" id="birthday-time" name="birthday-time">
                        </div>
                    </div>

                    <label for="citizen_id">Citizen ID:</label><br>
                    <input class = "col-xs-12 col-md-12" type="number" id="citizen_id" name="citizen_id" maxlength="12" required><br><br>

                    <label for="email">Email:</label><br>
                    <input class = "col-xs-12 col-md-12" type="email" id="email" name="email" required><br><br>

                    <label for="phone">Phone:</label><br>
                    <input class = "col-xs-12 col-md-12" type="tel" id="phone" name="phone" placeholder="012345678900"
                           pattern="[0-9]{12}" title="Phone number with the giving pattern(12 numbers)"  required><br><br>

                    <label for="address">Address:</label><br>
                    <input class = "col-xs-12 col-md-12" type="text" id="address" name="address" required><br><br>

                    <label for="address">Username:</label><br>
                    <input class = "col-xs-12 col-md-12" type="text" id="username" name="username" required><br><br>

                    <label for="address">Password:</label><br>
                    <input class = "col-xs-12 col-md-12" type="password" id="password" name="password" required><br><br>
                    <p id="text1">WARNING! Caps lock is ON.</p>
                    <label for="address">Confirm Password:</label><br>
                    <input class = "col-xs-12 col-md-12" type="password" id="confirm_password" name="confirm_password" required><br><br>
                    <p id="text2">WARNING! Caps lock is ON.</p>
                    <input class = "col-xs-12 col-md-12" id = "submit" type="submit" value="Sign Up">
                </form>

                <div class = "icon-login">

                    <button type="submit" class = "facebook col-xs-12 col-md-12" href = "#">
                        <i class="fab fa-facebook"></i>Connect with Facebook
                    </button>

                    <button type="submit" class = "google col-xs-12 col-md-12" href = "#">
                        <i class="fab fa-google"></i>Connect with Google
                    </button>
                </div>

            </div>

        </div>
    </div>

</section>

@endsection

@section('js')
    <script>
        //Password Validation
        var password = document.getElementById("password")
            , confirm_password = document.getElementById("confirm_password");

        function validatePassword(){
            if(password.value !== confirm_password.value) {
                confirm_password.setCustomValidity("Passwords Don't Match");
            } else {
                confirm_password.setCustomValidity('');
            }
        }

        password.onchange = validatePassword;
        confirm_password.onkeyup = validatePassword;

        //Capslock Checking
        // Get the input field
        var input1 = document.getElementById("password");
        var input2 = document.getElementById("confirm_password");

        // Get the warning text
        var text1 = document.getElementById("text1");
        var text2 = document.getElementById("text2");

        // When the user presses any key on the keyboard, run the function
        input1.addEventListener("keyup", function(event) {

            // If "caps lock" is pressed, display the warning text
            if (event.getModifierState("CapsLock")) {
                text1.style.display = "block";
            } else {
                text1.style.display = "none"
            }
        });

        input2.addEventListener("keyup", function(event) {

            // If "caps lock" is pressed, display the warning text
            if (event.getModifierState("CapsLock")) {
                text2.style.display = "block";
            } else {
                text2.style.display = "none"
            }
        });

    </script>
@endsection
