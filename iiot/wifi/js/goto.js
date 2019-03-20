

$(function(){
	wow = new WOW(
	    {
	        animateClass: 'animated',
	        offset:       100,
	        callback:     function(box) {
	          console.log("WOW: animating <" + box.tagName.toLowerCase() + ">")
	        }
	      }
	    );
	    wow.init();
	    document.getElementById('moar').onclick = function() {
	      var section = document.createElement('section');
	      section.className = 'section--purple wow fadeInDown';
	      this.parentNode.insertBefore(section, this);
	};
});

// side menu
function openNav() {
	document.getElementById("theSidenav").style.width = "350px";
	document.getElementById("Main_Contents").classList.add("for_blur");
}
function closeNav() {
	document.getElementById("theSidenav").style.width = "0";
	document.getElementById("Main_Contents").classList.remove("for_blur");
}
// faq
$(function(){
	$(".faq_box ul.faq_list li").click(function(){
	  $(this).find('.faq_info').find('.answer').slideToggle();
	});
	return false;
});



