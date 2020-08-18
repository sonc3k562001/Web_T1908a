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

    <div class="form-group">
        <label>You:</label>
        <input type="text" name="Minus" class="form-control" placeholder="enter Minus">
    </div>

    <div class="form-group">
        <label>Minus</label>
        <input type="text" name="Minus" class="form-control" placeholder="enter Minus">
    </div>
    <div class="form-group">
        <label>B</label>
        <input type="text" name="B" class="form-control">
    </div>
    <div class="form-group">
        <input type="submit" name="submit" class="form-control" value="Banking">
    </div>

</form>

</body>
</html>
