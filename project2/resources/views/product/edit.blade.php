@extends('product.welcome')

@section('main')
    <div class="row">
        <div class="col-sm-8 offset-sm-2">
            <h1 class="display-3">Update a product</h1>
            <form method="post" action="{{ route('product.update', $product->id) }}">
                @method('PATCH')
                @csrf
                <div class="form-group">
                    <label for="name">Name</label>
                    <input type="text" class="form-control" name="name" value={{ $product->name }} />
                </div>

                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->cmnd }} />
                </div>

                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->birthday }} />
                </div>
                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->address }} />
                </div>
                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->numberphone }} />
                </div>
                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->email }} />
                </div>
                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->username }} />
                </div>
                <div class="form-group">
                    <label for="price">Price</label>
                    <input type="text" class="form-control" name="price" value={{ $product->password }} />
                </div>

                <div class="form-group">
                    <img src="{{asset('img/gallery/' . $product->imgFull)}}" width="250" height="250" alt="img"/>
                    <br>
                    <input type="file" name="image"/>
                </div>
                <button type="submit" class="btn btn-info">Update</button>
            </form>
        </div>
    </div>
@endsection
