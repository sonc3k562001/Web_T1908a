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

Route::get('bank','UserController@getBanking');
Route::post('bank','UserController@postBanking');

Route::get('login','UserController@getLogin');
Route::post('login','UserController@postLogin');

Route::get('registration','UserController@getRegistration');
Route::post('registration','UserController@postRegistration');

Route::get('logout','UserController@postLogout');

