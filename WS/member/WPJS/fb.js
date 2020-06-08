document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');

var FBNewURL='apply-FormFb.html'; //新加入的FB會員，如需補足其他欄位資料要導過去的頁面
//appId      : '657273167815800',

window.fbAsyncInit = function() {
        FB.init({
          appId      :'1463826347012223',
          xfbml      : true,
          version    : 'v2.9'
        });
        FB.AppEvents.logPageView();
      };

      (function(d, s, id){
         var js, fjs = d.getElementsByTagName(s)[0];
         if (d.getElementById(id)) {return;}
         js = d.createElement(s); js.id = id;
         js.src = "//connect.facebook.net/en_US/sdk.js";
         fjs.parentNode.insertBefore(js, fjs);
       }(document, 'script', 'facebook-jssdk')

       );
function fb_login(gourl){
 
    FB.login(function(response) {
        if (response.authResponse) {                
            //console.log(response); // dump complete info
            access_token = response.authResponse.accessToken; //get access token
            user_id = response.authResponse.userID; //get FB UID
        FB.api('/me','GET',{"fields":"id,name,email,gender"}, function(response) {
           if (debug_mode) {
             console.log('Wellcome!'+response.id+'-'+response.name+'-'+response.email+'-'+response.gender);                
           }
            fb_afterlogin(response.id,response.name,response.email,response.gender,gourl);                          
        });          
        } else {
            //user hit cancel button
            console.log('您已取消了透過FB成為王品的會員');
            // window.location.href='application.html';   

        }
    }, {
        scope: 'public_profile,email'
    });
}

//處理FB登入之後的動作
function fb_afterlogin(uid,uname,uemail,ugender,tourl)
{    
    if(uid=='')
    {
        return false;
    }
    var txtgender='';
    if(ugender!='')
    {
        switch(ugender.toLowerCase())
        {
            case 'male':
            txtgender='M';
            break;
            case 'female':
            txtgender='F';
            break;
        }
    }

     $.getJSON("https://jsonip.com/?callback=?", function (data) {
            IP = data.ip;
        });


    var url = api_url + "/api/member2";
     var post_data = $.extend(getBasePostData(), {
        "act": "mem3rdlogin",
        "M3MUID": uid,
        "email": uemail,
        "M3MName": uname,
        "gender": txtgender,
        "M3MFrom": 'FB',
        "ip":IP
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
            if (data.data != null && data.code == 200) {

              switch(data.data.status)
              {
                case 200:

                saveSessionStorage("user_id", data.data.result.uid);
                saveSessionStorage("user_name", data.data.result.name);
                saveSessionStorage("access_token", data.data.result.access_token);
                saveSessionStorage("txtlv", data.data.result.txtlv);
                saveSessionStorage("lv", data.data.result.lv);
                saveSessionStorage("mobile", data.data.result.mobile);
                saveSessionStorage("memno", data.data.result.memno);
                saveSessionStorage("expiretime", data.data.result.expiretime);                        


                saveSessionStorage("M3MFrom", "FB");
                if(tourl!='')
                {
                  window.location.href=tourl;
                }
                else
                {
                  window.location.href='member.html';                
                }
                break;

                case 201:

                saveSessionStorage("m3muid", uid);
                saveSessionStorage("m3memail", uemail);
                saveSessionStorage("m3mname", uname);
                saveSessionStorage("m3mgender", ugender);
                saveSessionStorage("m3mfrom", 'FB');
                saveSessionStorage("uid", data.data.result);
                
                window.location.href=FBNewURL;
                break;
               

                 default:                     
                    alert("登入時發生錯誤!");
                    return;
                  break;

              }
                                        
            }
            else
            {
                alert("登入時發生錯誤!");
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {},
        complete: function(jqXHR, textStatus) {}
    });
    return false;
}


function fb_intodata(uname,pwd,ugender,birthday,marryday,mobile,isgetcareerad,isgetallcareerad)
{
     if(typeof(loadSessionStorage("m3muid"))=="undefined" || loadSessionStorage("m3muid")=='')
      {
          window.location.href="memLogin.html";
      }



    var url = api_url + "/api/member2";
    var post_data = $.extend(getBasePostData(), {       
        "act": "mem3rdudp",
        "uid":loadSessionStorage('uid'),
        "cname":uname,
        "gender":ugender,
        "pwd":pwd,
        "birthday":birthday,
        "merryday":marryday,
        "mobileNo":mobile,
        "isgetcareerad":isgetcareerad,
        "isgetallcareerad":isgetallcareerad,
        "M3MFrom":'FB',
        "email":loadSessionStorage('m3memail')
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
                      text: "感謝您的填寫，稍後請輸入手機驗證碼",
                      type: "success",                                            
                      confirmButtonText: "OK",
                      closeOnConfirm: false
                    },
                    function(){
                         saveSessionStorage("memp", data.data.result);
                         window.location.href="confirm.html";
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