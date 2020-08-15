<?php

?>


<header class = "text-center navbar-fixed-top col-xs-12 col-md-12">
    <div class = "container">
        <div class = "row">
            <div class = "header-left text-center col-xs-4 col-md-4">
                <div class = "header1 col-xs-12 col-md-12">
                    <a href = "{{url('/')}}"><img src = "{{asset('images/web-icon2.png')}}"></a>
                </div>
            </div>

            <div class = "header-right text-center col-xs-8 col-md-8">
                <ul>
                    <li><a href = "{!! url('/user'); !!}">Account</a></li>
                    <li><a href = "{!! url('/saving'); !!}">Savings</a></li>
                    <li><a href = "{!! url('/borrowing'); !!}">Borrowing</a></li>
                    <li><a href = "{!! url('/features'); !!}">Features</a></li>
                    <li><a href = "{!! url('/faq'); !!}">Help</a></li>
                    <li><button><a href="{!! url('/login'); !!}">Sign in</a></button></li>
                </ul>
            </div>
        </div>
    </div>
</header>

