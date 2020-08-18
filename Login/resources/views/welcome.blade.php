<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Laravel</title>

        <!-- Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Nunito:200,600" rel="stylesheet">


    </head>
    <body>
    <header>
        <!--đây là chỗ mà a để cái nút sign in đóa-->
        <ul>
            @if(Auth::check())
                <li><a href="">Chào bạn {{Auth::user()->first_name}} {{Auth::user()->last_name}}</a></li>
                <li><a href="">Balance:{{Auth::user()->balance}}</a></li>

                <li><a href="logout">Logout</a></li>

            @else
                <li><a href="registration">registration</a></li>
                <li><a href="login">login</a></li>
            @endif
        </ul>
    </header>

    </body>
</html>
