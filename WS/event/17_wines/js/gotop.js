
//點右邊top

$(function(){
　$(window).load(function(){
　　$(window).bind('scroll resize', function(){
　　var $this = $(this);
　　var $this_Top=$this.scrollTop();

　　//當高度小於100時，關閉區塊 
　　if($this_Top < 500){
	$('p.go_top').stop(true, true).animate({bottom:"-130px"})
	// $('.top-bar').stop(true, true).fadeOut(0);
　　　}
　　　　if($this_Top > 500){
　　　　$('p.go_top').stop(true, true).animate({bottom:"60px"})
　　　 }$('p.go_top').click(function(){ $('html,body').stop(true,false).animate({scrollTop:0}, 800); }); 
　　}).scroll();

　});
});


 $(function(){ 
    $('a.gogogog0').click(function(){ $('html,body').animate({scrollTop:$('#section0').offset().top}, 800); });  
    return false;    
 });
