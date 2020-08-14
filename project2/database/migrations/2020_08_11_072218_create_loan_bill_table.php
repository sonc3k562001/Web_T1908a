<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateLoanBillTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('loan_bill', function (Blueprint $table) {
            $table->increments('id_bill');
            $table->Decimal('balance',12,4);
            $table->text('note');
            $table->time('timeBill');
            $table->integer('id_loan')->unsigned();
            $table->foreign('id_loan')->references('id_loan')->on('loan');
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
        Schema::dropIfExists('loan_bill');
    }
}
