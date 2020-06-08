
//點右邊top
$(function(){
　$(window).load(function(){
　　$(window).bind('scroll resize', function(){
　　var $this = $(this);
　　var $this_Top=$this.scrollTop();

　　//當高度小於100時，關閉區塊
　　if($this_Top < 500){
	$('p.go_top').stop(true, true).animate({bottom:"-130px"})
　　　}
　　　　if($this_Top > 500){
　　　　$('p.go_top').stop(true, true).animate({bottom:"60px"})
　　　 }$('p.go_top').click(function(){ $('html,body').stop(true,false).animate({scrollTop:0}, 800); });
　　}).scroll();

　});
});


 $(function(){
	$('p.btn a.gogogog1').click(function(){ $('html,body').animate({scrollTop:$('#section1').offset().top}, 800); });
	$('p.btn a.gogogog2').click(function(){ $('html,body').animate({scrollTop:$('#section2').offset().top}, 800); });
	return false;
 });


  // $(document).ready(function(){
  //   $('#banner').bgStretcher({
  //     images: ['images/top_bg_01.jpg', 'images/top_bg_02.jpg'],
  //     imageWidth: 2200,
  //     imageHeight: 1280,
  //     slideDirection: 'N',
  //     slideShowSpeed: 1000,
  //     transitionEffect: 'fade',
  //     sequenceMode: 'normal',
  //   });

  // });

 $(function(){
 	var body = $("body");
	var width = body.width() // Get position of the body

	if(width < 650)
	{
        $('#banner').bgStretcher({
      images: ['images/top_bg_01s.jpg', 'images/top_bg_02s.jpg'],
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
      images: ['images/top_bg_01.jpg', 'images/top_bg_02.jpg'],
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