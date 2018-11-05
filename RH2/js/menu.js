
 $(function(){
  $("ul.top_menu li").hover(
    function(){
      $(this).find(".subMumeBox").stop(true, true).fadeIn(0); 
      $(this).find("h3").addClass("btn_in");
    },
    function(){
      $(this).find(".subMumeBox").stop(true, true).fadeOut(0);  
      $(this).find("h3").removeClass("btn_in");
    });
  return false;
}); 

$(function(){
    $(".mob_search").click(function(){
        $("#mob_search_show").stop(true, true).fadeToggle(0);
    });
    return false;
});



 $(function(){
  $("ul.list_instructions li").hover(
    function(){
      $(this).find(".showBox").stop(true, true).fadeIn(0); 
      $(this).find(".top_title").addClass("the_color_blue");
    },
    function(){
      $(this).find(".showBox").stop(true, true).fadeOut(0);  
      $(this).find(".top_title").removeClass("the_color_blue");
    });
  return false;
}); 
