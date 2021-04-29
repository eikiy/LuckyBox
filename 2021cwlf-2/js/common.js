$(function () {
  //SCROLL MENU
  $('.scroll').click(function (event) {
    event.preventDefault();
    $('html,body').animate({ scrollTop: $(this.hash).offset().top - 180 }, 1200);
  });
  
  //MENU
  $('.navbar-nav .nav-link.scroll').click(function (e) {
    e.preventDefault();
    $('.navbar-toggler').removeClass('open');
    $('.navbar-collapse').removeClass('open');
  });


  //SLICK
  $(window).load(function() {
    $('.flexslider').flexslider({
      animation: "fade"
    });
  });

  //SCROLLUP
  $.scrollUp({
    scrollName: 'scrollUp', // Element ID
    topDistance: '300', // Distance from top before showing element (px)
    topSpeed: 300, // Speed back to top (ms)
    animation: 'fade', // Fade, slide, none
    animationInSpeed: 200, // Animation in speed (ms)
    animationOutSpeed: 200, // Animation out speed (ms)
    scrollText: '<img src="images/scrollup.svg">', // Text for element
    activeOverlay: false, // Set CSS color to display scrollUp active point, e.g '#00FFFF'
  });
});
