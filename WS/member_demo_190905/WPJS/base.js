document.write('<script type=\"text/javascript\" src=\"WPJS/sweetalert.min.js\"></script>');
document.write('<link rel=\"stylesheet\" type=\"text/css\" href=\"WPJS/sweetalert.css\">');




// var api_url = "http://localhost:18343";
var api_url = "https://wma.wowprime.com";
var app_id = "1";
var app_secret = "85D2084F-7C4D-4A44-9519-A51F296FEB57";
var careerno = "103";
var debug_mode = false;
var CPMPKey='';
var IP='';
var gakey='UA-2488495-1';//GA用的Key

if (debug_mode == false) {
    var ishttps = 'https:' == document.location.protocol ? true : false;
    if (!ishttps) {
        var hostname = location.host;
        location.href = "https://" + hostname;
    }
}

var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = decodeURIComponent(window.location.search.substring(1)),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return sParameterName[1] === undefined ? true : sParameterName[1];
        }
    }
};


function saveSessionStorage(key, value) {    
    window.sessionStorage[key] = value;
}

function loadSessionStorage(key) {
    return window.sessionStorage[key];
}


function getBasePostData() {
    var post_data = {
        "careerno": careerno,
        "app_id": app_id,
        "app_secret": app_secret,
        "CPMPKey": CPMPKey
    };

    if (window.sessionStorage["user_id"] != null) {
        $.extend(post_data, {
            "uid": loadSessionStorage('user_id')
        });
    }
    return post_data;
}

//檢查是否為日期
function IsValidDate(d){
 var reg = /^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$/;
    var result = d.match(reg);
    if(result == null){return false};
    var dt = new Date(result[1],result[3]-1,result[4]);
    if(Number(dt.getFullYear())!=Number(result[1])){return false;}    
    if(Number(dt.getMonth())+1!=Number(result[3])){return false;}    
    if(Number(dt.getDate())!=Number(result[4])){return false;}
    var vdt=new Date();
    var current_year=vdt.getFullYear();
    if(current_year-parseInt(d.substr(0,4))>100)
    {
        return false;
    }    
 return true;
};

//產生guid
function guid() {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000)
          .toString(16)
          .substring(1);
    }
    return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
      s4() + '-' + s4() + s4() + s4();
}

//判斷如果是null或undefined時，轉為0
function isnullint(s) {    
    if(!s){
        return 0;
    }else{
       return s;
    }   
}

(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
})(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

ga('create', gakey, 'auto');
ga('send', 'pageview');