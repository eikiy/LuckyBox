WDJQ(document).ready(function(){
	//網站鎖右鍵
	/*WDJQ(document).bind("contextmenu",function(event){
		alert('請尊重智慧財產權。');
		return false;
	});*/
	
	
});




function fblogin() {
	create_fb_form();
	if (typeof(FB)=="undefined") return alert('請先引入FB javascript SDK 代碼!! 如:\n	<script>\nwindow.fbAsyncInit = function() {\nFB.init({\nappId      : \'1242572385842024\',\nxfbml      : true,\nversion    : \'v2.8\'\n});\n    FB.AppEvents.logPageView();\n  };\n\n  (function(d, s, id){\n     var js, fjs = d.getElementsByTagName(s)[0];\n     if (d.getElementById(id)) {return;}\n     js = d.createElement(s); js.id = id;\n     js.src = "//connect.facebook.net/en_US/sdk.js";\n     fjs.parentNode.insertBefore(js, fjs);\n   }(document, \'script\', \'facebook-jssdk\'));\n</script>');
	if(FB.getUserID()=="")
	{
		FB.login(function (rs)
		{
			_tt = rs;
			FB.api('/me?fields=id,name,email', function(rs)
			{
				_re = rs;
				if(rs["error"]!=null)
				{
					//alert("FB登入失敗");
					//return window.history.back(-1);
				}else{
					///登入完成執行區域
					member_dataset(rs);
				}
			});
			
		},{scope:'email'});
	}
	else
	{
		FB.api('/me?fields=id,name,email', function(rs)
		{
			_re = rs;
			if(rs["error"]!=null)
			{
				//alert("FB登入失敗");
				//return window.history.back(-1);
			}else{
				///登入完成執行區域
				member_dataset(rs);
			}
		});
	}			
}
function create_fb_form(){
	WDJQ('#fbform').remove();
	WDJQ('body').append('<form id="fbform" action="member.php?act=net_login" method="post"><input type="hidden" name="account"><input type="hidden" name="name"><input type="hidden" name="email"><input type="hidden" name="netclass" value="fb">    <input type="hidden" name="act" value="net_login"></form>');
}
function member_dataset(data){
	WDJQ('#fbform [name="account"]').val(data["id"]);
	WDJQ('#fbform [name="name"]').val(data["name"]);
	WDJQ('#fbform [name="email"]').val(data["email"]);
	WDJQ('#fbform').submit();
}



//search_value GET 值
function Get(sv)
{
	var value = "";
	var get = window.location.href.toString().split(window.location.host)[1];
	get = get.split("?")[1];
	if(get==null) return value;
	
	get = get.split("&");
	
	for(idx in get)
	{
		if(sv==get[idx].split("=")[0]) value = get[idx].split("=")[1];
	}
	return value;
}





//驗證帳號
function isAccount(account)
{
	//英數大小寫 不可有特殊符號
	if(account=="") return false;
	reAccount = /[^a-zA-Z0-9]+/
	return reAccount.test(account);
}




//日期(西元) 下拉選單select
function Select_Date(y_id,m_id,d_id,y_start,y_end)
{
	var now = new Date();
	
	//年(year_start~今年)
	for(var i = now.getFullYear() + y_end*1; i >= y_start*1; i--){
	WDJQ('#'+y_id).
	append(WDJQ("<option></option>").
	attr("value",i).
	text(i));
	}
	
	//月
	for(var i = 1; i <= 12; i++){
	WDJQ('#'+m_id).
	append(WDJQ("<option></option>").
	attr("value",paddingLeft(i,2)).
	text(paddingLeft(i,2)));
	
	WDJQ('#'+y_id).change( function () {onChang_date(y_id,m_id,d_id) });
	WDJQ('#'+m_id).change( function () {onChang_date(y_id,m_id,d_id) });
	
}


//年、月選單改變時
function onChang_date(y_id,m_id,d_id)
{
	if(WDJQ('#'+y_id).val() != -1 && WDJQ('#'+m_id).val() != -1){
	
	var date_temp = new Date(WDJQ('#'+y_id).val(), WDJQ('#'+m_id).val()*1, 0);
	
	
	//移除超過此月份的天數
	WDJQ("#"+d_id+" option").each(function(){
	if(WDJQ(this).val()*1 != -1 && WDJQ(this).val()*1 > date_temp.getDate()) WDJQ(this).remove();
	});                
	
	//加入此月份的天數
	for(var i = 1; i <= date_temp.getDate(); i++){
	if(!WDJQ("#"+d_id+" option[value='" + paddingLeft(i,2) + "']").length){
	WDJQ('#'+d_id).
	append(WDJQ("<option></option>").
	attr("value",paddingLeft(i,2)).
	text(paddingLeft(i,2)));
	}
	}
	} else {
	WDJQ("#"+d_id+" option:selected").removeAttr("selected");
	}      
	}
}



