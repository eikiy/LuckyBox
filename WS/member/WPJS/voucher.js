document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');

function voucher_list(root)
{
    var post_data = $.extend(getBasePostData(), {
        "act": "listwithsn",
        "uid": loadSessionStorage('user_id'),
        "mobileno": loadSessionStorage('mobile')
    });

    $.ajax({
        url: "./voucher.aspx",
        method: "POST",
        dataType: "json",
        data: post_data,
        beforeSend: function (jqXHR, settings) {

        },
        success: function (data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            if (data != null && data.code == 200) {
                render_voucher_list_item(root, data);
            }
            else {
                sweetAlert("Oops...", data.data.message, "error");
                return false;
            }
        },
        error: function (jqXHR, textStatus, errorThrown) { },
        complete: function (jqXHR, textStatus) { }
    });
}

function render_voucher_list_item(root, data)
{
    $('#' + root).html('');
    var result = data.data.result;
    var html = "";
    $.each(result, function (index, value) {
        if (value.txtIsUse == '未使用') {
            if (moment(value.d_effect, "YYYY/MM/DD").isBefore(moment())) {
                html += '<div><a class="ticket" href="coupon-QR.html?cpbpKey=' + value.vocr_id + '"><div class="lt-Title"><p>' + value.vcdf_name + '</p></div>';
                html += '<div class="notice"><h3>注意事項</h3><ul>';
                html += '<li>' + value.vcdf_rule1 + '</li>';
                if (typeof value.vcdf_rule2 != "undefined" && $.trim(value.vcdf_rule2).length)
                    html += '<li>' + value.vcdf_rule2 + '</li>';
                html += '<li>使用期限至' + value.d_expire + '止</li>';
                html += '</ul></div>';
                html += '<div class="productImg"><img src="' + value.vcdf_pic1 + '" alt="" height="211" width="211"></div></a></div>';
            }
        }
    });
    $.each(result, function (index, value) {
        if (value.txtIsUse == '已使用' && moment(value.d_effect, "YYYY/MM/DD").isBefore(moment(value.d_effect, "YYYY/MM/DD").add(366, 'd'), 'day')) {
            html += '<div><div class="ticket" href="#"><div class="lt-Title"><p>' + value.vcdf_name + '(已使用)</p></div>';
            html += '<div class="notice"><h3>注意事項</h3><ul>';
            html += '<li>' + value.vcdf_rule1 + '</li>';
            if (typeof value.vcdf_rule2 != "undefined" && $.trim(value.vcdf_rule2).length)
                html += '<li>' + value.vcdf_rule2 + '</li>';
            html += '<li>使用期限至' + value.d_expire + '止</li>';
            html += '</ul></div>';
            html += '<div class="productImg"><img src="' + value.vcdf_pic1 + '" alt="" height="211" width="211"></div></div></div>';
        }
    });
    $.each(result, function (index, value) {
        if (value.txtIsUse == '已過期' && moment(value.d_effect, "YYYY/MM/DD").isBefore(moment(value.d_effect, "YYYY/MM/DD").add(366, 'd'), 'day')) {
            html += '<div><div class="ticket" href="#"><div class="lt-Title"><p>' + value.vcdf_name + '(已過期)</p></div>';
            html += '<div class="notice"><h3>注意事項</h3><ul>';
            html += '<li>' + value.vcdf_rule1 + '</li>';
            if (typeof value.vcdf_rule2 != "undefined" && $.trim(value.vcdf_rule2).length)
                html += '<li>' + value.vcdf_rule2 + '</li>';
            html += '<li>使用期限至' + value.d_expire + '止</li>';
            html += '</ul></div>';
            html += '<div class="productImg"><img src="' + value.vcdf_pic1 + '" alt="" height="211" width="211"></div></div></div>';
        }
    });
    $.each(result, function (index, value) {
        if (value.txtIsUse == '已停用' && moment(value.d_effect, "YYYY/MM/DD").isBefore(moment(value.d_effect, "YYYY/MM/DD").add(366, 'd'), 'day')) {
            html += '<div><div class="ticket" href="#"><div class="lt-Title"><p>' + value.vcdf_name + '(已停用)</p></div>';
            html += '<div class="notice"><h3>注意事項</h3><ul>';
            html += '<li>' + value.vcdf_rule1 + '</li>';
            if (typeof value.vcdf_rule2 != "undefined" && $.trim(value.vcdf_rule2).length)
                html += '<li>' + value.vcdf_rule2 + '</li>';
            html += '<li>使用期限至' + value.d_expire + '止</li>';
            html += '</ul></div>';
            html += '<div class="productImg"><img src="' + value.vcdf_pic1 + '" alt="" height="211" width="211"></div></div></div>';
        }
    });
    $('#' + root).html(html); 
}

function voucher_detail(vocr_id, callback)
{
    var post_data = $.extend(getBasePostData(), {
        "act": "detail",
        "uid": loadSessionStorage('user_id'),
        "mobileno": loadSessionStorage('mobile'),
        "vocr_id": vocr_id
    });

    $.ajax({
        url: "./voucher.aspx",
        method: "POST",
        dataType: "json",
        data: post_data,
        beforeSend: function (jqXHR, settings) {

        },
        success: function (data, textStatus, jqXHR) {
            if (debug_mode) {
                console.log("success data=" + JSON.stringify(data));
            }
            if (data != null && data.code == 200) {
                callback(data.data.result[0]);
            }
            else {
                sweetAlert("Oops...", data.data.message, "error");
                return false;
            }
        },
        error: function (jqXHR, textStatus, errorThrown) { },
        complete: function (jqXHR, textStatus) { }
    });
}

