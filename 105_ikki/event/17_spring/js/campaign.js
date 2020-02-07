var api_url = "http://wma.wowprime.com";
var app_id = "1";
var app_secret = "Ke2%2^k*";
var careerno = "105";
var CPMPKey = "D3B7A779-89A2-45A6-9B99-2B43B75DADD8";
var debug_mode = false;

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

function lazyRedirect(url, timeout ) {
    timeout = typeof timeout !== 'undefined' ? timeout: 2000;
    setTimeout(function() {
        window.location.href=url;
    }, timeout);
}


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

function logout() {
    sessionStorage.clear();
    window.location.href="login.html";
}


function api_login(email, password, auto_play) {

    var url = api_url + "/api/member";
    var post_data = $.extend(getBasePostData(), {
        "act": "login",
        "email": email,
        "pwd": CryptoJS.SHA1(password).toString()
    });
    if (debug_mode) {
        console.log(url);
        console.log(JSON.stringify(post_data));
        console.log("auto_play->" + auto_play);
    }
    if(auto_play)
      {
        ga('send', 'event', 'IKKI春促', 'click', 'IKKI春促登入');
      }
      else
      {
       ga('send', 'event', 'IKKI春促', 'click', 'IKKI春促查詢'); 
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
                    case 1000:
                        saveSessionStorage("user_id", data.data.result.uid);
                        saveSessionStorage("user_name", data.data.result.name);
                        saveSessionStorage("access_token", data.data.result.access_token);
                        if (auto_play == true) {
                            api_chkCampaign();
                        } else {
                             window.location.href="prize-list.html";
                            return false;
                        }
                        break;
                    default:
                        alert("帳號或密碼錯誤!");
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


function fb_afterlogin(uid,uname,uemail,ugender,auto_play)
{    
    if(uid=='')
    {
        return false;
    }
    var txtgender='';
    if(ugender!='')
    {
        switch(ugender)
        {
            case 'Male':
            txtgender='M';
            break;
            case 'FeMale':
            txtgender='F';
            break;
        }
    }
    var url = api_url + "/api/member";
     var post_data = $.extend(getBasePostData(), {
        "act": "member3rd",
        "M3MUID": uid,
        "email": uemail,
        "M3MName": uname,
        "gender": ugender,
        "M3MFrom": 'FB'        
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
                switch (data.data.status) {
                    case 1000:
                        saveSessionStorage("user_id", data.data.result.uid);
                        saveSessionStorage("user_name", data.data.result.name);
                        saveSessionStorage("access_token", data.data.result.access_token);
                        if (auto_play == true) {
                            api_chkCampaign();
                        } else {
                             window.location.href="prize-list.html";
                            return false;
                        }
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


function api_chkCampaign() {

    var url = api_url + "/api/campaign";
    var post_data = $.extend(getBasePostData(), {
        "act": "check"
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
                switch (data.data.status) {
                    case 200:
                        window.location.href="loading.html";
                        return true;
                    default:
                        alert(data.data.message);
                        window.location.href="prize-list.html";
                        return false;
                }
            }

        },
        error: function(jqXHR, textStatus, errorThrown) {
            return false;
        },
        complete: function(jqXHR, textStatus) {}
    });
}

function playCampaign() {
    var url = api_url + "/api/campaign";
    var post_data = $.extend(getBasePostData(), {
        "act": "play"
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
            if (data != null) {
                switch (data.data.status) {
                    case 1000:
                        lazyRedirect("prize.html?cpbpKey=" + data.data.result.cpbpKey);
                        return true;
                    case 101:
                        lazyRedirect("prize-list.html");
                        return true;
                    default:
                        logout();
                        return false;
                }
            }
            logout();
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return false;
        },
        complete: function(jqXHR, textStatus) {}
    });
}



function listCampaign(root, callback) {

    var url = api_url + "/api/campaign";
    var post_data = $.extend(getBasePostData(), {
        "act": "list"
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

            root.empty();
            var result = data.data.result;
            var html = "";
            $.each(result, function(index, value) {
                html = ""; //for clear
                if (value.isUse) {
                    html += "<tr>";
                    html += "<td class='date'><i class='fa fa-check-square-o' aria-hidden='true'></i>" + value.inserttime + "</td>";
                    html += "<td class='title'>" + value.cppName + "</td>";
                    html += "<td class='status'>已兌換</td>";
                    html += "</tr>";

                } else {
                    html += "<tr>";
                    html += "<td class='date'><i class='fa fa-square-o' aria-hidden='true'></i>" + value.inserttime + "</td>";
                    html += "<td class='title'><a href='prize.html?cpbpKey=" + value.cpbpKey + "''>" + value.cppName + "</a></td>";
                    html += "<td class='status'></td>";
                    html += "</tr>";
                }
                root.append(html);
                callback();
            });
        },
        error: function(jqXHR, textStatus, errorThrown) {
            return false;
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