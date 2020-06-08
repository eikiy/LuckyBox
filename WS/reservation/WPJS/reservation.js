//document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');

var cpb = getUrlParameter('bc');
$(function () {
    if (debug_mode == false) {
        if (cpb == '' || cpb == undefined) {
            window.location.href = homeurl;
            return;
        }
    }
    getBook(cpb);

})

function getBook(pkey)
{
    var url = api_url + "/api/Booking";
    var post_data = $.extend(getBasePostData(), {
        "act": "BookingInfobyKeyu_get",
        "tttpkey": pkey
    });

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function (jqXHR, settings) {

        },
        success: function (data, textStatus, jqXHR) {           
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            var dgData = JSON.parse(JSON.stringify(data["data"]["result"]));
            var store = '';
            $.each(dgData, function (i, value) {
                store = value['storeno'];
                $('#lblCustinfo').html(value['tttcname'] + ' ' + value['tttgender']);
                $('#lblRdate').html(value['tradedate'].substr(5, 5) + ' ' + getWeekDay(value['tradedate']));
                $('#lblRTime').html(value['starthour']);
                if (value['tttqtychild'] != '')
                {
                    $('#lblRCusts').html('大人' + value['tttqtyadult'] + '位,兒童' + value['tttqtychild'] + '位')
                }
                else
                {
                    $('#lblRCusts').html('大人' + value['tttqtyadult'] + '位')
                }
                if(value['isconfirm'])
                {
                    $('#btnconfirm').hide();
                }
                if (value['iscancel']) {
                    $('#lblBookinfo').html('您的訂位已經取消');
                    $('#btncancel').hide();
                }
                else
                {
                    $('#lblBookinfo').html('感謝選擇我們為您服務，以下是您的訂位資訊：');
                }
            })

            getStore(store);

        },
        error: function (jqXHR, textStatus, errorThrown) {
            sweetAlert("Oops..", "服務發生異常，請稍後再試", "error");
        },
        complete: function (jqXHR, textStatus) { }
    });
}

function getStore(storeno) {
    var url = api_url + "/api/WOWAPP";
    var post_data = $.extend(getBasePostData(), {
        "act": "getStore",
        "storeno": storeno
    });

    $.ajax({
        url: url,
        method: "POST",
        crossDomain: true,
        dataType: "json",
        data: post_data,
        beforeSend: function (jqXHR, settings) {

        },
        success: function (data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            var dgData = JSON.parse(JSON.stringify(data["data"]["result"]));

            $.each(dgData, function (i, value) {

                $('#lblstorename').html(value['storename']);
                $('#lbltel').html(value['tel']);
                $('#lbladdress').html(value['address']);
                $('#lblparkinginfo').html('停車資訊：' + value['parking_info']);
                $('#googleMap').attr('src', 'https://maps.google.com.tw/maps?f=q&hl=zh-TW&geocode=&q='+value['address']+'&z=16&output=embed&t=p');
               
            })

        },
        error: function (jqXHR, textStatus, errorThrown) {
            sweetAlert("Oops..", "服務發生異常，請稍後再試", "error");
        },
        complete: function (jqXHR, textStatus) { }
    });
}

function doConfirm() {
    var post_data = $.extend(getBasePostData(), {
        "act": "BookingConfirm",
        "tttpkey": cpb,
        "isconfirm": 1,
        "Insertman":'cust'
    });
    $.ajax({
        url: api_url + "/API/Booking/",
        type: 'post',
        data: post_data,
        dataType: 'json',        
        success: function (data) {
            if (data["data"]["result"] == '') {

                sweetAlert("Great!!", "感謝您，確認完成", "success");
                $('#btnconfirm').hide();
            }
            else {
                sweetAlert("Oops..", data["data"]["result"], "error");
            }
        },
        error: function (xhr) {
            sweetAlert("Oops..", "服務發生異常，請稍後再試", "error");
        }

    })
};


function doCancel() {
    var post_data = $.extend(getBasePostData(), {
        "act": "BookingCancel",
        "tttpkey": cpb,
        "iscancel": 1,
        "canceltype": 1,
        "Insertman": 'cust'
    });

    swal({
        title: 'Are you sure?',
        text: "您確定要取消訂位嗎？",
        type: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes'
    }).then(function () {
        $.ajax({
            url: api_url + "/API/Booking/",
            type: 'post',
            dataType: 'json',
            data: post_data,
            success: function (data) {
                if (data["data"]["result"] == '') {
                    $('#lblBookinfo').html('您的訂位已經取消');
                    $('#btncancel').hide();
                    sweetAlert("Thank You", "您的訂位已取消，期待您再度光臨", "success");

                }
                else {
                    sweetAlert("Oops..", data["data"]["result"], "error");
                }
            },
            error: function (xhr) {
                sweetAlert("Oops..", "發生錯誤，請重新登入試試！", "error");
            }
        })
    })
};



    


//回傳星期幾
function getWeekDay(date)
{    
    var dd = new Date(date).getDay()
    switch(dd)
    {
        case 0:
            return '周日'
            break;
        case 1:
            return '周一'
            break;
        case 2:
            return '周二'
            break;
        case 3:
            return '周三'
            break;
        case 4:
            return '周四'
            break;
        case 5:
            return '周五'
            break;
        case 6:
            return '周六'
            break;
    }
}