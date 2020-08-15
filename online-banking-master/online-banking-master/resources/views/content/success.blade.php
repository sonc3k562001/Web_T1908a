<?php
?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/success.css')}}" media="all">
@endsection

@section('main')
    <section class = "transaction-confirm text-center col-xs-12 col-md-12">
        <div class = "container">
            <div class = "row">
                <div class = "receiver-section col-xs-6 col-md-6">
                    <div class = "receiver-info col-xs-12 col-md-12">
                        <h1>The money was sent to</h1>
                        <h2>005982759201089</h2>
                        <h3>Nguyen Van A</h3>
                    </div>

                    <table class = "table tab-content table-striped table-bordered text-center col-xs-6 col-md-6">
                        <tr>
                            <td class = "table-head">Total money:</td>
                            <td>VND: 152,000</td>
                        </tr>
                        <tr>
                            <td class = "table-head">Transaction Fee:</td>
                            <td>VND: 0</td>
                        </tr>
                        <tr>
                            <td class = "table-head">Transaction code:</td>
                            <td>2315123123125</td>
                        </tr>
                    </table>

                    <div class = "done-button col-xs-12 col-md-12">
                        <button class = "submit" >New Transaction</button><br>
                        <button class = "submit" >Home</button>
                    </div>
                </div>

                <div class = "receiver-images col-xs-6 col-md-6">
                    <h2>Thank you for using our services</h2>
                    <img src = "{{asset("images/thank-you.png")}}">
                    <h3>Are you satisfied with our services?</h3>
                    <i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star-half-alt"></i>
                </div>

            </div>
        </div>
    </section>
@endsection
