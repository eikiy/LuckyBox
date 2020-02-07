
import '../css/style.scss'

+(function() {          
  // window.addEventListener("scroll", function() {
  //   var y = this.scrollY;
  //   if (y < mocha_y) {
  //     $(".sub-menu").slideUp('slow');
  //     } else {
  //       $(".sub-menu").slideDown('slow');
  //     }
  // });
  $('nav.menu li a').click(function() {
    event.preventDefault();
    if ($.attr(this, 'href') == "#") {
      $('html, body, .container-fluid').stop(true, true).animate({
        scrollTop: 0
      }, 500);
    }
    $('html, body, .container-fluid').stop(true, true).animate({
      scrollTop: $($.attr(this, 'href')).offset().top
    }, 500);
    return false;
  });
}())
