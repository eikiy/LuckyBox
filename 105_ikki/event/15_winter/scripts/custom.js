
     
$(window).load(function() {

 /*  Page scroll
 ==========================================*/
 $('ul.menu li a, div#hidden_items ul li a, a.scroll_down, a.scroll_top').click(function(){
		   var id = $(this).attr("href");
		   $('html,body').stop().animate({scrollTop: $("div"+id).offset().top},'slow', function(){
					 if ( navigator.userAgent.indexOf('iPad') != -1 ) {
							   var yPos = window.pageYOffset;
							   var $fixedElement = $('div#secondary_nav');
							   $fixedElement.css({ "position": "relative" });
							   window.scroll(0,yPos);
							   $fixedElement.css({ "position": "fixed" });
					 }
		   });

 return false;
 });
 
 $('select#mobile_menu, div#hidden_items select#hidden_mobile_menu').change(function(){
		   var id = $(this).attr("value");
		   $('html,body').animate({scrollTop: $("div"+id).offset().top},'slow');

 return false;
 });

/* Show/hide the secondary menu
==========================================*/
$(window).scroll(function(){
		 var pagetop = $(this).scrollTop();
		 if (pagetop >= 450) {
				   $('div#hidden_menu').slideDown();
		 }
		 if (pagetop <= 450) {
				   $('div#hidden_menu').css("display","none");
		 }
});
 
});
