<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateLoanTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('loan', function (Blueprint $table) {
            $table->increments('id_loan');
            $table->decimal('loan',12,4);
            $table->decimal('deposit',12,4);
            $table->date('start_loan');
            $table->date('exit_loan');
            $table->boolean('status_loan');
            $table->integer('id_user')->unsigned();
            $table->foreign('id_user')->references('id')->on('userbs');
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
        Schema::dropIfExists('loan');
    }
}
