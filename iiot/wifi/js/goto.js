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



