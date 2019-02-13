$(function(){
   	$('.go_00').click(function(){ $('html,body').animate({scrollTop:0},900);});
	$('.go_01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top}, 800); });
	$('.go_02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top}, 800); });
	$('.go_03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top}, 800); });
	$('.go_04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top}, 800); });
	$('.go_05').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_05').offset().top}, 800); });
	$('.go_06').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_06').offset().top}, 800); });
	return false;
});

$(function(){
	$('.s_go_01').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_01').offset().top - 80}, 800); });
	$('.s_go_02').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_02').offset().top - 80}, 800); });
	$('.s_go_03').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_03').offset().top - 80}, 800); });
	$('.s_go_04').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_04').offset().top - 80}, 800); });
	$('.s_go_05').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_05').offset().top - 80}, 800); });
	$('.s_go_06').click(function(){ $('html,body').animate({scrollTop:$('#move_goto_06').offset().top - 80}, 800); });
	return false;
});


// header menu
$(function(){
	$( "ul.top_menu li" ).hover(
	 function() {
	 	$(this).find('ul.sub_menu').show();
	  }, function() {
	  	$(this).find('ul.sub_menu').hide();
	  }
	);
	return false;
});


// side menu
function openNav() {
	document.getElementById("theSidenav").style.width = "350px";
}
function closeNav() {
	document.getElementById("theSidenav").style.width = "0";
}

$(function(){
	$(".sidenav ul.side_menu li h3").click(function(){
	  $(this).parent().find('ul.sub_menu').slideToggle();
	});
	return false;
});

// $(function(){
// 	$( ".sidenav ul.side_menu li h3" ).click(
// 	 function() {
// 	 	$(this).parent().find('ul.sub_menu').fadeIn();
// 	  }, function() {
// 	  	$(this).parent().find('ul.sub_menu').fadeOut();
// 	  }
// 	);
// 	return false;
// });



