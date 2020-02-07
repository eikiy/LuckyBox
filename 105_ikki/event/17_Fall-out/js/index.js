'use strict'

$(function () {
  if (!('ontouchstart' in document.documentElement)) {
    document.documentElement.className += 'no-touch'
  }
  $('.contents > div').on('touchstart touchend', function (e) {
    $(this).toggleClass('over')
  })

  /**
   * Banner
   */
  var banner1 = $('#banner-1')
  var banner2 = $('#banner-2')
  var showBanner1 = true
  var bannerChangeInterval = 5000
  var bannerFadeTime = 800
  setInterval(function () {
    if (showBanner1) {
      banner1.fadeOut(bannerFadeTime)
      banner2.fadeIn(bannerFadeTime)
      showBanner1 = false
    } else {
      banner1.fadeIn(bannerFadeTime)
      banner2.fadeOut(bannerFadeTime)
      showBanner1 = true
    }
  }, bannerChangeInterval)
  /**
   * anchor
   */
  $('#nav li a').click(function (event) {
    event.stopPropagation()
    event.preventDefault()
    // console.log(event)
    $('html, body').stop().animate({
      scrollTop: $($.attr(this, 'href')).offset().top - 60
    }, 500)
  })
})
