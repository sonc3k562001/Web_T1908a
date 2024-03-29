<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateUserTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('user', function (Blueprint $table) {
            $table->increments('id');
            $table->string('first_name');
            $table->string('last_name');
            $table->string('cmnd');
            $table->date('birthday');
            $table->text('address');
            $table->string('numberphone');
            $table->string('email');
            $table->string('password');
            $table->string('acc_num')->nullable();
            $table->decimal('balance',12,3)->default(0);
            $table->date('edate')->default('2030-05-01');
            $table->integer('role')->default(1);
            $table->boolean('status')->default(1);
            $table->rememberToken();
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
        Schema::dropIfExists('user');
    }
}
