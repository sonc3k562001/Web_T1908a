@extends('userb.welcome')

@section('main')
    <div class="gallery-upload">
        <h2>New Product</h2>
        <form action="{{route('userb.store')}}" method="post" enctype="multipart/form-data">
            @csrf
            <input type="text" name="first_name" placeholder="First name">
            <input type="text" name="last_name" placeholder="Last name">
            <input type="text" name="cmnd" placeholder="Cmnd">
            <input type="date" name="birthday" placeholder="Birthday">
            <input type="text" name="address" placeholder="Address">
            <input type="text" name="numberphone" placeholder="Numberphone">
            <input type="email" name="email" placeholder="Email">
            <input type="text" name="username" placeholder="Username">
            <input type="password" name="password" placeholder="Password">
            <input type="number" name="status" placeholder="Status">
            <input type="file" name="image">
            <button type="submit" name="submit">Update</button>
        </form>
    </div>
@endsection
