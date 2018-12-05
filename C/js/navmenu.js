// JavaScript Document

  $(document).ready(function(){ //網頁讀取完畢後
    //把所有dd標籤的內容都hide起來
    $("dd").hide();
 
    //按下dt元素連結
    $("dt a").click(function() {
      $("dd").slideUp("fast"); //子分頁
 
      //下一個主選單以下的內容要slide down
      $(this).parent().next().slideDown("fast");
       return false;
    });
  });