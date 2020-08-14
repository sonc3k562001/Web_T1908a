<?php

namespace App\Http\Controllers;

use App\Image;
use App\Userb;
use Illuminate\Contracts\Foundation\Application;
use Illuminate\Contracts\View\Factory;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use Illuminate\Routing\Redirector;
use Illuminate\Support\Facades\DB;
use Illuminate\View\View;

class ImageController extends Controller
{
    public function index()
    {
        $Image = Image::all();
        return view('image.index', compact('Image'));
    }


    public function create()
    {
        return view('image.upload');
    }

    public function store(Request $request)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $newFileName = $request->get('name');
        $fileName = $request->image->getClientOriginalName();
        $fileError = $request->image->getError();
        $fileSize = $request->image->getSize();
        $fileExt = explode(".", $fileName);
        $fileActualExt = strtolower(end($fileExt));
        $allowed = array("jpg", "jpeg", "png");
        if (in_array($fileActualExt, $allowed)) {
            if ($fileError === 0) {
                if ($fileSize < 2000000) {
                    $imageFullName = $newFileName . "." . uniqid("", true) . "." . $fileActualExt;
                    $sql = Image::all();
                    if (!$sql) {
                        echo "SQL statement failed!";
                    } else {
                        $image = Image::create([
                            'name'=>$request->get('name'),
                            'imgFull'=>$imageFullName,
                        ]);
                        $image->save();
                        if (!$image->save()) {
                            echo "SQL statement failed!";
                        } else {
                            $image->save();
                            $request->image->move('img/gallery', $imageFullName);
                            return redirect('/image');
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

    public function show($id)
    {
        $image = Image::findOrFail($id);
        return 'Name: ' . $image->name
            . '<br/>Image: ' . $image->imgFull;
    }


    public function update(Request $request, $id)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $image = Image::find($id);
        $newFileName = $request->get('name');
        $fileName = $request->get('image')->getClientOriginalName();
        $fileExt = explode(".", $fileName);
        $fileActualExt = strtolower(end($fileExt));
        $imageFullName = $newFileName . "." . uniqid("", true) . "." . $fileActualExt;
        $image -> first_name = $request->get('name');
        $image -> imgFull = $imageFullName;
        $image->save();
        $request->get('image')->move('img/gallery', $imageFullName);
        return redirect('/image');
    }

    public function destroy($id)
    {
        $image = Image::find($id);
        $image->delete();
        return redirect('/image');
    }
}
