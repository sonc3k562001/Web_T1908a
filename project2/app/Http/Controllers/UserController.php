<?php

namespace App\Http\Controllers;

use App\Acc;
use App\User;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;
use mysql_xdevapi\Table;
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
        return view('content.create');
    }
    public function postRegistration(Request $request)
    {
        $user = new User;
        $acc =new Acc;
        $user -> first_name = $request->get('first_name');
        $user -> last_name = $request->get('last_name');
        $user -> cmnd =$request->get('cmnd');
        $user -> birthday =$request->get('birthday');
        $user -> address =$request->get('address');
        $user -> numberphone =$request->get('numberphone');
        $user -> email =$request->get('email');
        $user -> password = bcrypt($request->password);
        $user -> balance = 0;
        $user->save();
        return redirect('content.login')->with('thong bao','dang ki thanh cong');//đoạn này là trả về login và in ra câu thông báo
    }
    //phần này là phần của login

    public function getLogin()
    {
        return view('content.login');
    }
    public function postLogin(Request $req)
    {
        $arr = array('email'=>$req->email,'password'=>$req->password);
        if (Auth::attempt($arr)){
            return redirect()->with(['flag'=>'success','message'=>'dang nhap thanh cong']);// chỗ này là khi đang nhập thành công thì trả về trang nào đó
        }else{
            return redirect()->back()->with(['flag'=>'danger','message'=>'dang nhap khong thanh cong']);
        }
    }
    //chỗ này là phần chuyển tiền

    public function getBank(){
        return view('bank');
    }
    public function postBank(Request $request)
    {
        $arr = array('acc_num'=>$request->acc_num);
        if (Auth::attempt($arr)){
            $user = new User;
            $users = User::findOrFail($acc_num = $request->get('acc_num'));
            $b1=$users->balance;
            $b1=(int)$b1;
            $b2=$user->balance;
            $b2=(int)$b2;

            $b1= $b1-$request->minus;
            $b2= $b2+$request->minus;

            $update1=DB::update('update user set balance = ? where id=1',$b1,$user->acc_num);
            $update2=DB::update('update user set balance = ? where id=2',$b2,$request->acc_num);

            return $update1 . $update2;
        }else{
            return redirect()->back()->with(['flag'=>'danger','message'=>'tai khoan dich khong dung']);
        }
    }
// phần này là phần đăng xuất
    public function postLogout(){
        Auth::logout();
        Return view('content.home');
    }


}
