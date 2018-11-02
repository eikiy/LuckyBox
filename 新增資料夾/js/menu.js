
//點右邊top
 // $(function(){
	// $(window).scroll(function(){
	// 	var HEIGHT = $(window).scrollTop() + $(window).innerHeight()-110;
	// 	if( $(window).scrollTop() > 400 ){
	// 		$("#TOP").stop(true,false).animate({top:HEIGHT},500);
	// 	}else{
	// 		$("#TOP").stop(true,false).animate({bottom:-60},900);
	// 	}
	// });
	// $("#TOP").click(function goTop(){
	// 	$("html,body").stop(true,false).animate({scrollTop:0},900);
	// });
	// return false;
 // });



// $(function(){
// 　$(window).load(function(){
// 　　$(window).bind('scroll resize', function(){
// 　　var $this = $(this);
// 　　var $this_Top=$this.scrollTop();
// 　　if($this_Top > 10){
// 	$('.headerDown').addClass('Down100')
// 　　　}
// 　　　　if($this_Top < 30){
// 　　　　$('.headerDown').addClass('Down0').removeClass('Down100');
// 　　　 }
// 　　}).scroll();
// 　});
// });

$(function(){
	$("h1.logo").click(function(){ $("html,body").animate({scrollTop:0},900);});
   	$('.go00').click(function(){ $('html,body').animate({scrollTop:0},900);});
	$('.go01').click(function(){ $('html,body').animate({scrollTop:$('#goThe01').offset().top}, 800); });
	$('.go02').click(function(){ $('html,body').animate({scrollTop:$('#goThe02').offset().top}, 800); });
	$('.go03').click(function(){ $('html,body').animate({scrollTop:$('#goThe03').offset().top}, 800); });
	$('.go04').click(function(){ $('html,body').animate({scrollTop:$('#goThe04').offset().top}, 800); });
	$('.go05').click(function(){ $('html,body').animate({scrollTop:$('#goThe05').offset().top}, 800); });
	$('.go06').click(function(){ $('html,body').animate({scrollTop:$('#goThe06').offset().top}, 800); });
	return false;
});


// holkee shop
// $(function(){
// 	$('.goto_01').click(function(){ $('html,body').animate({scrollTop:$('#gotothe_01').offset().top}, 800); });
// 	$('.goto_02').click(function(){ $('html,body').animate({scrollTop:$('#gotothe_02').offset().top}, 800); });
// 	$('.goto_03').click(function(){ $('html,body').animate({scrollTop:$('#gotothe_03').offset().top}, 800); });
// 	$('.goto_04').click(function(){ $('html,body').animate({scrollTop:$('#gotothe_04').offset().top}, 800); });
// 	$('.goto_05').click(function(){ $('html,body').animate({scrollTop:$('#gotothe_05').offset().top}, 800); });
// 	$('.goto_06').click(function(){ $('html,body').animate({scrollTop:$('#gotothe_06').offset().top}, 800); });
// 	return false;
// });

