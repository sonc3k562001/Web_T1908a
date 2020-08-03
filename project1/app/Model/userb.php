<?php


namespace App;


class userb
{
    use Notifiable;
    protected $table='userb';
    protected $primaryKey='id';
    protected $fillable=[
        'cmnd',
        'first_name',
        'last_name',
        'birthday',
        'address',
        'username',
        'password',
        'status',
        'number_phone',
        'email',
        'img_cmnd_1',
        'img_cmnd_2',
    ];
}
