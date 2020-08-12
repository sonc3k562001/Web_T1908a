@extends('product.welcome')

@section('main')
    <div class="row">
        <div class="col-sm-12">
            <h1 class="display-3">Product</h1>
            <div>
                <a href="{{ route('product.create')}}" class="btn btn-primary">New product</a>
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
                @foreach($Product as $product)
                    <tr>
                        <td>{{$product->id}}</td>
                        <td>{{$product->name}}</td>
                        <td>{{$product->cmnd}}</td>
                        <td>{{$product->birthday}}</td>
                        <td>{{$product->address}}</td>
                        <td>{{$product->numberphone}}</td>
                        <td>{{$product->email}}</td>
                        <td>{{$product->username}}</td>
                        <td>{{$product->password}}</td>
                        <td>{{$product->status}}</td>
                        <td><img src="img/gallery/{{$product->imgFull}}" width="250" height="250" alt="img"></td>
                        <td>
                            <a href="{{ route('product.edit', $product->id)}}" class="btn btn-success">Edit</a>
                        </td>
                        <td>
                            <form action="{{ route('product.destroy', $product->id)}}" method="post">
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
