<?php

namespace App\Http\Controllers;

use App\Acc;
use App\User;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use PhpParser\Node\Stmt\Return_;

class UserController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        //
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
        //
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
    // phần này là phần đăng kí
    public function getRegistration()
    {
        return view('registration');
    }
    public function postRegistration(Request $request)
    {
        $user = new User;
        $user -> first_name = $request->get('first_name');
        $user -> last_name = $request->get('last_name');
        $user -> cmnd =$request->get('cmnd');
        $user -> birthday =$request->get('birthday');
        $user -> address =$request->get('address');
        $user -> numberphone =$request->get('numberphone');
        $user -> email =$request->get('email');
        $user -> password = bcrypt($request->password);
        $user->save();
        return redirect('/login')->with('thong bao','dang ki thanh cong');//đoạn này là trả về login và in ra câu thông báo
    }
    //phần này là phần của login

    public function getLogin()
    {
        return view('login');
    }
    public function postLogin(Request $req)
    {
        $arr = array('email'=>$req->email,'password'=>$req->password);
        if (Auth::attempt($arr)){
            return redirect('')->with(['flag'=>'success','message'=>'dang nhap thanh cong']);// chỗ này là khi đang nhập thành công thì trả về trang nào đó
        }else{
            return redirect()->back()->with(['flag'=>'danger','message'=>'dang nhap khong thanh cong']);
        }
    }
// phần này là phần đăng xuất
    public function postLogout(){
        Auth::logout();
        Return view('welcome');
    }
//chỗ này là phần chuyển tiền

    public function getBank(){
        return view('banking');
    }
    public function postBank(){

    }
}
