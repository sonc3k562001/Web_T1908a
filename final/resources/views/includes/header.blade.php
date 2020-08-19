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
                    <ul>
                        @if(Auth::check())
                            <li><a href="">Chào bạn {{Auth::user()->first_name}} {{Auth::user()->last_name}}</a></li>
                            <form action="showBalance" method="post">

                                <li><a href="">Balance:{{Auth::user()->balance}}</a></li>
                            </form>

                            <li><a href="logout">Logout</a></li>
                            <li><a href="bank">Bank</a> </li>
                        @else
                            <li><a href="login">login</a></li>
                        @endif
                    </ul>
{{--                    <li><button><a href="{!! url('/login'); !!}">Sign in</a></button></li>--}}
                </ul>
            </div>
        </div>
    </div>
</header>

