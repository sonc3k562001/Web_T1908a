<?php

?>

@extends('layouts.default')

@section('css')
    <link rel="stylesheet" type="text/css" href="{{asset('css/faq.css')}}" media="all">
@endsection

@section('main')
    <section class = "faq col-xs-12 col-md-12">
        <div class = "container">
            <div class = "row">
                <div class = "faq-list col-xs-12 col-md-12">
                    <div class = "faq-summary col-xs-4 col-md-4">
                        <h2>Frequently Asked Questions</h2>
                        <p>If you have any trouble or problem when using our services,
                            You can find answer related to our services here.</p>
                        <img class = "col-xs-12 col-md-12" src = "{{asset('images/faq.png')}}">
                    </div>
                    <div class = "faq-questions col-xs-8 col-md-8">
                        <div class = "faq-questions-box col-xs-12 col-md-12">
                            <div class = "faq-questions-box-header col-xs-12 col-md-12"></div>
                            <h2 class = "text-center">Which Material Type You Can Work With?</h2>
                            <p>Our services and product support customer with all kinds of product.
                                You can access it from anywhere: PC, tablet, smartphone,...</p>
                        </div>
                        <div class = "faq-questions-box col-xs-12 col-md-12">
                            <div class = "faq-questions-box-header col-xs-12 col-md-12"></div>
                            <h2 class = "text-center">Is SmartLock Requires For Instant Apps?</h2>
                            <p>There is no need to using SmartLock. However, it is strongly recommended
                                for safety measures of your account.</p>
                        </div>
                        <div class = "faq-questions-box col-xs-12 col-md-12">
                            <div class = "faq-questions-box-header col-xs-12 col-md-12"></div>
                            <h2 class = "text-center">Can I Log-in My Accounts In Different Machines At The Same Time?</h2>
                            <p>No, you can't. If you log-in your account in another machine, the account you are using
                                will be log-out. We doing this to make sure your account is always under your control.</p>
                        </div>
                        <div class = "faq-questions-box col-xs-12 col-md-12">
                            <div class = "faq-questions-box-header col-xs-12 col-md-12"></div>
                            <h2 class = "text-center">Why Choose Our Services?</h2>
                            <p>Even if we are fresh-blood in our services, we have a strong foundation
                                in our services coming from expertise from all around the world. And most importantly,
                                we are eager to improve the customer satisfaction.</p>
                        </div>
                        <div class = "faq-questions-box col-xs-12 col-md-12">
                            <div class = "faq-questions-box-header col-xs-12 col-md-12"></div>
                            <h2 class = "text-center">How To Get Started With Us?</h2>
                            <p>By sign up (which is completely free), you will gain access to an e-bank. After that,
                                if you required a card, in 5 - 7 days, we will send packaging contains of everything
                                necessary to use the cards as well as your personal password for it.</p>
                        </div>
                    </div>
                </div>

                <div class = "faq-email col-xs-12 col-md-12">
                    <h2 class = "text-center col-xs-12 col-md-12">Do you have any questions?</h2>
                    <p class = " text-center col-xs-12 col-md-12">If you have any personal questions or problem that was not listed above,
                        send us a message to our email.</p>
                    <form class = "col-xs-12 col-md-12">
                        <div class = "col-xs-12 col-md-12">
                            <div class = "col-xs-6 col-md-6">
                                <label class = "col-xs-12 col-md-12" for="name">Your name:</label><br>
                                <input class = "col-xs-12 col-md-12" type="text" id="name" name="name" placeholder="Nguyen Van A" required><br><br>
                            </div>
                            <div class = "col-xs-6 col-md-6">
                                <label class = "col-xs-12 col-md-12" for="email">Your email:</label><br>
                                <input class = "col-xs-12 col-md-12" type="email" id="email" name="email" placeholder="abc@xyz.com" required><br><br>
                            </div>
                        </div>

                        <div class = "col-xs-12 col-md-12">
                            <div class = "col-xs-6 col-md-6">
                                <label class = "col-xs-12 col-md-12" for="phone">Your phone number:</label><br>
                                <input class = "col-xs-12 col-md-12" type="tel" id="phone" name="phone" placeholder="01234567890" required><br><br>
                            </div>
                            <div class = "col-xs-6 col-md-6">
                                <label class = "col-xs-12 col-md-12" for="subject">What you want to ask?</label><br>
                                <input class = "col-xs-12 col-md-12" type="text" id="subject" name="subject" placeholder="I want to ask about..." required><br><br>
                            </div>
                        </div>

                        <label class = "col-xs-12 col-md-12" for="message">Message</label><br>
                        <textarea class = "col-xs-12 col-md-12" type="text" id="message" name="message" rows="5" cols="50" maxlength="140" placeholder="Your Message" required>
                    </textarea><br>

                        <button id = "submit" type="submit" value="Submit">Submit Message
                        </button>

                    </form>
                </div>
            </div>
        </div>
    </section>

    <section class = "faq-signup text-center col-xs-12 col-md-12">
        <div class = "faq-signup-content col-xs-12 col-md-12">
            <h2>Apply for an account in minutes</h2>
            <h3>Get your OnlineBanking Accounts today!</h3>
            <a href = "{{url('/create')}}"><button>GET YOUR ONLINEBANKING ACCOUNT</button></a>
        </div>
    </section>
@endsection

@section('js')
    <script>
        $(document).ready(function() {
            $('.faq-questions-box h2').on("click",function(){
                $(this)
                    .next()
                    .slideToggle();
            });
        });
    </script>
@endsection
