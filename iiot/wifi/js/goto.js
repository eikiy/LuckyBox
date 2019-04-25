// header 這邊跑不出來....><
$(function(){
　$(window).load(function(){
　　$(window).bind('scroll resize', function(){
　　var $this = $(this);
　　var $this_Top=$this.scrollTop();
　　//當高度小於
　　if($this_Top > 400){
  $('.header_box').addClass('top_header_fixed')
　　　}
　　　　if($this_Top < 400){
　　　　$('.header_box').removeClass('top_header_fixed');
　　　 }
　　}).scroll();
　});
});


// animate
$(function(){
	new WOW().init();
});

// side menu
function openNav() {
	document.getElementById("theSidenav").style.width = "350px";
	document.getElementById("Main_Contents").classList.add("for_blur");
	document.getElementById("header_box").classList.add("for_blur");
}
function closeNav() {
	document.getElementById("theSidenav").style.width = "0";
	document.getElementById("Main_Contents").classList.remove("for_blur");
	document.getElementById("header_box").classList.remove("for_blur");
}

// faq
$(function(){
	$(".faq_box ul.faq_list li").click(function(){
	  $(this).find('.faq_info').find('.answer').slideToggle();
	});
	return false;
});

// QA go
$(function(){
	$('.go_01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top - 50}, 800); });
	$('.go_02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 50}, 800); });
	$('.go_03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top - 50}, 800); });
	$('.go_04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top - 50}, 800); });
	$('.go_05').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_05').offset().top - 50}, 800); });
	$('.go_06').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_06').offset().top - 50}, 800); });
	$('.go_07').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_07').offset().top - 50}, 800); });
	$('.go_08').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_08').offset().top - 50}, 800); });
	$('.go_09').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_09').offset().top - 50}, 800); });
	$('.go_10').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_10').offset().top - 50}, 800); });
	return false;
});
