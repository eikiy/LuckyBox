// document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');
document.write('<script type=\"text/javascript\" src=\"WPJS/sha1.js\"></script>');
document.write('<script type=\"text/javascript\" src=\"WPJS/moment.js\"></script>');

var loginURL='member.html'; //登入頁網址（登出後會導到這頁)


//檢查Email格式是否正確
function isValidEmailAddress(emailAddress) {
    var pattern = /^([a-z\d!#$%&'*+\-\/=?^_`{|}~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+(\.[a-z\d!#$%&'*+\-\/=?^_`{|}~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+)*|"((([ \t]*\r\n)?[ \t]+)?([\x01-\x08\x0b\x0c\x0e-\x1f\x7f\x21\x23-\x5b\x5d-\x7e\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|\\[\x01-\x09\x0b\x0c\x0d-\x7f\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))*(([ \t]*\r\n)?[ \t]+)?")@(([a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|[a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF][a-z\d\-._~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]*[a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])\.)+([a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|[a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF][a-z\d\-._~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]*[a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])\.?$/i;    
    return pattern.test(emailAddress);
};

//檢查手機號碼（0912345678)
function isValidMobile(mobileno)
{		
	var pattern=/^((?=(09))[0-9]{10})$/g;	
	return pattern.test(mobileno);
};

//檢查密碼,4~8字元
function isValidPWD(pwd)
{
	var pattern=pwd.trim()
	if(pattern.length<4)
	{
		return false;
	}
	if(pattern.length>8)
	{
		return false;
	}
	return true;

};

function getCookie(cname)
{
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}


//登入
function api_login(mobileNo, password, auto_play) {

     $.getJSON("https://jsonip.com/?callback=?", function (data) {
            IP = data.ip;
        });

    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {
        "act": "login",
        "mobileNo": mobileNo,
        "pwd": CryptoJS.SHA1(password).toString(),
        "ip": IP,
        "cookid": getCookie("cookid")
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
        console.log("auto_play->" + auto_play);
    }
    
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            if (data != null && data.code == 200) {
               
                switch (data.data.status) {
                    case 100:
                        if(data.data.message=='手機號未啟動')
                        {
                            swal({
                              title: "Info",
                              text: "此手機號尚未啟動，請先輸入驗證碼",
                              type: "info",                                            
                              confirmButtonText: "OK",
                              closeOnConfirm: false
                            },
                            function(){                                
                                 window.location.href="confirm.html?mobile="+mobileNo;
                            });    
                        } 
                        else
                        {
                            sweetAlert("Oops...", data.data.message, "error");                        
                            return;
                        }                               
                    break;
                    case 1000:
                        saveSessionStorage("user_id", data.data.result.uid);
                        saveSessionStorage("user_name", data.data.result.name);
                        saveSessionStorage("access_token", data.data.result.access_token);
                        saveSessionStorage("txtlv", data.data.result.txtlv);
                        saveSessionStorage("lv", data.data.result.lv);
                        saveSessionStorage("mobile", data.data.result.mobile);
                        saveSessionStorage("memno", data.data.result.memno);
                        saveSessionStorage("expiretime", data.data.result.expiretime);                        
                        if (auto_play != '') {
                             window.location.href=auto_play;                            
                        }
                        break;
                    default:
                        sweetAlert("Oops...", data.data.message, "error");                        
                        return;
                        break;
                }
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}


//註冊
function api_Add(cname,email,pwd,gender,birthday,merrydate,mobileno,isgetcareerad,isgetallcareerad)
{
	var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {    	
        "act": "Add",
        "cname":cname,
        "email": email,
        "pwd": pwd,
        "gender": gender,
        "birthday":birthday,
        "merryday":merrydate,
        "mobileNo":mobileno,
        "isgetcareerad":isgetcareerad,
		"isgetallcareerad":isgetallcareerad
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {
            	if(data.data.message=='')
            	{
                    saveSessionStorage("memp",data.data.result);
            		window.location.href="confirm.html";  
                 
            	}
            	else
            	{
            		sweetAlert("Oops...", data.data.message, "error");                        
                    return false;                                                
            	}                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}


function api_sendcon(acode,mobile)
{
    var at='';
     if(typeof(loadSessionStorage("m3mfrom"))!="undefined" && loadSessionStorage("m3mfrom")!='')
     {
        at='mem3rdVerify';
     }
     else
     {
        at='ActivedCodeVerifyByM';
     }
    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": at,
        "uid":loadSessionStorage("memp"),
        "mmacode": acode,
        "mobileNo":mobile,
        "M3MFrom":loadSessionStorage("m3mfrom")
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {
                if(data.data.message=='')
                {                     
                      
                    sessionStorage.clear();
                    saveSessionStorage("user_id", data.data.result.uid);
                    saveSessionStorage("user_name", data.data.result.name);
                    saveSessionStorage("access_token", data.data.result.access_token);
                    saveSessionStorage("txtlv", data.data.result.txtlv);
                    saveSessionStorage("lv", data.data.result.lv);
                    saveSessionStorage("mobile", data.data.result.mobile);
                    saveSessionStorage("memno", data.data.result.memno);
                    saveSessionStorage("expiretime", data.data.result.expiretime);
                    window.location.href="apply-success.html"; 
                     
                }
                else
                {
                    $('#acode').val('');
                    sweetAlert("Oops...", data.data.message, "error");                        
                    return false;                                                
                }                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    // return false;
}

//取資料
function api_get(uid)
{
    if(uid==null || uid=='')
    {
        window.location.href="MemLogin.html";
    }
    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": "getOne",
        "uid":uid
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
            if (data != null && data.code == 200) {

                var obj=jQuery.parseJSON(JSON.stringify(data.data.result)); 

                if(data.data.message=='')
                {
                     $('#cname').val(obj.name);
                     $('#email').val(obj.email);
                     $('#mobile').val(obj.mobile);
                     if(obj.birthday!='')
                     {
                        $('#birthday').val(obj.birthday);                                                                  
                     }
                     else
                     {
                        $('#birthday').attr('readonly',false);
                        // $('#birthday').attr('type','Date');
                     }
                     if(obj.merryday!='')
                     {
                        $('#marryday').val(obj.merryday);
                         $('#marryday').attr('readonly',true);
                     }

                     if(obj.gender=='F')
                     {
                        $('input[name="gender"]')[0].checked = true                        
                     }
                     else
                     {
                        $('input[name="gender"]')[1].checked = true                        
                     }                     
                     if(obj.isgetallcareerad=="True")
                     {
                        $('#isAllCareerAD').prop('checked',true);
                     }
                     if(obj.isgetcareerad=="True")
                     {
                        $('#isCareerAD').prop('checked',true);
                     }
                     
                   
                }
                else
                {
                    sweetAlert("Oops...", data.data.message, "error");                        
                    return false;                                                
                }                
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}

//修改
function api_edit(gender,cname,pwd,birthday,merryday,mobileno,email,isgetcareerad,isgetallcareerad)
{
    if(loadSessionStorage('user_id')==null)
    {
        window.location.href="editMember.html";
    }

    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": "Edit",
        "uid":loadSessionStorage('user_id'),
        "cname":cname,
        "gender":gender,
        "pwd":pwd,
        "birthday":birthday,
        "merryday":merryday,
        "mobileNo":mobileno,
        "email":email,
        "isgetcareerad":isgetcareerad,
        "isgetallcareerad":isgetallcareerad
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
             if (data != null && data.code == 200) {
                if(data.data.message=='')
                {
                    swal({
                      title: "Great!",
                      text: "修改完成",
                      type: "success",                                            
                      confirmButtonText: "OK",
                      closeOnConfirm: false
                    },
                    function(){
                        logout();
                        // window.location.href="memberlogin.html";
                    });                    
                }
                else
                {
                    sweetAlert("Oops...", data.data.message, "error");                        
                    return false;                                                
                }                
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}

//忘記密碼
function api_resetpwd(mobile,gkey)
{
    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": "reSetPWD",        
        "gkey":gkey,        
        "mobileNo":mobile
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
             if (data != null && data.code == 200) {
                if(data.data.message=='')
                {

                 swal({
                          title: "Great",
                          text: "密碼已發出",
                          type: "success",                                            
                          confirmButtonText: "OK",
                          closeOnConfirm: false
                        },
                        function(){                                
                             window.location.href="memLogin.html";
                        });    
                                
                }
                else
                {
                    grecaptcha.reset();
                    sweetAlert("Oops...", data.data.message, "error");                        
                    return false;                                                
                }                
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });    
}

//補發認證信
function api_resendmail(email)
{
    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": "resendmail",        
        "email":email        
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
             if (data != null && data.code == 200) {
                if(data.data.message=='')
                {

                    sweetAlert("OK", "確認信補發成功", "success");  
                    $('#email').val('');
                    
                }
                else
                {
                    sweetAlert("Oops...", data.data.message, "error");  
                    $('#email').val('');                      
                    return false;                                                
                }                
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });    

}

function api_resendcode(mobile)
{
    $('#btnResend').attr('disabled',true);

    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": "reSendActivedCode",        
        "mobileNo":mobile        
    });
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }            
             if (data != null && data.code == 200) {
                if(data.data.message=='')
                {

                }
                else
                {
                    swal({
                              title: "Info",
                              text: data.data.message,
                              type: "info",                                            
                              confirmButtonText: "OK",
                              closeOnConfirm: false
                            },
                            function(){                                
                                 window.location.href="member.html";
                            });    
                                    
                    return false;                                                
                }                
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });    
}

//登出
function logout() {
    sessionStorage.clear();
    window.location.href=loginURL;
}

//消費金查詢
function api_consumeget(mempkey, issum) {

    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {
        "act": "Consume_get",
        "uid": mempkey
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));        
    }
    
    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            if (data != null && data.code == 200) {
                var obj=jQuery.parseJSON(JSON.stringify(data.data.result));  
                if(data.data.message=='')
                {
                    if(issum==true)
                    {
                        var tot=0; 
                        $.each(obj,function(index, el) {
                            if(moment(el.tradeDate).isAfter(moment(loadSessionStorage("expiretime")).subtract(370, 'days')) && moment(el.tradeDate).isBefore(moment(loadSessionStorage("expiretime"))))
                            {
                                tot=tot+isnullint(el.amount);    
                            }
                        }); 
                         $('#lbltotal').html(tot);                      
                    }
                    else
                    {
                        var ll='<tr><th>消費日期</th><th>門店</th><th>消費金額</th></tr>';
                         $.each(obj,function(index, el) {
                             //alert("el.tradeDate:" + el.tradeDate.toString());
                             //alert("el.expiredate:" + loadSessionStorage("expiretime")); 
                             //alert("moment.tradeDate:" + moment(el.tradeDate));
                             //alert("moment.xxdate:" + moment(loadSessionStorage("expiretime")).subtract(367, 'days'));
                             //alert("new" + moment(loadSessionStorage("expiretime"), "YYYY/MM/DD").subtract(367, 'days'));
                             //alert("el.1:" + moment(el.tradeDate).isAfter(moment(loadSessionStorage("expiretime")).subtract(367, 'days')));
                             //alert("el.2:" + moment(el.tradeDate).isBefore(moment(loadSessionStorage("expiretime"))));                  
                        if(moment(el.tradeDate).isAfter(moment(loadSessionStorage("expiretime")).subtract(367, 'days')) && moment(el.tradeDate).isBefore(moment(loadSessionStorage("expiretime"))))
                            {
                                ll=ll+'<tr><td>'+el.tradeDate+'</td><td>'+el.storeName+'</td><td>'+el.amount+'</td></tr>';
                            }
                        }); 
                        $('#cList').html(ll);
                    }
                }                            
            }        
        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}

