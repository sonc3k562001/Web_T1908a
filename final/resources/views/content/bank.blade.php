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
<form method="post" enctype="multipart/form-data">
    <input type="hidden" name="_token" value="{{csrf_token()}}">
        {{csrf_field()}}
    <div class="form-group">
        <label>You:</label>
        <span >{{Auth::user()->acc_num}}</span>
    </div>

    <div class="form-group">
        <label>Minus:</label>
        <input type="text" id="minus" name="minus" class="form-control" placeholder="enter Minus">
    </div>
    <div class="form-group">
        <label>User 2:</label>
        <input type="text" id="user2"  name="user2" class="form-control">
    </div>
    <div class="form-group">
        <input type="submit" name="submit" class="form-control btn-success" value="Banking">
    </div>
</form>
</body>
</html>
