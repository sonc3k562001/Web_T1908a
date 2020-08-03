<?php

namespace App\Http\Controllers;

use App\userb;
use Illuminate\Foundation\Auth\Access\AuthorizesRequests;
use Illuminate\Foundation\Bus\DispatchesJobs;
use Illuminate\Foundation\Validation\ValidatesRequests;
use Illuminate\Routing\Controller as BaseController;

class userController extends BaseController
{
    use AuthorizesRequests, DispatchesJobs, ValidatesRequests;
    public function user(Request $request)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $newFileName = $request->get('last_name'+'first_name');
        $fileName = $request->image->getClientOriginalName();
        $fileType = $request->image->getMimeType();
        $fileTempName = $request->image->getPathName();
        $fileError = $request->image->getError();
        $fileSize = $request->image->getSize();
        $fileExt = explode(".", $fileName);
        $fileActualExt = strtolower(end($fileExt));
        $allowed = array("jpg", "jpeg", "png");
        if (in_array($fileActualExt, $allowed)) {
            if ($fileError === 0) {
                if ($fileSize < 2000000) {
                    $imageFullName = $newFileName . "." . uniqid("", true) . "." . $fileActualExt;
                    $sql = userb::all();
                    if (!$sql) {
                        echo "SQL statement failed!";
                    } else {
                        $product = userb::create([
                            'first'=>$request->get('name'),
                            'cmnd'=>$request->get('cmnd'),
                            'email'=>$request->get('email'),
                            'img1'=>$imageFullName,
                        ]);
                        $product->save();
                        if (!$product->save()) {
                            echo "SQL statement failed!";
                        } else {
                            $product->save();
                            $request->image->move('img/user', $imageFullName);
                            return redirect('/user');
                        }
                    }
                } else {
                    echo "File size is too big!";
                    exit();
                }
            } else {
                echo "You had an error!";
                exit();
            }
        } else {
            echo "You need to upload a proper file type!";
            exit();
        }
    }
}
