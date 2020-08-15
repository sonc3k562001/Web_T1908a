<?php

namespace App\Http\Controllers;

use App\Model\Userb;
use Illuminate\Contracts\Foundation\Application;
use Illuminate\Contracts\View\Factory;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use Illuminate\Routing\Redirector;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;
use Illuminate\View\View;

class UserbController extends Controller
{


    public function getLogin()
    {
        return view('login');//return ra trang login để đăng nhập
    }

    public function postLogin(Request $request)
    {
        $arr = [
            'username' => $request->username,
            'password' => $request->password,
        ];
        if ($request->remember == trans('remember.Remember Me')) {
            $remember = true;
        } else {
            $remember = false;
        }


        if (Auth::guard('loyal_customer')->attempt($arr)) {

            dd('đăng nhập thành công');

        } else {

            dd('tài khoản và mật khẩu chưa chính xác');

        }
    }


    public function index()
    {
        $Userb = Userb::all();
        return view('userb.index', compact('Userb'));
    }


    public function create()
    {
        return view('userb.upload');
    }

    public function store(Request $request)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $newFileName = $request->get('first_name'.'last_name');
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
                    $sql = Userb::all();
                    if (!$sql) {
                        echo "SQL statement failed!";
                    } else {
                        $userb = Userb::create([
                            'first_name'=>$request->get('first_name'),
                            'last_name'=>$request->get('last_name'),
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
                        $userb->save();
                        if (!$userb->save()) {
                            echo "SQL statement failed!";
                        } else {
                            $userb->save();
                            $request->image->move('img/gallery', $imageFullName);
                            return redirect('/login');
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
        $userb = Userb::findOrFail($id);
        return 'Name: ' . $userb->first_name . $userb->last_name
            . '<br/>Cmnd: ' . $userb->cmnd
            . '<br/>Birthday: ' . $userb->birthday
            . '<br/>Address: ' . $userb->address
            . '<br/>Numberphone: ' . $userb->numberphone
            . '<br/>Email: ' . $userb->email
            . '<br/>Username: ' . $userb->username
            . '<br/>Password: ' . $userb->password
            . '<br/>Status: ' . $userb->status
            . '<br/>Image: ' . $userb->imgFull;
    }

    public function searchByName(Request $request)
    {
        $userbs = Userb::where('name', 'like', '%' . $request->value . '%')->get();

        return response()->json($userbs);
    }

    public function searchById(Request $request)
    {
        $userbs = Userb::where('id', 'like', '%' . $request->value . '%')->get('id');

        return response()->json($userbs);
    }


    public function edit($id)
    {
        $userb = Userb::find($id);
        return view('userb.edit', compact('userb'));
    }

    public function update(Request $request, $id)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $userb = Userb::find($id);
        $newFileName = $request->get('first_name'.'last_name');
        $fileName = $request->get('image')->getClientOriginalName();
        $fileExt = explode(".", $fileName);
        $fileActualExt = strtolower(end($fileExt));
        $imageFullName = $newFileName . "." . uniqid("", true) . "." . $fileActualExt;
        $userb -> first_name = $request->get('first_name');
        $userb -> last_name = $request->get('last_name');
        $userb -> cmnd =$request->get('cmnd');
        $userb -> birthday =$request->get('birthday');
        $userb -> address =$request->get('address');
        $userb -> numberphone =$request->get('numberphone');
        $userb -> email =$request->get('email');
        $userb -> username =$request->get('username');
        $userb -> password =$request->get('password');
        $userb -> status =$request->get('status');
        $userb -> imgFull = $imageFullName;
        $userb->save();
        $request->get('image')->move('img/gallery', $imageFullName);
        return redirect('/login');
    }

    public function destroy($id)
    {
        $userb = Userb::find($id);
        $userb->delete();
        return redirect('/userb');
    }
}
