<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;

class Image extends Model
{
    use Notifiable;
    protected $table='image';
    protected $primaryKey='id';
    protected $fillable=[
        'name',
        'imgFull',
    ];
}
