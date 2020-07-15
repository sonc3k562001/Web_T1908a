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
    return view('product.welcome');
});
Route::resource('/product', 'ProductController');
Route::get('/search/name', 'ProductController@searchByName');

Route::get('/search/id', 'ProductController@searchByEmail');
