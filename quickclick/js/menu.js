
// header profile
$(function(){
    $(".middle-content .more-features").click(function(){
        $(this).next(".features-menu").fadeToggle(0);
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
