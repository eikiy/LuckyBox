$(document).ready(function() {

    $(window).scroll(function() { //設定視窗捲軸函數
        if ($(window).scrollTop() > 100) {
            $('header').addClass('sticky', 300, 'easeInSine');
            $('.gotop').fadeIn();

        } else {

            
            $('header').removeClass('sticky', 300, 'easeInSine');

            $('.gotop').fadeOut();

        }
    });

    $(document).ready(function() {
      if ($(window).width() < 850) {
        $(".coupon .card").removeClass("wi800");
      } else {
        $(".coupon .card").addClass('wi800');
      }
    });



    $("header").load("header.html");

    $(".footer").load("footer.html");

    $(".slideTitle").append('<img src="img/t1.png" alt="" class="slideTitle-1"><img src="img/t2.png" alt="" class="slideTitle-2">');

    $("head").append('<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no"><link rel="stylesheet" href="css/reset.css"> <link rel="stylesheet" href="css/default.css" type="text/css" media="screen" /> <link rel="stylesheet" href="css/nivo-slider.css" type="text/css" media="screen" /> <link rel="stylesheet" href="css/bootstrap.css"> <link rel="stylesheet" href="fonticons/css/kim.css"> <link rel="stylesheet" href="css/footer.css"> <link rel="stylesheet" href="css/style.css"> <link rel="stylesheet" href="css/action.css"> <link rel="stylesheet" href="css/rwd.css">');

    $(".footer").append('<script type="text/javascript" src="js/jquery.nivo.slider.pack.js"></script><script type="text/javascript">$(window).load(function() {$("#slider").nivoSlider();});</script>');

    

    $(document).ready(function() {
      if ($(window).width() < 768) {
        $("#slider").append('<img src="img/slide01.jpg" alt=""><img src="img/slide02-2.jpg" alt="" class="slide2-m">');
      } else {
        $("#slider").append('<img src="img/slide01.jpg" alt=""><img src="img/slide02.jpg" alt="" class="slide2">');
      }
    });

});
