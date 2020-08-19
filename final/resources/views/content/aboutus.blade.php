<?php
?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/aboutus.css')}}" media="all">
@endsection

@section('main')
    <section class = "intro col-xs-12 col-md-12">
        <div class = "container">
            <div class = "row">
                <div class = "intro-content col-xs-7 col-md-7">
                    <h1>We're building a bank, together</h1>
                    <h3>By solving your problems, treating you fairly and being totally transparent, we believe we can make banking better.</h3>
                </div>

            </div>
        </div>
    </section>

    <section class = "content col-xs-12 col-md-12">
        <div class = "container">
            <div class="text col-xs-7">
                <h2>We’re here to make money work for everyone</h2>
                <h4>Now more than 4.2 million people use our hot coral cards to manage <br>their money and spend around the world. Download the app today to join them.</h4>
            </div>
            <div class="image col-xs-5">
                <img src = "{{asset('images/nganhang3.jpg')}}" width="500" height="600">
            </div>
        </div>

        <div class = "container">
            <div class="text1 col-xs-5">
                <h2>We believe in an alternative to the banking of the past</h2>
                <h4>We're focused on solving problems, rather than selling<br> financial products. We want to make the world a better<br> place and change people's lives through Online Banking.</h4>
                <p ><a href="#" class="link">View our transparency page ›</a></p>
            </div>
            <div class="col-xs-1"></div>
            <div class="text2 col-xs-5">
                <h2>We’re building Online Banking together</h2>
                <h4>We're doing things differently. For too long, banking has<br> been obtuse, complex and opaque.<br>
                    We want to change that and build a bank with everyone, for everyone.Our amazing community suggest features, test the app and give us constant feedback so we can build something everyone loves.
                </h4>
                <p ><a href="#" class="link">View our community page ›</a></p>
            </div>
        </div>

        <div class = "container">
            <div class="text1 col-xs-5">
                <h2>Our way with words</h2>
                <h4>How we communicate changes how people feel about us, so we’d better make sure our words reflect what we stand for.<br> Our tone of voice guidelines exist to do just that.</h4>
                <p ><a href = "{!! url('/community'); !!}"  class="link">View our tone of voice</a></p>
            </div>
            <div class="col-xs-1"></div>
            <div class="text2 col-xs-5">
                <h2>We’re a fast-growing team</h2>
                <h4>Our office is at No. 8 Ton That Thuyet with a team of dedicated staff to customers</h4>
                <p><a href = "{!! url('/careers'); !!}" class="link">View our careers page</a></p>
            </div>
        </div>
        <div class="container1 text-center">
            <h1>Help us build the kind of bank you want to use</h1>
            <p>Download the OnlineBanking app on iOS or Android and join the 4.2 million<br> people who've changed the way they bank.</p>
        </div>

    </section>
    <section class="end col-xs-12 col-md-12">

    </section>
@endsection
