$(document).ready(function(e) {
			//$('img[usemap]').rwdImageMaps();
});

$(function() {
  var iframeOffset = $("#edmFrame", window.parent.document).offset();
  $("a").each(function () {
      
      var link = $(this);
      var href = link.attr("href");
      if (href && href[0] == "#") {
          var name = href.substring(1);
          $(this).click(function () {
              var nameElement = $("[name='" + name + "']");
              var idElement = $("#" + name);
              var element = null;
              if (nameElement.length > 0) {
                  element = nameElement;
              } else if (idElement.length > 0) {
                  element = idElement;
              }
 
              if (element) {
                  var offset = element.offset();
                  //window.parent.scrollTo(offset.left, offset.top + iframeOffset.top);
                  window.parent.scrollTo(offset.left, offset.top);
              }
 
              return false;
          });
      }
  });
});

