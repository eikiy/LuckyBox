// JavaScript Document

$(function(){
	$("#popup_all").hide();
	$("#popup_all .popup_bg").css("opacity",.80);
	
	$(".color1 .color_line .product_imgsin .product_img img").click(function(){
		
		var N=$(this).attr("src").substr(20,3);
		$("#BIG").attr("src","images/product/color"+N+".jpg");
		
		$("#popup_all").fadeIn(100);	
		});
	
	$("a.popup_close").click(function(){
		$("#popup_all").stop().fadeOut(700);
		return false;
		});

 //  $(".bio_imgall img").click(function(){
	//		var N=$(this).attr("src").substr(22,1);
//			$("#BIG").attr("src","images/product/color7-"+N+".jpg");
//		    $("#popup_all").fadeIn(100);	
//	});
	
})
