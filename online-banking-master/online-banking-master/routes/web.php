<?php

use Illuminate\Support\Facades\Route;
use App\Userb;
use Illuminate\Http\Request;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/


Route::get('/', function () {
    return view('content.home');
});

Route::get('/user', function () {
    return view('content.user');
});

Route::get('/blog', function(){
    return view('content.blog');
});

Route::get('/create',function(){
    return view('content.create');
});

Route::post('/create',function(Request $request){
   $userb = new Userb();
   $userb -> first_name = $request -> first_name;
   $userb -> last_name = $request -> last_name;
   $userb -> sex = $request -> sex;
   $userb -> birhday = $request -> birthday;
   $userb -> citizen_id = $request -> citizen_id;
   $userb -> email = $request -> email;
   $userb -> phone = $request -> phone;
   $userb -> address = $request -> address;
   $userb -> username = $request -> username;
   $userb -> password = $request -> password;

   $userb -> save();

   return redirect('/login');
});

Route::get('/login',function(){
    return view('content.login');
});

Route::get('/inside',function(){
    return view('content.inside');
});

Route::get('/outside',function(){
    return view('content.outside');
});

Route::get('/success',function(){
    return view('content.success');
});

Route::get('/careers', function () {
    return view('content.careers');
});

Route::get('/community', function () {
    return view('content.community');
});

Route::get('/aboutus', function () {
    return view('content.aboutus');
});

Route::get('/faq', function () {
    return view('content.faq');
});

Route::get('/making', function () {
    return view('content.making');
});

Route::get('/protect', function () {
    return view('content.protect');
});


