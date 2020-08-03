<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateSaveTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('save', function (Blueprint $table) {
            $table->increments('id_save');
            $table->decimal('saving',12,4);
            $table->decimal('deposit',12,4);
            $table->date('start_save');
            $table->boolean('status_save');
            $table->integer('id_user')->unsigned();
            $table->foreign('id_user')->references('id')->on('userb');
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
        Schema::dropIfExists('save');
    }
}
