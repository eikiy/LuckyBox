$(function(){
   	// $('.go00').click(function(){ $('html,body').animate({scrollTop:0},900);});
	$('.go01').click(function(){ $('html,body').animate({scrollTop:$('#goThe01').offset().top}, 800); });

	$('.inside_go01').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_01').offset().top}, 800); });
	$('.inside_go02').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_02').offset().top}, 800); });
	$('.inside_go03').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_03').offset().top}, 800); });
	$('.inside_go04').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_04').offset().top}, 800); });
	$('.inside_go05').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_05').offset().top}, 800); });
	$('.inside_go06').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_06').offset().top}, 800); });
	return false;
});

$(function(){
	$("ul.menu_type li h5.has_sub").click(function(){
	  $(this).parent().find('ul.the_sub_menu').toggle();
	});
	return false;
});
$(function(){
	$(".for_mob_box a.more").click(function(){
	  $(this).parent().find('.box-none').toggle();
	});
	return false;
});

// 點 lightbox 商品圖 上面介紹和選項隱藏
$(function(){
	$(".produc_right_deta").click(function(){
		$(this).parent().find('.produc_left_menu').find('.for_mob_box').find('.box-none').hide();
	  $(this).parent().find('.produc_left_menu').find('.for_mob_box').find('.box-none').find('.menu_type').find('.type_title').find('.the_sub_menu').hide();
	});
	return false;
});


// $(function(){
// 	     // var _width = $(window).width(); 
// 	     if( $(window).width() < 750){
// 	         $("ul.golink_list").addClass("mob-hide-menu");
// 	     }else{
// 	     	$("ul.golink_list").removeClass("mob-hide-menu");
// 	     } 
// });
// function checkWidth(init)
// {
//     /*If browser resized, check width again */
//     if ($(window).width() < 750) {
//         $('ul.golink_list').addClass('mob-hide-menu');
//     }
//     else {
//         if (!init) {
//             $('ul.golink_list').removeClass('mob-hide-menu');
//         }
//     }
// }

// 增加mob-hide-menu讓他滑動隱藏上移才出現
$(function(){
// $(window).on('resize', function(){
      var win = $(this);
      if (win.width() < 750) { 
      $('ul.golink_list').addClass('mob-hide-menu');
  	}
    else{
      $('ul.golink_list').removeClass('mob-hide-menu');
    }

});

//點右邊top
$(function(){
	$(window).scroll(function(){
		var HEIGHT = $(window).scrollTop() + $(window).innerHeight()-110;
		if( $(window).scrollTop() > 400 ){
			$("#TOP").stop(true,false).animate({top:HEIGHT},500);
		}else{
			$("#TOP").stop(true,false).animate({bottom:-60},900);
		}
	});
	$("#TOP").click(function goTop(){
		$("html,body").stop(true,false).animate({scrollTop:0},900);
	});
	return false;
});


// $(function(){
// 	$(window).scroll(function(){
// 		var HEIGHT = $(window).scrollTop() + $(window).innerHeight()-110;
// 		if( $(window).scrollTop() > 300 ){
// 			$(".s_sideMenu").stop(true,true).show();
// 		}else{
// 			$(".s_sideMenu").stop(true,true).hide();
// 		}
// 	});
// 	return false;
// });

// TEST
// $(function(){
// 	function windowSize() {
// 	    if ($(window).width() > 1180), {
// 	        $('body').addClass('mobile').removeClass('desktop');
// 	    } else {
// 	        $('body').addClass('desktop').removeClass('mobile');
// 	        $('#holder').html('Desktop Size');
// 	    }
// 	};
// 	$(window).resize(function() {
// 	    windowSize();
// 	});
// 	windowSize();
// });

// $(function(){
// 	$( "ul.menu_type li h5" ).click(
// 	 function() {
// 	 	$(this).parent().find('ul.the_sub_menu').show();
// 	    $(this).parent().addClass("open");
// 	  }, function() {
// 	  	$(this).parent().find('ul.the_sub_menu').hide();
// 	    $(this).parent().removeClass("open");
// 	  }
// 	);
// 	return false;
// });


// $(function(){
//     $('ul.menu_type li h5').click(function () {
//         if (!$(this).parent().hasClass('open')) {
//             $(this).parent().find('ul.the_sub_menu').addClass('ul_show');
//         } else {
//             $(this).parent().find('ul.the_sub_menu').removeClass('ul_show');
//         }
//     });
//     return false;
// });





// 左邊選單
// $(function(){
//     $('ul.menu_type li h5').click(function () {
//         if (!$('.dLeft').hasClass('menu-left')) {
//             $('.dLeft').addClass('menu-left');
//             $('#rightEditBox').removeClass('rightEditBox_w100');
//         } else {
//             $('.dLeft').removeClass('menu-left');
//             $('#rightEditBox').addClass('rightEditBox_w100');
//         }
//     });
// });
