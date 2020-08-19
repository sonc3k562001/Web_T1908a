<?php

?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/inside.css')}}" media="all">
@endsection

@section('main')
    <section class = "transaction-inside col-xs-12 col-md-12">
        <div class = "container">
            <div class = "row">
                <h2>Transaction to the same bank</h2>
                <div class = "col-xs-6 col-md-6">
                    <form class = "col-xs-12 col-md-12" action = "{{url('/success')}}">
                        <label for="user">Account:</label><br>
                        <input list="user">
                        <datalist id="user">
                            <option value="19034908954011">
                            <option value="19034908954011">
                            <option value="19034908954011">
                            <option value="19034908954011">
                        </datalist><br>
                        <ul>
                            <li>VND-TGTT-HQNM</li>
                            <li>19034908954011</li>
                            <li>VND: 1,443,387</li>
                        </ul>
                        <label for="receiver">Transfer to:</label><br>
                        <input list="receiver">
                        <datalist id="receiver">
                            <option value="19034908952141">
                            <option value="19034909012312">
                            <option value="19034908952132">
                            <option value="19034908412312">
                        </datalist><br>
                        <ul>
                            <li>VND-TGTT-HQBB</li>
                            <li>1903490895452</li>
                            <li>Nguyen Van A</li>
                        </ul>
                        <label for="money">VND:</label><br>
                        <input type="text" id="money" name="money" required><br><br>
                        <label for="message">Message Info:</label><br>
                        <textarea type="text" id="message" name="message" rows="3" cols="50" maxlength="140" required></textarea><br>
                        <button id = "submit" type="submit" value="Submit">Submit</button>
                        <button id = "reset" type="reset" value="Reset">Reset</button>
                    </form>
                </div>

                <div class = "recent-transaction col-xs-6 col-md-6">
                    <h2>Recent Transaction</h2>
                    <table class = "table-striped text-center table-bordered table-hover col-xs-12 col-md-12">
                        <tr>
                            <th>Account number</th>
                            <th>Account Name</th>
                            <th>Transaction Date</th>
                        </tr>
                        <tr>
                            <td>123125123123</td>
                            <td>Nguyen Van A</td>
                            <td>20/1/2020</td>
                        </tr>
                        <tr>
                            <td>123125123123</td>
                            <td>Nguyen Van A</td>
                            <td>20/1/2020</td>
                        </tr>
                        <tr>
                            <td>123125123123</td>
                            <td>Nguyen Van A</td>
                            <td>20/1/2020</td>
                        </tr>
                    </table>
                </div>

            </div>
        </div>
    </section>
@endsection


