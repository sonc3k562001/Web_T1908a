<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateSaveBillTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('save_bill', function (Blueprint $table) {
            $table->increments('id_bill');
            $table->Decimal('balance',12,4);
            $table->Decimal('Minus',12,4);
            $table->text('note');
            $table->integer('id_save')->unsigned();
            $table->foreign('id_save')->references('id_save')->on('save');
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
        Schema::dropIfExists('save_bill');
    }
}
