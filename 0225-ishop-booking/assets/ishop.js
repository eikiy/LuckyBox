
var mainForm, mainComponents;
window.onload = function () {
  var url_string = window.location.href; //window.location.href
  var url = new URL(url_string);
  // 先查看直接寫在element的id

  // 如果找到landing page要處理的
  var landingType = 'L';
  var ishopId, pageId, categoryId, bookingId;
  if (document.getElementsByClassName('iiot-landing-form')[0]) {
    var ishopId = document.getElementsByClassName('iiot-landing-form')[0].id;
    landingType = 'L';
  }
  else if (document.getElementsByClassName('iiot-page-form')[0]) {
    landingType = 'P';
  } else {
    windows.alert('Cannot find the iiot-landing-form element');
  } 
  
  if (ishopId && landingType === 'L') {
    ishopId = ishopId.split('ishop-lid-')[1];
  }
    
  // var ishopId = document.querySelector('.iiot-main-form').id;
  
  // 如果querystring有，以querystring為主
  if (landingType === 'L') {
    ishopId = url.searchParams.get("ishop_lid") || ishopId;
  } else {
    ishopId = url.searchParams.get("ishop_lid") || ishopId;
    pageId = url.searchParams.get("ishop_pid");
    categoryId = url.searchParams.get("ishop_cid");
    bookingId = url.searchParams.get("ishop_bid");
  }
  
  // Formio.setBaseUrl(window.location.origin); // 如果頁面host在第三方，這邊要寫死。否則用window location即可
  Formio.setBaseUrl('https://wifiotg-kay.iiot.io'); // 如果頁面host在第三方，這邊要寫死。否則用window location即可
  // Formio.createForm(document.getElementById('formio'), 'https://wifiotg-kay.iiot.io/modules/booking-form')
  var landingApi = '/apis/booking-landing/';
  if (landingType === 'P') {
    landingApi = '/apis/booking-page/';
  }

  if (!ishopId)
    window.alert('Missing required parameters');

  if (ishopId && landingType === 'L') {
    landingApi += '?ishop_lid=' + ishopId;
  } else {
    landingApi += '?ishop_lid=' + ishopId + '&ishop_pid=' + pageId + '&ishop_cid=' + categoryId + '&ishop_bid=' + bookingId;
  }
  
  Formio.createForm(document.getElementById('bookingform'),
    landingApi
    // '/apis/booking-landing/' + ishopId + '?token=example'
    , {
      readOnly: false,
      viewAsHtml: false // 這個可以拿來做訂單確認

    }
  )
    .then(function (form) {
      mainForm = form;

    });
};