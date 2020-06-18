function about() {
	
	
	$('.btn_01').delay(200).animate({top:50, opacity:1}, 200);
	$('.btn_02').delay(400).animate({top:50, opacity:1}, 200);
	$('.btn_03').delay(600).animate({top:30, opacity:1}, 200);
	$('.btn_04').delay(800).animate({top:50, opacity:1}, 200);
	$('.btn_05').delay(1000).animate({top:50, opacity:1}, 200);
	$('.btn_06').delay(1000).animate({top:30, opacity:1}, 200);
	
	$('.btn_01_en').delay(200).animate({top:50, opacity:1}, 200);
	$('.btn_02_en').delay(400).animate({top:50, opacity:1}, 200);
	$('.btn_03_en').delay(600).animate({top:50, opacity:1}, 200);
	
	$('.bg_i01').delay(0).animate({top:0, opacity:1}, 600);
	$('.bg_i02').delay(200).animate({top:0, opacity:1}, 600);
	$('.bg_i03').delay(400).animate({top:0, opacity:1}, 600);
	$('.bg_i04').delay(800).animate({top:0, opacity:1}, 600);
	$('.logo_i').delay(1000).animate({top:70, opacity:1}, 200);
	$('.bg_i05').delay(1200).animate({top:0, opacity:1}, 600);
	
	$('.logo_i1001').delay(1000).animate({top:70, opacity:1}, 200);
	$('.hot_event1001').delay(1800).animate({top:1, opacity:1}, 200);
	$('.event_w1001').delay(1800).animate({top:95, opacity:1}, 200);

	$('.btn_more').delay(1800).animate({top:147, opacity:1}, 800);
	
	$('.bg-menu').delay(1000).animate({top:500, opacity:1}, 800);
	

	$('.f_01').delay(1200).animate({top:500, opacity:1}, 200);
	$('.f_02').delay(1400).animate({top:500, opacity:1}, 200);
	$('.f_03').delay(1600).animate({top:500, opacity:1}, 200);
	$('.f_04').delay(1800).animate({top:500, opacity:1}, 200);
	$('.f_05').delay(2000).animate({top:500, opacity:1}, 200);
	$('.f_06').delay(2000).animate({top:500, opacity:1}, 200);
	
	$('.index_main').delay(1500).animate({top:278, opacity:1}, 800);	
	$('.w_all').delay(2000).animate({top:240, opacity:1}, 800);
	
	$('.footer_i').delay(1900).animate({top:595, opacity:1}, 200);

};

$(document).ready(function(e) {
    about();
});


function whichBrs() {
var agt=navigator.userAgent.toLowerCase();
if (agt.indexOf("opera") != -1) return 'Opera';
if (agt.indexOf("staroffice") != -1) return 'Star Office';
if (agt.indexOf("webtv") != -1) return 'WebTV';
if (agt.indexOf("beonex") != -1) return 'Beonex';
if (agt.indexOf("chimera") != -1) return 'Chimera';
if (agt.indexOf("netpositive") != -1) return 'NetPositive';
if (agt.indexOf("phoenix") != -1) return 'Phoenix';
if (agt.indexOf("firefox") != -1) return 'Firefox';
if (agt.indexOf("chrome") != -1) return 'chrome';
if (agt.indexOf("safari") != -1) return 'Safari';
if (agt.indexOf("skipstone") != -1) return 'SkipStone';
if (agt.indexOf("msie") != -1) return 'Internet Explorer';
if (agt.indexOf("netscape") != -1) return 'Netscape';
if (agt.indexOf("mozilla/5.0") != -1) return 'Mozilla';
if (agt.indexOf('\/') != -1) {
if (agt.substr(0,agt.indexOf('\/')) != 'mozilla') {
return navigator.userAgent.substr(0,agt.indexOf('\/'));}
else return 'Netscape';} else if (agt.indexOf(' ') != -1)
return navigator.userAgent.substr(0,agt.indexOf(' '));
else return navigator.userAgent;
}
