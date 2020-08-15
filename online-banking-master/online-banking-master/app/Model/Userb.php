<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Userb extends Model
{
    use Notifiable;
    protected $table='userbs';
    protected $primaryKey='id';
    protected $fillable=[
        'first_name',
        'last_name',
        'sex',
        'birthday',
        'citizen_id',
        'email',
        'phone',
        'address',
        'username',
        'password'
    ];
}
