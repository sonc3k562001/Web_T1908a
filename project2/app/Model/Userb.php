<?php

namespace App\Model;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;

class Userb extends Model
{
    use Notifiable;
    protected $table='userbs';
    protected $primaryKey='id';
    protected $fillable=[
        'first_name',
        'last_name',
        'cmnd',
        'birthday',
        'address',
        'numberphone',
        'email',
        'username',
        'password',
        'status',
        'imgFull',
    ];
    protected $hidden = [
        'password', 'remember_token',
    ];


}
