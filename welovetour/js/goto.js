$(function(){
   	$('.go_00').click(function(){ $('html,body').animate({scrollTop:0},900);});
	$('.go_01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top}, 800); });
	$('.go_02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top}, 800); });
	$('.go_03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top}, 800); });
	$('.go_04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top}, 800); });
	$('.go_05').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_05').offset().top}, 800); });
	$('.go_06').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_06').offset().top}, 800); });
	return false;
});

$(function(){
	$('.s_go_01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top - 80}, 800); });
	$('.s_go_02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 80}, 800); });
	$('.s_go_03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top - 80}, 800); });
	$('.s_go_04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top - 80}, 800); });
	$('.s_go_05').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_05').offset().top - 80}, 800); });
	$('.s_go_06').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_06').offset().top - 80}, 800); });
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

$(function(){
	$( "ul.top_menu li" ).hover(
	 function() {
	 	$(this).find('ul.sub_menu').show();
	  }, function() {
	  	$(this).find('ul.sub_menu').hide();
	  }
	);
	return false;
});


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