//卷包
function listCampaign(root) {

    var url = api_url + "/api/campaign";
    var post_data = $.extend(getBasePostData(), {
        "act": "listwithsn",
        "uid":loadSessionStorage("user_id")
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
    }

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {


            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }

            $('#'+root).html('');
            var result = data.data.result;
            var html = "";//for clear
            $.each(result, function(index, value) {                                         
                if (value.txtIsUse == '未使用') {
                    if (moment(value.cpbStartDate).isBefore(moment())) {
                            html += '<div><a class="ticket" href="coupon-QR.html?cpbpKey=' + value.cpbpKey + '"><div class="lt-Title"><p>' + value.cppName + '</p></div>';
                            html += '<div class="notice"><h3>注意事項</h3><ul>';
                            html += '<li>' + value.cppRules + '</li>';
                            html += '<li>使用期限至' + value.cpbEndDate + '止</li>';
                            html += '</ul></div>';
                            html += '<div class="productImg"><img src="img/Coupon/' + value.cppPic1 + '" alt="" height="211" width="211"></div></a></div>';
                        }
                    }                
            });
            $.each(result, function(index, value) {                 
                if (value.txtIsUse=='已使用' && moment(value.cpbStartDate).isBefore(moment(value.cpbStartDate).add(366,'d'),'day')) 
                {
                    html +='<div><div class="ticket" href="#"><div class="lt-Title"><p>'+value.cppName+'(已使用)</p></div>';
                    html +='<div class="notice"><h3>注意事項</h3><ul>';
                    html +='<li>'+value.cppRules+'</li>';
                    html +='<li>使用期限至'+value.cpbEndDate+'止</li>';                                                        
                    html +='</ul></div>';
                    html +='<div class="productImg"><img src="img/Coupon/'+value.cppPic1+'" alt="" height="211" width="211"></div></div></div>';                    
                }
            });
            $.each(result, function(index, value) {                 
                if (value.txtIsUse=='已過期' && moment(value.cpbStartDate).isBefore(moment(value.cpbStartDate).add(366,'d'),'day')) 
                {
                    html +='<div><div class="ticket" href="#"><div class="lt-Title"><p>'+value.cppName+'(已過期)</p></div>';
                    html +='<div class="notice"><h3>注意事項</h3><ul>';
                    html +='<li>'+value.cppRules+'</li>';
                    html +='<li>使用期限至'+value.cpbEndDate+'止</li>';                                                        
                    html +='</ul></div>';
                    html +='<div class="productImg"><img src="img/Coupon/'+value.cppPic1+'" alt="" height="211" width="211"></div></div></div>';                    
                }
                // root.append(html);                              
            });
             $('#'+root).html(html); 
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return false;
        },
        complete: function(jqXHR, textStatus) {}
    });
}


