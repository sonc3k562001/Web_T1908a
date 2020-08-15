<?php
?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/protect.css')}}" media="all">
@endsection

@section('main')
    <section class = "intro col-xs-12 col-md-12">
        <div class = "container">
            <div class = "row">
                <div class = "intro-content col-xs-6 col-md-6">
                    <h1>Keep your money safe from fraudsters</h1>
                    <h3>We’ve seen a spike in the number of scams in the UK where fraudsters trick you into sending them money by pretending to be someone you trust. Fraudsters are professionals, and can make their calls and emails seem legitimate.</h3>
                    <h3>We've put together a list of the scams we're seeing and how to protect yourself from them.</h3>
                    <h3>If you’re not 100% sure about a payment, stop, think and ask a friend or family member for advice. Bank transfers aren’t protected in the same way as card payments, so once you’ve made a payment it’s almost impossible to recover the money...</h3>
                </div>
                <div class="img col-xs-6 col-md-6">
                    <img src = "{{asset('images/nganhang4.jpg')}}" width="650" height="650">
                </div>
            </div>
        </div>
    </section>

    <section class = "content col-xs-12 col-md-12">
        <div class="content1 text-center col-xs-12">
            <h2>What to do if you've been a victim of fraud</h2>
            <p>If you've been tricked by a fraudster into sending them money, chat to us or give us a call on 0123456789 for advice and help.</p>
        </div>

        <div class="content2 col-xs-12 col-md-12">
            <div class="col-xs-3">
                <i class="fas fa-university"></i>
                <h2>Pretending to be your Bank</h2>
                <h4>Fraudsters could contact you pretending to be from your bank. They’ll tell you there’s a problem with your account, and ask you to move your money to “a safe account”.</h4>
            </div>
            <div class="col-xs-1">
            </div>
            <div class="col-xs-3">
                <i class="fas fa-user-circle"></i>
                <h2>Pretending to be HMRC</h2>
                <h4>Fraudsters could contact you pretending to be from HMRC. They might threaten you with legal action if you don’t pay fast, or they could send you a link offering money as a 'goodwill payment’.</h4>
            </div>
            <div class="col-xs-1">
            </div>
            <div class="col-xs-3">
                <i class="fas fa-user-shield"></i>
                <h2>Pretending to be the police, or a company you trust</h2>
                <h4>Fraudsters could call, email or text you pretending to be the police, your electricity company, your landlord... They might pressure you into paying them to 'avoid legal action'.</h4>
            </div>
        </div>

        <div class="content2 col-xs-12 col-md-12">
            <div class="col-xs-3">
                <i class="fas fa-envelope"> </i>
                <h2>Investment scams</h2>
                <h4>Fraudsters will try to convince you to pay for a fake investment with the promise of a high return. Remember: Legitimate investments don’t happen over social media, and will never guarantee profits. Check if a company’s registered with the FCA before investing.</h4>
            </div>
            <div class="col-xs-1">
            </div>
            <div class="col-xs-3">
                <i class="fas fa-envelope"> </i>
                <h2>Coronavirus related scams</h2>
                <h4>Like a lot of banks, we’re also seeing more coronavirus scams, like fake texts from HMRC offering money as a 'goodwill payment', or from the government offering ‘tax relief’. These are scams, so always check official sites before clicking on any links!</h4>
            </div>
            <div class="col-xs-1">
            </div>
            <div class="col-xs-3">
                <i class="fas fa-envelope"> </i>
                <h2>Phishing scams</h2>
                <h4>We've also seen an increase in phishing scams, where fraudsters send you a text message or email that looks legitimate, and ask you to click on a link and fill in some information (like passwords, account numbers etc). They then use this info to scam you.</h4>
            </div>
        </div>
        <div class="content3 col-xs-12 col-md-12">
            <div class="col-xs-1"></div>
            <div class="col-xs-6">
                <h2>How to make sure it's not fraud</h2>
                <b>Double check:</b>
                <p>Is the person you're paying really who they say they are?
                    If you received an unexpected call from your bank, HMRC or another organisation, hang up the phone, Google their official number and call them back. If you received an email asking to transfer money from a friend, your landlord or someone else,
                    try contacting them by a different method. Fraudsters can spoof phone numbers and make their emails look legitimate.</p>
                <b>Take your time:</b>
                <p>An organisation you trust will never pressure you into making a payment. If you're unsure, speak to a friend or family member, or give us a call.</p>
                <b>If it seems too good to be true, it probably is!</b>
                <p>If you're being offered something very cheaply over social media, it's probably a scam. Buy from a trusted merchant where you can check verified reviews.</p>
                <b>Pay by card instead of bank transfer if you can.</b>
                <p>Card payments are better protected, and once you send a bank transfer to a fraudster it's almost impossible to get your money back.</p>
            </div>
            <div class="img1 col-xs-5">
                <img src="//images.ctfassets.net/ro61k101ee59/5dcWfUIrjrG3xVwV1lpK7O/af3564260ca241597f756dc5bb778835/Image_How_to_make_sure_it_s_not_fraud.png" width="650" height="560">
            </div>
        </div>
    </section>
    <section class="end col-xs-12 col-md-12">

    </section>
@endsection