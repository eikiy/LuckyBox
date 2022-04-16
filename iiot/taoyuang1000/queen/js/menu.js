//點右邊top

 $(function(){
  $(window).scroll(function(){
    if( $(window).scrollTop() > 400 ){
      $("a.gotop").stop(true,false).animate({opacity:1},);
    }else{
      $("a.gotop").stop(true,false).animate({opacity:0},);
    }
  });
  $("a.gotop").click(function goTop(){
    $("html,body").stop(true,false).animate({scrollTop:0},900);
  });
  return false;
 });

// nav
$(function(){
  $('.go-section-01').click(function(){ $('html,body').animate({scrollTop:$('#goThe01').offset().top-100}, 800); });
  $('.go-section-02').click(function(){ $('html,body').animate({scrollTop:$('#goThe02').offset().top-100}, 800); });
  $('.go-section-03').click(function(){ $('html,body').animate({scrollTop:$('#goThe03').offset().top-100}, 800); });
  $('.go-section-04').click(function(){ $('html,body').animate({scrollTop:$('#goThe04').offset().top-100}, 800); });
  $('.go-section-05').click(function(){ $('html,body').animate({scrollTop:$('#goThe05').offset().top-100}, 800); });
});

// sub-menu
$(function(){
  $('.dropdown a.title').click(function(){
    $(this).next(".sub-menu").stop(true, true).fadeToggle();
    return false;
  });
});