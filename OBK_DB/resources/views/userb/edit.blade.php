@extends('userb.welcome')

@section('main')
    <div class="row">
        <div class="col-sm-8 offset-sm-2">
            <h1 class="display-3">Update a product</h1>
            <form method="post" action="{{ route('userb.update', $userb->id) }}">
                @method('PATCH')
                @csrf
                <div class="form-group">
                    <label for="name">Name</label>
                    <input type="text" class="form-control" name="first_name" value={{ $userb->first_name }} />
                    <input type="text" class="form-control" name="last_name" value={{ $userb->last_name }} />
                </div>

                <div class="form-group">
                    <label for="cmnd">cmnd</label>
                    <input type="text" class="form-control" name="cmnd" value={{ $userb->cmnd }} />
                </div>

                <div class="form-group">
                    <label for="birthday">birthday</label>
                    <input type="text" class="form-control" name="birthday" value={{ $userb->birthday }} />
                </div>
                <div class="form-group">
                    <label for="address">address</label>
                    <input type="text" class="form-control" name="address" value={{ $userb->address }} />
                </div>
                <div class="form-group">
                    <label for="numberphone">numberphone</label>
                    <input type="text" class="form-control" name="numberphone" value={{ $userb->numberphone }} />
                </div>
                <div class="form-group">
                    <label for="email">email</label>
                    <input type="text" class="form-control" name="email" value={{ $userb->email }} />
                </div>
                <div class="form-group">
                    <label for="username">username</label>
                    <input type="text" class="form-control" name="username" value={{ $userb->username }} />
                </div>
                <div class="form-group">
                    <label for="password">password</label>
                    <input type="text" class="form-control" name="password" value={{ $userb->password }} />
                </div>

                <div class="form-group">
                    <img src="{{asset('img/gallery/' . $userb->imgFull)}}" width="250" height="250" alt="img"/>
                    <br>
                    <input type="file" name="image"/>
                </div>
                <button type="submit" class="btn btn-info">Update</button>
            </form>
        </div>
    </div>
@endsection
