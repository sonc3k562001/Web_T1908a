<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Laravel</title>

        <!-- Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Nunito:200,600" rel="stylesheet">
        <style>
        </style>
    </head>
    <body>
    <h2>New Product</h2>
    <form action="{{route('user.store')}}" method="post" enctype="multipart/form-data">
        @csrf
        <input type="text" name="first_name" placeholder="First Name">
        <input type="text" name="last_name" placeholder="Last Name">
        <input type="text" name="cmnd" placeholder="cmnd">
        <input type="text" name="email" placeholder="email">
        <input type="text" name="address" placeholder="address">
        <input type="date" name="birthday" placeholder="birthday">
        <input type="text" name="username" placeholder="username">
        <input type="password" name="password" placeholder="password">
        <input type="number" name="status" placeholder="status">
        <input type="file" name="img1">
        <input type="file" name="img2">
        <button type="submit" name="submit">Update</button>
    </form>
    </body>

</html>
