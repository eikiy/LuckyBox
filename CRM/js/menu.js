
// header profile
$(function(){
    $(".header-container .user-info .profile").click(function(){
        $(this).next(".menu").fadeToggle(0);
    return false;
    });
    $(".main-container .filter-box a").click(function(){
        $(this).next(".filter-list").fadeToggle(0);
    return false;
    });
});

// Popup
$(function(){
  $('.popup-link').magnificPopup({
    removalDelay: 300,
    mainClass: 'mfp-fade'
  });
})
