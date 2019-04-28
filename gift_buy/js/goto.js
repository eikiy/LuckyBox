// top
$(function(){
	$('a.go_top').click(function(){ $('html,body').animate({scrollTop:0},900);});
	return false;
});

// blur
$(function(){
	$('#show_order').click(function(){
		$('#go_order').show();
		$('#info-box').addClass('for_blur');
		$('#header-box').addClass('for_blur');
	});
	$('.btn_close').click(function(){
		$('#go_order').hide();
		$('#info-box').removeClass('for_blur');
		$('#header-box').removeClass('for_blur');
	});
	return false;
});