//檢查欄位是否有重覆值 帳號 email
function Check_Repeat(table,row,value)
{	
	var _return; 
	WDJQ.ajax( {
		//傳遞目標頁面檔案
		url: "ajx.php?call=check_repeat&table="+table+"&row="+row+"&value="+value,
		type: 'GET',
		async:false,
		success: function(response) {
			//回傳物件名稱
			_return = response;//'repeat'為有重覆資料 'norepeat'為沒有
		}
	} );
	
	return _return;
}

//Pic_resize
function Pic_Size(width,height,width_set,height_set)
{	
	var re_set,re,value;
	
	//高比寬大的圖片
	if(height>width)
	{
		re = height_set / height;
		var return_h = height_set;
		var return_w = width * re;
	}
	else if(height<width)//寬比高大的圖片
	{
		re = width_set / width;
		var return_w = width_set;
		var return_h = height * re;
	}
	else if(height==width)//高寬相等的圖片
	{
		//設訂高寬的寬比高大
		if(width_set>height_set)
			re_set = width_set;
		else if(width_set<height_set)//設訂高寬的高比寬大
			re_set = height_set;
		else if(width_set==height_set)//設定高寬相等
			re_set = "square";
		
		if(re_set!="square")
		{
			var re = re_set / height;
			var return_h = re_set;
			var return_w = width * re;
		}
		else
		{
			var return_h = height_set;
			var return_w = width_set;
		}
	}
	
	//捨去小數點以後
	return_w = Math.round(return_w);
	return_h = Math.round(return_h);
	
	var value = new Array(2);
	
	value[0] = return_w;
	value[1] = return_h;
	
	return value;
}




//datepicker
function Datepick(obj,mode,_min) {

	if(mode=='range')
	{
		WDJQ(obj).datepick({ 
			rangeSelect: true,
			dateFormat: 'yyyy,mm,dd',
			showTrigger: "<img src='includes/js/datepick/calendar-blue.gif' >",
			minDate:_min
		}); 	
	}
	else
	{
		WDJQ( obj ).datepicker({
		  showOn: "button",
		  dateFormat: 'yyyy-mm-dd',
		  buttonImage: "includes/js/datepick/calendar-blue.gif",
		  buttonImageOnly: true,
		  buttonText: "Select date"
		});
	
	}
};







//數字左側補0
function paddingLeft(str,lenght){
	str = str + "";//轉成字串
	if(str.length >= lenght)
	return str;
	else
	return paddingLeft("0" +str,lenght);
}
//數字右側補0
function paddingRight(str,lenght){
	str = str + "";//轉成字串
	if(str.length >= lenght)
	return str;
	else
	return paddingRight(str+"0",lenght);
}




//更換驗證碼圖片
VerifyCode = function()
{
	WDJQ('img[src*="verifycode"]').each(function (idx,obj){
		
		WDJQ(obj).removeAttr('onclick');
		WDJQ(obj).click(function (){
				var d = new Date();
				if (WDJQ(this)[0].src.search('=')>=0)
					WDJQ(this)[0].src = WDJQ(this).attr("src").split('&t')[0]+'&t'+d.getTime();
				else
					WDJQ(this)[0].src = WDJQ(this).attr("src").split('?')[0]+'?'+d.getTime();
		});
	
	});
}




//驗證mail
function isEmail(email){
	if (email=="") return false;
	reEmail=/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/
	return reEmail.test(email);
}

//身份證驗證
function CheckID( id ) {
  tab = "ABCDEFGHJKLMNPQRSTUVXYWZIO"                     
  A1 = new Array (1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,3,3,3,3,3,3 );
  A2 = new Array (0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5 );
  Mx = new Array (9,8,7,6,5,4,3,2,1,1);

  if ( id.length != 10 ) return false;
  i = tab.indexOf( id.charAt(0) );
  if ( i == -1 ) return false;
  sum = A1[i] + A2[i]*9;

  for ( i=1; i<10; i++ ) {
    v = parseInt( id.charAt(i) );
    if ( isNaN(v) ) return false;
    sum = sum + v * Mx[i];
  }
  if ( sum % 10 != 0 ) return false;
  return true;
}


