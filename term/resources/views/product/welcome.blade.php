<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Product</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css?family=Catamaran:100,200,300,400,500,600,700,800,900|Cormorant+Garamond:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">
    <link rel="stylesheet" href="{{asset('css/app.css')}}">
    <link rel="stylesheet" href="{{asset('css/style.css')}}">
    <style>
        body{
            background-color: #00b0e8;
            color: white;
        }
        main{
            height: 700px;
            overflow: auto;
        }
        footer{

        }
        footer ul li{
            float: left;
            margin-left: 50px;
        }
    </style>
</head>
<body>
<header>
    <a href="{{route('product.index')}}" class="header-brand">SONDZ</a>
    <nav>
        <ul>
            <li><a href="http://127.0.0.1:8000/product">Click here</a></li>
        </ul>
    </nav>
</header>

<main>
    @yield('main')

</main>
<footer>
    <div class="container">
        <ul class="footer-links-main">
            <li><a href="http://127.0.0.1:8000">Home</a></li>
            <li><a href="http://127.0.0.1:8000/product">Product</a></li>
        </ul>

    </div>
</footer>
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
                name: 'product-name',
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
                        return '<a href="/product/' + data.id + '" class="list-group-item">' + data.name + '</a>';
                    }
                }
            },
            {
                source: engine2.ttAdapter(),
                id: 'product-id',
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
                        return '<a href="/product/' + data.id + '" class="list-group-item">' + data.id + '</a>';
                    }
                }
            }
        ]);
    });
</script>
</body>
</html>
