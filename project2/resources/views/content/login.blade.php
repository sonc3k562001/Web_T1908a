<?php

?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/login.css')}}" media="all">
@endsection

@section('main')
    <section class = "account-login text-center col-xs-12 col-md-12">
        <div class = "container">
            <div class = "row">
                <div class = "login-fill col-xs-6 col-md-6">
                    <form class = "col-xs-12 col-md-12 text-center" action="{{url('/user')}}">
                        <label for="account-name">Account/ Phone's Number:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="account-name" name="account-name" required><br><br>
                        <label for="account-password">Account's Password</label><br>
                        <input class = "col-xs-12 col-md-12" type="password" id="account-password" name="account-password" required><br><br>
                        <input class = "col-xs-12 col-md-12" id = "submit" type="submit" value="Login">

                        <h2 class = "col-xs-12 col-md-12"><a href = "{{url('/create')}}">New to our services? Create new Account right here.</a></h2>

                        <h3 class = "col-xs-12 col-md-12"><a href = "{{url('/create')}}">Forgot your password?</a></h3>



                    </form>

                    <div class = "icon-login col-xs-12 col-md-12">

                        <button type="submit" class = "facebook col-xs-12 col-md-12" href = "#">
                            <i class="fab fa-facebook"></i>Connect with Facebook
                        </button>

                        <button type="submit" class = "google col-xs-12 col-md-12" href = "#">
                            <i class="fab fa-facebook"></i>Connect with Google
                        </button>
                    </div>


                </div>

                <div class = "login-images col-xs-6 col-md-6">
                    <img class = "col-xs-12 col-md-12" src = "{{asset("images/onbank8.png")}}">
                </div>

            </div>
        </div>
    </section>
@endsection


