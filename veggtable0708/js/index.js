// animate
  $(function(){
    new WOW().init();
  });
 // move
  $(function(){
    $('.icon-01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top - 0}, 800); });
    $('.icon-02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 0}, 800); });
    $('.icon-03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top - 0}, 800); });
    $('.icon-04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top - 0}, 800); });
    return false;
  });

    
   //scroll top: hide
  $(window).scroll(function () {
    if ($(this).scrollTop() > 0) {
      $('#top').fadeIn();
    } else {
      $('#top').fadeOut();
    }
  });

  $(function(){
    var win = $(this);
    if (win.width() > 1199) {
      $('#top').click(function(){ $('html,body').animate({scrollTop: 0 }, 800); });
      $('.icon-01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top - 0}, 800); });
      $('.icon-02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 0}, 800); });
      $('.icon-03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top - 0}, 800); });
      $('.icon-04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top - 0}, 800); });
      return false;
    }
    else{
      $('.icon-01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top - 100}, 800); });
      $('.icon-02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 140}, 800); });
      $('.icon-03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top - 100}, 800); });
      $('.icon-04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top - 100}, 800); });
      return false;
    }
  });
