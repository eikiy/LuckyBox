$(function(){
   	$('.go00').click(function(){ $('html,body').animate({scrollTop:0},900);});
	$('.go01').click(function(){ $('html,body').animate({scrollTop:$('#goThe01').offset().top}, 800); });
	$('.inside_go01').click(function(){ $('html,body').animate({scrollTop:$('#inside_goto_01').offset().top}, 800); });
	return false;
});



$(function(){
	$('a.goto_step2').click(function(){
		$('#buy_list').hide();
		$('#pay_info').hide();
		$('#fill_info').show();
		$('html,body').animate({scrollTop:0},900);
		$('#top_step ul.contents_box').find('li').removeClass('btn_in');
		$('#top_step ul.contents_box').find('li.step-2').addClass('btn_in');
	});
	return false;
});

$(function(){
	$('a.goto_step3').click(function(){
		$('#buy_list').hide();
		$('#fill_info').hide();
		$('#pay_info').show();
		$('html,body').animate({scrollTop:0},900);
		$('#top_step ul.contents_box').find('li').removeClass('btn_in');
		$('#top_step ul.contents_box').find('li.step-3').addClass('btn_in');
	});
	return false;
});

$(function(){
	$('.the_switch a.show_info').click(function(){
		$(this).parent().removeClass('the_switch');
		$(this).hide();
		$(this).parent().find('a.hide_info').show();
	});
	return false;
});

$(function(){
	$('a.hide_info').click(function(){
		$(this).parent().addClass('the_switch');
		$(this).hide();
		$(this).parent().find('a.show_info').show();
	});
	return false;
});

