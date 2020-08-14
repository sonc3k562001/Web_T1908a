@extends('welcome')

@section('main')
    <div class="gallery-upload">
        <h2>New Image</h2>
        <form action="{{route('image.store')}}" method="post" enctype="multipart/form-data">
            @csrf
            <input type="text" name="name" placeholder="Name">
            <input type="file" name="image">
            <button type="submit" name="submit">Update</button>
        </form>
    </div>
@endsection
