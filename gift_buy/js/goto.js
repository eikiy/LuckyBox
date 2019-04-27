// $(function(){
// 　$(window).load(function(){
// 　　$(window).bind('scroll resize', function(){
// 　　var $this = $(this);
// 　　var $this_Top=$this.scrollTop();
// 　　//當高度小於
// 　　if($this_Top > 400){
//   $('.header_box').addClass('top_header_fixed')
// 　　　}
// 　　　　if($this_Top < 400){
// 　　　　$('.header_box').removeClass('top_header_fixed');
// 　　　 }
// 　　}).scroll();
// 　});
// });



// side
// function openNav() {
// 	document.getElementById("theSidenav").style.width = "350px";
// 	document.getElementById("Main_Contents").classList.add("for_blur");
// 	document.getElementById("header_box").classList.add("for_blur");
// }
// function closeNav() {
// 	document.getElementById("theSidenav").style.width = "0";
// 	document.getElementById("Main_Contents").classList.remove("for_blur");
// 	document.getElementById("header_box").classList.remove("for_blur");
// }


// $(function(){
// 	$(" ul li").click(function(){
// 	  $(this).find('.').find('.').slideToggle();
// 	});
// 	return false;
// });

// top
$(function(){
	$('.go_02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 50}, 800); });
	return false;
});
