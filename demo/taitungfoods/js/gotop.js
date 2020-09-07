
/* goTop*/ 
function goTop(val) {
jQuery('html,body').animate({scrollTop:jQuery(val).offset().top},500);
}

/* 回版頭 */
jQuery(function(){
	jQuery("#gotop").click(function(){
		jQuery("html,body").stop(true,false).animate({scrollTop:0},700); //設定回頁面頂端
		return false;	
	});
    jQuery(window).scroll(function() {
        if ( jQuery(this).scrollTop() > 300){ //設定大於300px才顯示浮層
            jQuery('#gotop').fadeIn("fast");
        } else {
            jQuery('#gotop').stop().fadeOut("fast");
        }
    });
});


/**iframe自動高度**/
/**
function SetCwinHeight()
{
var iframeid=document.getElementById("mainframe"); //iframe id
  if (document.getElementById)
  {   
   if (iframeid && !window.opera)
   {   
    if (iframeid.contentDocument && iframeid.contentDocument.body.offsetHeight)
     {   
       iframeid.height = iframeid.contentDocument.body.offsetHeight;   
     }else if(iframeid.Document && iframeid.Document.body.scrollHeight)
     {   
       iframeid.height = iframeid.Document.body.scrollHeight;   
      }   
    }
   }
}
**/
/** mouseover **/
function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}
function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}
function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}
function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}
