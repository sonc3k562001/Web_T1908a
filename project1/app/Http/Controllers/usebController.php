<?php

namespace App\Http\Controllers;
use App\userb;
use Illuminate\Http\Request;

class usebController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $User = userb::all();
        return view('welcome', compact('User'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('welcome');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $request->validate([
            'image'=> 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $newFileName = $request->get('first_name'.'last_name');
        $filename = $request->image->getClientOriginalName();
        $fileType = $request->image->getMimeType();
        $fileTempName= $request->image->getPathName();
        $fileError= $request->image->getError();
        $fileSize = $request->image->getSize();
        $fileExt = explode('.',$filename);
        $fileActualExt = strtolower(end($fileExt));
        $allowed = array("jpg","jpeg","png");
        if (in_array($fileActualExt,$allowed)){
            if ($fileError === 0){
                if ($fileSize<2000000){
                    $imageFullName = $newFileName.".".uniqid("", true) . "." . $fileActualExt;
                    $sql = userb::all();
                    if (!$sql){
                        echo "SQL statement failed!";
                    }else{
                        $user = userb::create([
                            'first_name'=>$request->get('first_name'),
                            'last_name'=>$request->get('last_name'),
                            'cmnd'=>$request->get('cmnd'),
                            'address'=>$request->get('address'),
                            'email'=>$request->get('email'),
                            'birthday'=>$request->get('birthday'),
                            'username'=>$request->get('username'),
                            'password'=>$request->get('password'),
                            'status'=>$request->get('status'),
                            'img1'=>$request->get('img1'),
                            'img2'=>$request->get('img2'),
                        ]);
                        $user->save();
                        if (!$user->save()){
                            echo "SQL statement failed!";
                        }else{
                            $user->save();
                            $request->image->move('img/userb', $imageFullName);
                            return redirect('/user');
                        }
                    }
                }
            }
        }
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        $request->validate([
            'image' => 'required|image|mimes:jpeg,png,jpg,gif,svg|max:2048',
        ]);
        $user = userb::find($id);
        $newFileName = $request->get('first_name'.'last_name');
        $fileName = $request->get('image')->getClientOriginalName();
        $fileExt = explode(".", $fileName);
        $fileActualExt = strtolower(end($fileExt));
        $imageFullName = $newFileName . "." . uniqid("", true) . "." . $fileActualExt;
        $user -> first_name = $request->get('first_name');
        $user -> last_name = $request->get('last_name');
        $user -> cmnd =$request->get('cmnd');
        $user -> email =$request->get('email');
        $user -> address =$request->get('address');
        $user -> birthday =$request->get('birthday');
        $user -> username =$request->get('username');
        $user -> password =$request->get('password');
        $user -> status =$request->get('status');
        $user -> img1 =$request->get('img1');
        $user -> img2 =$request->get('img2');
        $user -> imgFull = $imageFullName;
        $user->save();
        $request->get('image')->move('img/user', $imageFullName);
        return redirect('/user');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
