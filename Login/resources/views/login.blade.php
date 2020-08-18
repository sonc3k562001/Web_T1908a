
<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Laravel</title>
        <link href="https://fonts.googleapis.com/css?family=Nunito:200,600" rel="stylesheet">

    </head>
    <body>

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
</body>
</html>
