
 $(function(){
	$("#p01").click(function goTop(){
		$("html,body").stop(true,false).animate({scrollTop:850},900);
	});	
	return false;	 
 });

//點右邊top
 $(function(){
	
	$(window).scroll(function(){
		var HEIGHT = $(window).scrollTop() + $(window).innerHeight()-150;
		if( $(window).scrollTop() > 400 ){
			$("p.go_top").stop(true,false).animate({top:HEIGHT},500);
		}else{
			$("p.go_top").stop(true,false).animate({top:-350},900);	}
	});
	
	$("#TOP").click(function goTop(){
		$("html,body").stop(true,false).animate({scrollTop:0},900);
	});
	return false;	 
 });



 $(function(){
	$(window).scroll(function(){
		if( $(window).scrollTop() > $(window).innerHeight()){
			$(".goTop").fadeIn("");
		}else{$(".goTop").fadeOut("");}
	});
	$('.top_go').click(function(){ $('html,body').stop(true,false).animate({scrollTop:0}, 800); }); 
	$('p.btn a.gogogog1').click(function(){ $('html,body').animate({scrollTop:$('#section1').offset().top}, 800); });
	$('p.btn a.gogogog2').click(function(){ $('html,body').animate({scrollTop:$('#section2').offset().top}, 800); }); 
	//$('.btm02').click(function(){ $('html,body').animate({scrollTop:$('#section2').offset().top}, 800); }); 
	return false;	 
 });


 $(function(){
 	var body = $("body");
	var width = body.width() // Get position of the body

	if(width < 650)
	{
        $('#banner').bgStretcher({
      images: ['images/top_bg_00s.jpg', 'images/top_bg_02s.jpg', 'images/top_bg_03s.jpg'],
      imageWidth: 750,
      imageHeight: 1000,
      slideDirection: 'N',
      slideShowSpeed: 1000,
      transitionEffect: 'fade',
      sequenceMode: 'normal',
    });
	}
	if(width > 650)
	{
        $('#banner').bgStretcher({
      images: ['images/top_bg_00.jpg', 'images/top_bg_02.jpg', 'images/top_bg_03.jpg'],
      imageWidth: 2200,
      imageHeight: 1280,
      slideDirection: 'N',
      slideShowSpeed: 1000,
      transitionEffect: 'fade',
      sequenceMode: 'normal',
    });
	}
	return false;
 });