document.write('<script type=\"text/javascript\" src=\"WPJS/sweetalert.min.js\"></script>');
document.write('<link rel=\"stylesheet\" type=\"text/css\" href=\"WPJS/sweetalert.css\">');


// var api_url = "http://localhost:18343";
var api_url = "https://wma.wowprime.com";
var app_id = "1";
var app_secret = "E6798280-2FDA-49E3-8E5E-47EE720E586C";
var careerno = "107";
var debug_mode = false;
var CPMPKey='71F7EA18-069C-4525-B85E-A30CD183E921';
var IP='';
var homeurl='https://www.tasty.com.tw'


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