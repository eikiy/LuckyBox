$(function () {
  'use strict'

  $('[data-toggle="offcanvas"]').on('click', function () {
    $('.navbar-toggler').toggleClass('open')
    $('.offcanvas-collapse').toggleClass('open')
    $('header').toggleClass('open')
  })
})
