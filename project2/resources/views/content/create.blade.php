@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/upload2.css')}}" media="all">
@endsection

@section('main')
    <div class="user-create col-xs-6 col-md-6">
        <div class = "container">
            <div class = "row">
                <div class = "create-section col-xs-6 col-md-6">
                    <h2>Open up a OnlineBanking Account now</h2>
                    <h3>Already signed up? <a href = "{{url('/login')}}">Log in</a></h3>

                    <form action="{{route('userb.store')}}" method="post" enctype="multipart/form-data">
                        @csrf

                        <label for="first_name">First Name:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="first_name" name="first_name" placeholder="Van A" required><br><br>

                        <label for="last_name">Last Name:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="last_name" name="last_name" placeholder="Nguyen" required><br><br>


                        <label class = "col-xs-12 col-md-12" for="birthday">Birthday:</label><br>
                        <input class = "col-xs-12 col-md-12" type="date" id="birthday" name="birthday">


                        <label for="cmnd">Citizen ID:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="cmnd" name="cmnd" maxlength="12" placeholder="123123123123" required><br><br>

                        <label for="email">Email:</label><br>
                        <input class = "col-xs-12 col-md-12" type="email" id="email" name="email" placeholder="nguyenvanA@gmail.com" required><br><br>

                        <label for="numberphone">Phone:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="numberphone" name="numberphone" placeholder="012345678900"
                               pattern="[0-9]{12}" title="Phone number with the giving pattern(12 numbers)"  required><br><br>

                        <label for="address">Address:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="address" name="address" placeholder="191 KD Street" required><br><br>

                        <label for="username">Username:</label><br>
                        <input class = "col-xs-12 col-md-12" type="text" id="username" name="username" placeholder="NguyenVanA" required><br><br>

                        <label for="password">Password:</label><br>
                        <input class = "col-xs-12 col-md-12" type="password" id="password" name="password" placeholder="******" required><br><br>
                        <p id="text1">WARNING! Caps lock is ON.</p>
                        <label for="confirm_password">Confirm Password:</label><br>
                        <input class = "col-xs-12 col-md-12" type="password" id="confirm_password" name="confirm_password" placeholder="******" required><br><br>
                        <p id="text2">WARNING! Caps lock is ON.</p>

                        <label for="image">Image:</label><br>
                        <input type="file" name="image">

                        <label for="status">Status:</label><br>
                        <input type="number" name="status" placeholder="Status">

                        <button type="submit" name="submit">Update</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

@endsection

@section('js')
    <script src="node_modules/typeahead.js/dist/typeahead.bundle.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function($) {
            const engine1 = new Bloodhound({
                remote: {
                    url: '/search/name?value=%QUERY%',
                    wildcard: '%QUERY%'
                },
                datumTokenizer: Bloodhound.tokenizers.whitespace('value'),
                queryTokenizer: Bloodhound.tokenizers.whitespace
            });
            const engine2 = new Bloodhound({
                remote: {
                    url: '/search/id?value=%QUERY%',
                    wildcard: '%QUERY%'
                },
                datumTokenizer: Bloodhound.tokenizers.whitespace('value'),
                queryTokenizer: Bloodhound.tokenizers.whitespace
            });
            $(".search-input").typeahead({
                hint: true,
                highlight: true,
                minLength: 1
            }, [
                {
                    source: engine1.ttAdapter(),
                    name: 'userb-name',
                    display: function(data) {
                        return data.name;
                    },
                    templates: {
                        empty: [
                            '<div class="header-title">Name</div><div class="list-group search-results-dropdown"><div class="list-group-item">Nothing found.</div></div>'
                        ],
                        header: [
                            '<div class="header-title">Name</div><div class="list-group search-results-dropdown"></div>'
                        ],
                        suggestion: function (data) {
                            return '<a href="/userb/' + data.id + '" class="list-group-item">' + data.name + '</a>';
                        }
                    }
                },
                {
                    source: engine2.ttAdapter(),
                    id: 'userb-id',
                    display: function(data) {
                        return data.id;
                    },
                    templates: {
                        empty: [
                            '<div class="header-title">Id</div><div class="list-group search-results-dropdown"><div class="list-group-item">Nothing found.</div></div>'
                        ],
                        header: [
                            '<div class="header-title">Id</div><div class="list-group search-results-dropdown"></div>'
                        ],
                        suggestion: function (data) {
                            return '<a href="/userb/' + data.id + '" class="list-group-item">' + data.id + '</a>';
                        }
                    }
                }
            ]);
        });
    </script>


    <script type="text/javascript">
        $(document).ready(function($) {
            const engine1 = new Bloodhound({
                remote: {
                    url: '/search/name?value=%QUERY%',
                    wildcard: '%QUERY%'
                },
                datumTokenizer: Bloodhound.tokenizers.whitespace('value'),
                queryTokenizer: Bloodhound.tokenizers.whitespace
            });
            const engine2 = new Bloodhound({
                remote: {
                    url: '/search/id?value=%QUERY%',
                    wildcard: '%QUERY%'
                },
                datumTokenizer: Bloodhound.tokenizers.whitespace('value'),
                queryTokenizer: Bloodhound.tokenizers.whitespace
            });
            $(".search-input").typeahead({
                hint: true,
                highlight: true,
                minLength: 1
            }, [
                {
                    source: engine1.ttAdapter(),
                    name: 'image-name',
                    display: function(data) {
                        return data.name;
                    },
                    templates: {
                        empty: [
                            '<div class="header-title">Name</div><div class="list-group search-results-dropdown"><div class="list-group-item">Nothing found.</div></div>'
                        ],
                        header: [
                            '<div class="header-title">Name</div><div class="list-group search-results-dropdown"></div>'
                        ],
                        suggestion: function (data) {
                            return '<a href="/image/' + data.id + '" class="list-group-item">' + data.name + '</a>';
                        }
                    }
                },
                {
                    source: engine2.ttAdapter(),
                    id: 'userb-id',
                    display: function(data) {
                        return data.id;
                    },
                    templates: {
                        empty: [
                            '<div class="header-title">Id</div><div class="list-group search-results-dropdown"><div class="list-group-item">Nothing found.</div></div>'
                        ],
                        header: [
                            '<div class="header-title">Id</div><div class="list-group search-results-dropdown"></div>'
                        ],
                        suggestion: function (data) {
                            return '<a href="/image/' + data.id + '" class="list-group-item">' + data.id + '</a>';
                        }
                    }
                }
            ]);
        });
    </script>
@endsection
