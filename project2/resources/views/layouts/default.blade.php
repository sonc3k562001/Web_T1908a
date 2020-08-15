<?php

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Home</title>

    <link rel="stylesheet" type="text/css" href="{{asset('css/header.css')}}" media="all">
    <link rel="stylesheet" type="text/css" href="{{asset('css/footer.css')}}" media="all">
    <link href="https://fonts.googleapis.com/css2?family=Gentium+Book+Basic&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Arima+Madurai&display=swap" rel="stylesheet">

    @yield('css')

    <link rel="stylesheet" type="text/css" href="{{asset('vendors/bootstrap3.3.7/css/bootstrap.css')}}"/>
    <link rel="stylesheet" type="text/css" href="{{asset('vendors/fontawesome/css/all.css')}}"/>


</head>


<body>

@include('includes.header')

@yield('main')

@include('includes.footer')

<script type="text/javascript" href = "{{asset('js/jquery.js')}}"></script>

@yield('js')

</body>
</html>
