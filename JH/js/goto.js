$(function(){
   	$('.go00').click(function(){ $('html,body').animate({scrollTop:0},900);});
	$('.go01').click(function(){ $('html,body').animate({scrollTop:$('#goThe01').offset().top}, 800); });
	return false;
});