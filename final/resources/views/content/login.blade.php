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
                    <form method="post" enctype="multipart/form-data">
                        <input type="hidden" name="_token" value="{{csrf_token()}}">

                        @if(Session::has('flag'))
                            <div class="alert alert-{{Session::get('flag')}}">{{Session::get('message')}}</div>
                        @endif
                        <div class="form-group">
                            <label>Email</label>
                            <input type="text" name="email" class="form-control" value="{{old('email')}}">
                        </div>
                        <div class="form-group">
                            <label>Mật khẩu</label>
                            <input type="text" name="password" class="form-control">
                        </div>
                        <div class="form-group">
                            <input type="submit" name="submit" class="form-control" value="Login">
                        </div>
                        {{csrf_field()}}
                    </form>
                    <h2 class = "col-xs-12 col-md-12"><a href = "{{url('/create')}}">New to our services? Create new Account right here.</a></h2>

                    <h3 class = "col-xs-12 col-md-12"><a href = "{{url('/create')}}">Forgot your password?</a></h3>
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


