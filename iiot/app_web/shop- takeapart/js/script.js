console.clear();
var btn = $('.swiper-slide p');
var title = $('.top_title_box');
var heightBox = [];
var cur = 0;

//點選
btn.click(function(){
  var index = btn.index(this);  
  var conbox = title[index]; 
  $('html,body').stop().animate({scrollTop:$(conbox).offset().top});
  $(this).addClass('btn_in').siblings().removeClass('btn_in');  
})

//滑動亮起
$.each(title, function(i, e){  
  heightBox.push(e.offsetTop)  
})

function slideLight(){
  if(window.scrollY > heightBox[cur+1]){
    console.log(scrollY,333)
    cur++;
    $(btn).removeClass('btn_in');
    $(btn[cur]).addClass('btn_in');
  }else if(window.scrollY < heightBox[cur]){
    cur--;
    $(btn).removeClass('btn_in');
    $(btn[cur]).addClass('btn_in');
  }
}
slideLight();
window.addEventListener('scroll', ev => {  
  slideLight();
})

