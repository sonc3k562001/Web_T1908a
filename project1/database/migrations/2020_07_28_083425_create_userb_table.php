<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateUserbTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('userb', function (Blueprint $table) {
            $table->increments('id');
            $table->string('cmnd');
            $table->string('first_name');
            $table->string('last_name');
            $table->date('birthday');
            $table->text('address');
            $table->string('username');
            $table->string('password');
            $table->boolean('status');
            $table->string('number_phone');
            $table->string('email');
            $table->longText('img_cmnd_1');
            $table->longText('img_cmnd_2');
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
        Schema::dropIfExists('userb');
    }
}