///判斷是否手機使用網頁
function checkmobile(){
	var mobiles = new Array
	(
	"midp", "j2me", "avant", "docomo", "novarra", "palmos", "palmsource",
	"240x320", "opwv", "chtml", "pda", "windows ce", "mmp/",
	"blackberry", "mib/", "symbian", "wireless", "nokia", "hand", "mobi",
	"phone", "cdm", "up.b", "audio", "sie-", "sec-", "samsung", "htc",
	"mot-", "mitsu", "sagem", "sony", "alcatel", "lg", "eric", "vx",
	"NEC", "philips", "mmm", "xx", "panasonic", "sharp", "wap", "sch",
	"rover", "pocket", "benq", "java", "pt", "pg", "vox", "amoi",
	"bird", "compal", "kg", "voda", "sany", "kdd", "dbt", "sendo",
	"sgh", "gradi", "jb", "dddi", "moto", "iphone", "android",
	"iPod", "incognito", "webmate", "dream", "cupcake", "webos",
	"s8000", "bada", "googlebot-mobile"
	)
	
	var ua = navigator.userAgent.toLowerCase();
	for (var i = 0; i < mobiles.length; i++) {
	if (ua.indexOf(mobiles[i]) > 0) return true;
	}
	
	return false
}


//---擷取物件點擊後的物件上的座標  火狐擷取不到offset 固
function getOffset(evt)
{
  var target = evt.target;
  if (target.offsetLeft == undefined)
  {
    target = target.parentNode;
  }
  var pageCoord = getPageCoord(target);
  var eventCoord =
  { 
    x: window.pageXOffset + evt.clientX,
    y: window.pageYOffset + evt.clientY
  };
  var offset =
  {
    offsetX: eventCoord.x - pageCoord.x,
    offsetY: eventCoord.y - pageCoord.y
  };
  return offset;
}
function getPageCoord(element)
{
  var coord = {x: 0, y: 0};
  while (element)
  {
    coord.x += element.offsetLeft;
    coord.y += element.offsetTop;
    element = element.offsetParent;
  }
  return coord;
}
//------------------------------------------------






//-- ex: same to php now_url function 
//-- 網址轉換
function now_url(str) {
    var temp_str = window.location.href.toString().split(window.location.host)[1]; //--取得域名後資料
    var bk_url = temp_str.split('?')[0];
    var list_data = temp_str.split('?')[1];

    var data_str = new Object(); //--字串符資料
    if (typeof (str) != "object") {
        str = str.split(',');
        if (str.length > 0) {
            for (aa in str) {
                var t_str = str[aa].split(':');
                if (t_str.length > 1) {
                    data_str[t_str[0]] = t_str[1];
                } else {
                    data_str[t_str[0]] = '';
                }
            }
        }
    } else {
        data_str = str;
    }

    //--現有GET參數資料
    var have_data = new Object(); //--含有的字串符資料
    if (list_data != null) {
        var secs = list_data.split('&'); //--取得每一組參數
        for (aa in secs) {
            var t_str = secs[aa].split('=');
            if (t_str.length > 1) {
                have_data[t_str[0]] = t_str[1];
            } else {
                have_data[t_str[0]] = '';
            }
        }
    }

    var out_data = new Object();//-輸出的參數資料
    //--尋找判斷取代
    for (aa in have_data) {
        if (typeof (data_str[aa]) != "undefined") {
            if (data_str[aa] != null && data_str[aa] != '') { ///---不等於空值(取代函數)
                out_data[aa] = data_str[aa];
            }
        } else {
            out_data[aa] = have_data[aa];
        }
    }

    //--判斷字串符資料是否有於內值
    for (aa in data_str) {
        if (typeof (out_data[aa]) == "undefined") {
            if (data_str[aa] != null && data_str[aa] != '') { ///---不等於空值(取代函數)
                out_data[aa] = data_str[aa];
            }
        }
    }


    //--重組資料
    var temp_out_str = '';
    for (aa in out_data) {
        if (temp_out_str != '') temp_out_str += '&';
        temp_out_str += aa + '=' + out_data[aa];
    }
    temp_out_str = bk_url + '?' + temp_out_str;
    return temp_out_str;
}




/*
	DataUri 縮圖處理
	resizeImage(路由, 目標寬, 目標高, 返回函數(data) )
	
	注意此function 處理時非即時回應 結果
*/
function resizeImage(url, width, height, callback) {
    var sourceImage = new Image();

    sourceImage.onload = function(event) {

        var canvas = document.createElement("canvas");

        canvas.width = width;
        canvas.height = height;
	
	if (event.target.width>event.target.height){
		var pr = width/event.target.width;
		canvas.getContext("2d").drawImage(sourceImage, 0, 0, width, Math.ceil(event.target.height*pr));
	}else{
		var pr = height/event.target.height;
		canvas.getContext("2d").drawImage(sourceImage, 0, 0, Math.ceil(event.target.width*pr), height);
	}
	
        //canvas.getContext("2d").drawImage(sourceImage, 0, 0, width, height);

	//--導回
        callback(canvas.toDataURL());
    }

    sourceImage.src = url;
}