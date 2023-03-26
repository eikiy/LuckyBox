// popup-link
$(function () {
	$('.popup-link').magnificPopup({
		removalDelay: 300,
		mainClass: 'mfp-fade'
	});
});

// top subnav
$(function () {
	$(".subnav").hover(function () {
		$(this).find(".subnav-content").toggle();
		return false;
	});
});
			
// scrollTop
$(function(){
	$(window).scroll(function(){
		if( $(window).scrollTop() > 400 ){
			$("#gotop").stop(true,false).animate({opacity:1},);
		}else{
			$("#gotop").stop(true,false).animate({opacity:0},);
		}
	});
	$("#gotop").click(function goTop(){
		$("html,body").stop(true,false).animate({scrollTop:0},900);
	});
	return false;
});
// close popup
// $(function(){
// 	$("#close-popup").click(function () {
// 		$(".mfp-bg, .mfp-wrap").removeClass("mfp-close-btn-in");
// 		return false;
// 	});
// });
// mob tab
$(function(){
	$("#active-01").click(function () {
		$("#a2-open, #a3-open, #a4-open, #a5-open, #a6-open").hide();
		$("#active-02, #active-03, #active-04, #active-05, #active-06").removeClass("active");
		$("#a1-open").show();
		$(this).addClass("active");
	});
	$("#active-02").click(function () {
		$("#a1-open, #a3-open, #a4-open, #a5-open, #a6-open").hide();
		$("#active-01, #active-03, #active-04, #active-05, #active-06").removeClass("active");
		$("#a2-open").show();
		$(this).addClass("active");
	});
	$("#active-03").click(function () {
		$("#a1-open, #a2-open, #a4-open, #a5-open, #a6-open").hide();
		$("#active-01, #active-02, #active-04, #active-05, #active-06").removeClass("active");
		$("#a3-open").show();
		$(this).addClass("active");
	});
	$("#active-04").click(function () {
		$("#a1-open, #a2-open, #a3-open, #a5-open, #a6-open").hide();
		$("#active-01, #active-02, #active-03, #active-05, #active-06").removeClass("active");
		$("#a4-open").show();
		$(this).addClass("active");
	});
	$("#active-05").click(function () {
		$("#a1-open, #a2-open, #a3-open, #a4-open, #a6-open").hide();
		$("#active-01, #active-02, #active-03, #active-04, #active-06").removeClass("active");
					$("#a5-open").show();
					$(this).addClass("active");
	});
	$("#active-06").click(function () {
		$("#a1-open, #a2-open, #a3-open, #a4-open, #a5-open").hide();
		$("#active-01, #active-02, #active-03, #active-04, #active-05").removeClass("active");
		$("#a6-open").show();
		$(this).addClass("active");
	});
});