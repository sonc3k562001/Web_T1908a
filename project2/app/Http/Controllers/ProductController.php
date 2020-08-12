<?php

namespace App\Http\Controllers;

use App\Model\Product;
use Illuminate\Contracts\Foundation\Application;
use Illuminate\Contracts\View\Factory;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use Illuminate\Routing\Redirector;
use Illuminate\Support\Facades\DB;
use Illuminate\View\View;

class ProductController extends Controller
{
    public function index()
    {
        $Product = Product::all();
        return view('product.index', compact('Product'));
    }


    public function create()
    {
        return view('product.upload');
    }

    public function store(Request $request)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $newFileName = $request->get('name1'.'name2');
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
                    $sql = Product::all();
                    if (!$sql) {
                        echo "SQL statement failed!";
                    } else {
                        $product = Product::create([
                            'name1'=>$request->get('name1'),
                            'name2'=>$request->get('name2'),
                            'cmnd'=>$request->get('cmnd'),
                            'birthday'=>$request->get('birthday'),
                            'address'=>$request->get('address'),
                            'numberphone'=>$request->get('numberphone'),
                            'email'=>$request->get('email'),
                            'username'=>$request->get('username'),
                            'password'=>$request->get('password'),
                            'status'=>$request->get('status'),
                            'imgFull'=>$imageFullName,
                        ]);
                        $product->save();
                        if (!$product->save()) {
                            echo "SQL statement failed!";
                        } else {
                            $product->save();
                            $request->image->move('img/gallery', $imageFullName);
                            return redirect('/product');
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
        $product = Product::findOrFail($id);
        return 'Name: ' . $product->name1 . $product->name2
            . '<br/>Cmnd: ' . $product->cmnd
            . '<br/>Birthday: ' . $product->birthday
            . '<br/>Address: ' . $product->address
            . '<br/>Numberphone: ' . $product->numberphone
            . '<br/>Email: ' . $product->email
            . '<br/>Username: ' . $product->username
            . '<br/>Password: ' . $product->password
            . '<br/>Status: ' . $product->status
            . '<br/>Image: ' . $product->imgFull;
    }

    public function searchByName(Request $request)
    {
        $products = Product::where('name', 'like', '%' . $request->value . '%')->get();

        return response()->json($products);
    }

    public function searchById(Request $request)
    {
        $products = Product::where('id', 'like', '%' . $request->value . '%')->get('id');

        return response()->json($products);
    }


    public function edit($id)
    {
        $product = Product::find($id);
        return view('product.edit', compact('product'));
    }

    public function update(Request $request, $id)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $product = Product::find($id);
        $newFileName = $request->get('name1'.'name2');
        $fileName = $request->get('image')->getClientOriginalName();
        $fileExt = explode(".", $fileName);
        $fileActualExt = strtolower(end($fileExt));
        $imageFullName = $newFileName . "." . uniqid("", true) . "." . $fileActualExt;
        $product -> name1 = $request->get('name1');
        $product -> name2 = $request->get('name2');
        $product -> cmnd =$request->get('cmnd');
        $product -> birthday =$request->get('birthday');
        $product -> address =$request->get('address');
        $product -> numberphone =$request->get('numberphone');
        $product -> email =$request->get('email');
        $product -> username =$request->get('username');
        $product -> password =$request->get('password');
        $product -> status =$request->get('status');
        $product -> imgFull = $imageFullName;
        $product->save();
        $request->get('image')->move('img/gallery', $imageFullName);
        return redirect('/product');
    }

    public function destroy($id)
    {
        $product = Product::find($id);
        $product->delete();
        return redirect('/product');
    }
}
