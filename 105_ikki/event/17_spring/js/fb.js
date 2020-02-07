document.write("<link rel=\"stylesheet\" href=\"css/font-awesome.min.css\">");
document.write("<link rel=\"stylesheet\" href=\"css/bootstrap-social.css\">");


window.fbAsyncInit = function() {
        FB.init({
          appId      : '353084191754442',
          xfbml      : true,
          version    : 'v2.8'
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


    function fb_login(isPlay){
      if(isPlay)
      {
        ga('send', 'event', 'IKKI春促', 'click', 'IKKI春促FB登入');
      }
      else
      {
       ga('send', 'event', 'IKKI春促', 'click', 'IKKI春促FB查詢'); 
      }
        FB.login(function(response) {
            if (response.authResponse) {                
                //console.log(response); // dump complete info
                access_token = response.authResponse.accessToken; //get access token
                user_id = response.authResponse.userID; //get FB UID
            FB.api('/me','GET',{"fields":"id,name,email,gender"}, function(response) {
               if (debug_mode) {
                 console.log('Wellcome!'+response.id+'-'+response.name+'-'+response.email+'-'+response.gender);                
               }
                 fb_afterlogin(response.id,response.name,response.email,response.gender,isPlay);
          
            });          
            } else {
                //user hit cancel button
                console.log('User cancelled login or did not fully authorize.');

            }
        }, {
            scope: 'public_profile,email'
        });
    }