function refreshBarcode(cpbpKey, barCodeObj, canvasObj, callback) {
    var url = api_url + "/api/campaign";
    var post_data = $.extend(getBasePostData(), {
        "act": "refresh",
        "cpbpKey": cpbpKey
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
    }

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {
            barCodeObj.html("取得條碼中...");
            canvasObj.empty();
        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            var result = data.data == null ? null : data.data.result;
            callback(result);
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return null;
        },
        complete: function(jqXHR, textStatus) {}
    });

}

function getCampaign(cpbpKey, callback) {
    var url = api_url + "/api/campaign";
    var post_data = $.extend(getBasePostData(), {
        "act": "detail",
        "cpbpKey": cpbpKey
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
    }

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            var result = data.data == null ? null : data.data.result;
            callback(result);
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return null;
        },
        complete: function(jqXHR, textStatus) {}
    });

}

function activeEmail(EMail,pkey)
{
    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {
        "act": "ActivedCodeVerifyByE",
        "mmacode": pkey,
        "email":EMail
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
    }

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            if (data != null && data.code == 200) {
                if(data.data.message=='')
                {
                swal({
                      title: "Great!",
                      text: "啟動成功，感謝您的配合~",
                      type: "success",                                            
                      confirmButtonText: "OK",
                      closeOnConfirm: false
                    },
                    function(){
                        window.location.href="index.html";
                    });     
                }
                else
                {
                    sweetAlert("Oops...","啟動失敗："+data.data.message, "error");  
                }
            }
            else
            {
                window.location.href="index.html";
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return null;
        },
        complete: function(jqXHR, textStatus) {}
    });
}

function resendMail(email)
{
    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {
        "act": "reSendVerMail",
        "email": email       
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
    }

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function(jqXHR, settings) {

        },
        success: function(data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            if (data != null && data.code == 200) {
                if(data.data.message=='')
                {
                swal({
                      title: "Great!",
                      text: "發送成功，請至您的信箱查看啟動信",
                      type: "success",                                            
                      confirmButtonText: "OK",
                      closeOnConfirm: false
                    },
                    function(){
                        window.location.href="index.html";
                    });     
                }
                else
                {
                    window.location.href="index.html";  
                }
            }
            else
            {
                window.location.href="index.html";
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return null;
        },
        complete: function(jqXHR, textStatus) {}
    });
}
