// JavaScript Document

$(function(){
	$(".nav").slideToggle(1500);
	$(".content").animate({right:'0px'},1500);
			
	var w = $(".nav").height();
    
	$(".nav .navScroll").click(function(){
		
	if ($(".nav").css('top') == '0px')
		{
			$(".nav").animate( { top:'-260px' }, 1200 ,'swing');
		} else {
			$(".nav").animate( { top:'-'+w+'px' }, 1200 ,'swing');	
		}
	});
	
		$(".fix_close").click(function(){
			  $(".content").animate({width: 'toggle'},1200);
	});
	
});

//產品應用文字區塊背景透明度
//$(function(){
//$(".shop").css("opacity",.80);
//});

$(function(){
	// 幫 #menu li 加上 hover 事件
	$('.nav li.navApplication').hover(function(){
		// 先找到 li 中的子選單
		var _this = $(this),
			_subnav = _this.children('ul li');
 
		// 變更目前母選項的背景顏色
		// 同時顯示子選單(如果有的話)
		_subnav.css('display', 'block');
	} , function(){
		// 變更目前母選項的背景顏色
		// 同時隱藏子選單(如果有的話)
		// 也可以把整句拆成上面的寫法
		_this.children('ul li').css('display', 'none');
	});
 
	// 取消超連結的虛線框
	$('a').focus(function(){
		this.blur();
	});
});
