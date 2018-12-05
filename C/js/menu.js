// JavaScript Document

$(function(){
	$(".nav").slideToggle(1500);
	$(".content").animate({right:'0px'},1500);
	var w = $(".nav").height();

	$(".nav .navScroll").click(function(){
	if ($(".nav").css('top') == '0px')
		{
			$(".nav").animate( { top:'-260px' }, 1200 ,'swing');
		} else {
			$(".nav").animate( { top:'-'+w+'px' }, 1200 ,'swing');
		}
	});
		$(".fix_close").click(function(){
			  $(".content").animate({width: 'toggle'},1200);
	});
});

//產品應用文字區塊背景透明度
//$(function(){
//$(".shop").css("opacity",.80);
//});


//  $(function(){
//   $('.nav li.navApplication').hover(
//     function(){
//       $(this).find("ul").stop(true, true).fadeIn(0);
//     },
//     function(){
//       $(this).find("ul").stop(true, true).fadeOut(0);
//     });
//   return false;
// });

 $(function(){
  $('.nav li.navApplication').hover(function(){
    $(this).find("ul").stop(true, true).fadeToggle();
  });
});