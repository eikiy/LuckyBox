
 $(function(){

  $(".main_contents .sideMenu ul li.btn_more").click(function(){
        $(this).find("ul.subMenu").slideToggle({duration: 'slow', queue: false});
    return false;
    });
  $("ul.userBox li.noticeBox").click(function(){
        $(this).find(".notificationBox").stop(true, true).fadeToggle(0);
    return false;
    });
  $("ul.userBox li.profile_photo").click(function(){
        $(this).find(".theUserBox").stop(true, true).fadeToggle(0);
    return false;
    });
 });


 $(function(){
  var body = $("body");
  var width = body.width()

  if(width < 1000)
  {
      $(".sideMenu").mouseleave(function(){
        $(this).find("ul.mainMenu li ul.subMenu").stop(true, true).hide();
    return false;
    });
  }
  return false;
 });