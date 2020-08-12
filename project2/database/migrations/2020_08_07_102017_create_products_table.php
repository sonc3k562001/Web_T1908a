<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateProductsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('products', function (Blueprint $table) {
            $table->increments('id');
            $table->string('name1');
            $table->string('name2');
            $table->string('cmnd');
            $table->date('birthday');
            $table->text('address');
            $table->text('numberphone');
            $table->text('email');
            $table->text('username');
            $table->text('password');
            $table->text('status');
            $table->longText('imgFull');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('products');
    }
}
