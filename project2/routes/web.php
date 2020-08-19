<?php

use Illuminate\Support\Facades\Route;

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
    return view('welcome');
});

Route::post('showbalance','UserController@showBalance');

Route::get('acc','UserController@getAcc');
Route::post('acc','UserController@postAcc');

Route::get('bank','UserController@getBank');
Route::post('bank','UserController@postBank');

Route::resource('/user', 'UserController');
Route::resource('/image', 'ImageController');

Route::get('/', function () {
    return view('content.home');
});

Route::get('/user', function () {
    return view('content.user');
});

Route::get('/blog', function(){
    return view('content.blog');
});

Route::get('create','UserController@getRegistration');
Route::post('create','UserController@postRegistration');

Route::get('login','UserController@getLogin');
Route::post('login','UserController@postLogin');

Route::get('logout','UserController@postLogout');

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
