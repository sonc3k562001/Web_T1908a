@extends('userb.welcome')

@section('main')
    <div class="row">
        <div class="col-sm-12">
            <h1 class="display-3">Product</h1>
            <div>
                <a href="{{ route('userb.create')}}" class="btn btn-primary">New product</a>
            </div>
            <div class="flex-center position-ref full-height">
                <div class="content">
                    <form class="typeahead" role="search">
                        <input type="search" name="id" class="form-control search-input" placeholder="Name (Id)" autocomplete="off">
                        <button type="submit" name="search">Search</button>
                    </form>
                </div>
            </div>
            <table class="table table-striped">
                <thead>
                <tr>
                    <td>ID</td>
                    <td>Name</td>
                    <td>Cmnd</td>
                    <td>Birthday</td>
                    <td>Address</td>
                    <td>numberphone</td>
                    <td>email</td>
                    <td>username</td>
                    <td>password</td>
                    <td>status</td>
                    <td>Image</td>
                </tr>
                </thead>
                <tbody>
                @foreach($Userb as $userb)
                    <tr>
                        <td>{{$userb->id}}</td>
                        <td>{{$userb->name}}</td>
                        <td>{{$userb->cmnd}}</td>
                        <td>{{$userb->birthday}}</td>
                        <td>{{$userb->address}}</td>
                        <td>{{$userb->numberphone}}</td>
                        <td>{{$userb->email}}</td>
                        <td>{{$userb->username}}</td>
                        <td>{{$userb->password}}</td>
                        <td>{{$userb->status}}</td>
                        <td><img src="img/gallery/{{$userb->imgFull}}" width="250" height="250" alt="img"></td>
                        <td>
                            <a href="{{ route('userb.edit', $userb->id)}}" class="btn btn-success">Edit</a>
                        </td>
                        <td>
                            <form action="{{ route('userb.destroy', $userb->id)}}" method="post">
                                @csrf
                                @method('DELETE')
                                <button class="btn btn-danger" type="submit">Delete</button>
                            </form>
                        </td>
                    </tr>
                @endforeach
                </tbody>
            </table>
        </div>
    </div>
@endsection
