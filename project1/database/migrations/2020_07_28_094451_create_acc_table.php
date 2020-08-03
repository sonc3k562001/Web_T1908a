<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateAccTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('acc', function (Blueprint $table) {
            $table->increments('id_acc');
            $table->string('acc_num');
            $table->Decimal('balance',12,4);
            $table->Decimal('minus',12,4);
            $table->date('edate');
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
        Schema::dropIfExists('acc');
    }
}
