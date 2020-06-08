document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');

var voucher_url = "http://203.73.178.141:8080/cct/cctws/API/Voucher";
//var voucher_url = "http://cct.wowprime.com/cct/cctws/API/Voucher";
var voucher_token = "66666666666666666666666666666666666";

var voucher_list_test = {
    "code": 200,
    "error": "",
    "data": {
        "status": 200,
        "message": "",
        "result": [
            {
                "vocr_id": "175c135b-abde-4c14-95af-a9dc2c295b0e",
                "vcdf_id": "VCDF000012",
                "vocr_barcode": "e_175c135b-abde-4c14-95af-a9dc2c295b0e",
                "pprj_id": "1938",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "VVIP續會滿額禮【主餐升級 $1690套餐】",
                "vcdf_rule1": "● 消費套餐兌換升等禮乙份，本券限用乙次後失效。\r\n● 點餐時請主動出示本券並告知服務人員兌換。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 升等$1690主餐乙客以門店實際菜色為主。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000007.jpg"
            },
            {
                "vocr_id": "34266a96-e347-4d0a-971a-ac694e4559d6",
                "vcdf_id": "VCDF000019",
                "vocr_barcode": "e_34266a96-e347-4d0a-971a-ac694e4559d6",
                "pprj_id": "1932",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "白金婚慶設桌",
                "vcdf_rule1": "1年限用1次",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://wma.wowprime.com/Attached/104/Birth.jpg"
            },
            {
                "vocr_id": "3d3fff0b-e63d-4b3f-8fc9-aa5f8defb0a8",
                "vcdf_id": "VCDF000020",
                "vocr_barcode": "e_3d3fff0b-e63d-4b3f-8fc9-aa5f8defb0a8",
                "pprj_id": "1931",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "鑽石婚慶設桌+玫瑰花",
                "vcdf_rule1": "1年限用1次",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://wma.wowprime.com/Attached/104/Birth.jpg"
            },
            {
                "vocr_id": "425cb7b4-1a2a-4e65-b637-b977915a8dad",
                "vcdf_id": "VCDF000011",
                "vocr_barcode": "e_425cb7b4-1a2a-4e65-b637-b977915a8dad",
                "pprj_id": "1938",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "鑽石續會滿額禮【主餐升級 $1690套餐】",
                "vcdf_rule1": "● 消費套餐兌換升等禮乙份，本券限用乙次後失效。\r\n● 點餐時請主動出示本券並告知服務人員兌換。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 升等$1690主餐乙客以門店實際菜色為主。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000007.jpg"
            },
            {
                "vocr_id": "6ce61b02-051f-4f7b-b83e-6442c63dc449",
                "vcdf_id": "VCDF000015",
                "vocr_barcode": "e_6ce61b02-051f-4f7b-b83e-6442c63dc449",
                "pprj_id": "1930,1944,1945",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "菁英壽星8折 生日蛋糕",
                "vcdf_rule1": "● 點餐時出示本券並核對證件，消費套餐尊享【8折+生日蛋糕】乙客款待。\r\n● 結帳時請主動出示並掃瞄QRCODE即享優惠。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 每券限用乙次後失效，10%服務費另計。\r\n● 本券不得再與折扣優惠併用，擇一優惠使用。\r\n● 使用期限至生日+30天止。\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000008.jpg"
            },
            {
                "vocr_id": "80a441c4-d4ef-48fa-8d21-2e5c94c036f0",
                "vcdf_id": "VCDF000014",
                "vocr_barcode": "e_80a441c4-d4ef-48fa-8d21-2e5c94c036f0",
                "pprj_id": "1952",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "VVIP滿額3萬禮【招待王品牛排套餐乙客】",
                "vcdf_rule1": "● 消費滿額3萬招待王品牛排套餐乙客乙份，本券限用乙次後失效。\r\n● 點餐時請主動出示本券並告知服務人員兌換。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 以門店實際菜色為主。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/coupon/128-TargetAmountGift.jpg"
            },
            {
                "vocr_id": "8d922f64-e54a-43ca-bc32-7f8be23a8a7f",
                "vcdf_id": "VCDF000007",
                "vocr_barcode": "e_8d922f64-e54a-43ca-bc32-7f8be23a8a7f",
                "pprj_id": "1928",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "入會迎賓禮",
                "vcdf_rule1": "● 憑券消費套餐致贈【海味雙饗】乙份。\r\n● 點餐時請出示本券並告知服務人員兌換。\r\n● 限本人使用，出示兌換券截圖者恕無法使用。\r\n● 本券限用乙次。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 使用期限至2020/12/31止。\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000001.jpg"
            },
            {
                "vocr_id": "a96904ce-6fb2-4df7-a464-c3cf9128b7cc",
                "vcdf_id": "VCDF000016",
                "vocr_barcode": "e_a96904ce-6fb2-4df7-a464-c3cf9128b7cc",
                "pprj_id": "1930,1944,1945",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "白金壽星8折 生日蛋糕",
                "vcdf_rule1": "● 點餐時出示本券並核對證件，消費套餐尊享【8折+生日蛋糕】乙客款待。\r\n● 結帳時請主動出示並掃瞄QRCODE即享優惠。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 每券限用乙次後失效，10%服務費另計。\r\n● 本券不得再與折扣優惠併用，擇一優惠使用。\r\n● 使用期限至生日+30天止。\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000002.jpg"
            },
            {
                "vocr_id": "b072d295-4034-40be-9140-7910b5f461a7",
                "vcdf_id": "VCDF000013",
                "vocr_barcode": "e_b072d295-4034-40be-9140-7910b5f461a7",
                "pprj_id": "1952",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "鑽石滿額3萬禮【招待王品牛排套餐乙客】",
                "vcdf_rule1": "● 消費滿額3萬招待王品牛排套餐乙客乙份，本券限用乙次後失效。\r\n● 點餐時請主動出示本券並告知服務人員兌換。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 以門店實際菜色為主。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/coupon/128-TargetAmountGift.jpg"
            },
            {
                "vocr_id": "c2d7bc53-6c08-4ed6-a377-960abd9dc8be",
                "vcdf_id": "VCDF000010",
                "vocr_barcode": "e_c2d7bc53-6c08-4ed6-a377-960abd9dc8be",
                "pprj_id": "1938",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "白金續會滿額禮【主餐升級 $1690套餐】",
                "vcdf_rule1": "● 消費套餐兌換升等禮乙份，本券限用乙次後失效。\r\n● 點餐時請主動出示本券並告知服務人員兌換。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 升等$1690主餐乙客以門店實際菜色為主。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000007.jpg"
            },
            {
                "vocr_id": "ce96d539-ad78-4e6e-aefa-a28a120af5be",
                "vcdf_id": "VCDF000009",
                "vocr_barcode": "e_ce96d539-ad78-4e6e-aefa-a28a120af5be",
                "pprj_id": "1936,1937",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "鑽石升等禮2選1",
                "vcdf_rule1": "● 憑券消費套餐致贈【主餐升級券】或【精選禮品】乙份。\r\n● 點餐時請出示本券並告知服務人員兌換。\r\n● 限本人使用，出示兌換券截圖者恕無法使用。\r\n● 本券限用乙次。\r\n● 禮品隨機贈送，圖片僅供參考，以門市實物為準。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000005.jpg"
            },
            {
                "vocr_id": "dc9d87a5-db35-4d4d-9c22-8385ad2ee8df",
                "vcdf_id": "VCDF000017",
                "vocr_barcode": "e_dc9d87a5-db35-4d4d-9c22-8385ad2ee8df",
                "pprj_id": "1930,1944,1945",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "鑽石壽星8折 生日蛋糕",
                "vcdf_rule1": "● 點餐時出示本券並核對證件，消費套餐尊享【8折+生日蛋糕】乙客款待。\r\n● 結帳時請主動出示並掃瞄QRCODE即享優惠。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 每券限用乙次後失效，10%服務費另計。\r\n● 本券不得再與折扣優惠併用，擇一優惠使用。\r\n● 使用期限至生日+30天止。\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000009.jpg"
            },
            {
                "vocr_id": "e492e743-493a-417a-976d-24d80551fda4",
                "vcdf_id": "VCDF000018",
                "vocr_barcode": "e_e492e743-493a-417a-976d-24d80551fda4",
                "pprj_id": "1933,1942,1943",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "VVIP壽星8折 生日蛋糕+VVIP專屬禮",
                "vcdf_rule1": "● 點餐時出示本券並核對證件，消費套餐尊享【壽星8折+生日蛋糕++VVIP專屬禮】乙客款待。\r\n● 結帳時請主動出示並掃瞄QRCODE即享優惠。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 每券限用乙次後失效，10%服務費另計。\r\n● 本券不得再與折扣優惠併用，擇一優惠使用。\r\n● 使用期限至生日+30天止。\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000003.jpg"
            },
            {
                "vocr_id": "f0261369-9204-4b40-997e-52cf9745a92c",
                "vcdf_id": "VCDF000008",
                "vocr_barcode": "e_f0261369-9204-4b40-997e-52cf9745a92c",
                "pprj_id": "1934,1935",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "白金升等禮2選1",
                "vcdf_rule1": "● 憑券消費套餐致贈【海味雙饗】或【栢司金禮品】乙份。\r\n● 點餐時請出示本券並告知服務人員兌換。\r\n● 限本人使用，出示兌換券截圖者恕無法使用。\r\n● 本券限用乙次。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000004.jpg"
            },
            {
                "vocr_id": "fa7b64de-d171-44ab-8503-c5ad61d3a909",
                "vcdf_id": "VCDF000021",
                "vocr_barcode": "e_fa7b64de-d171-44ab-8503-c5ad61d3a909",
                "pprj_id": "1931",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "VVIP婚慶設桌+玫瑰花",
                "vcdf_rule1": "1年限用1次",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://wma.wowprime.com/Attached/104/Birth.jpg"
            }
        ]
    }
};

var voucher_detail_test = {
    "code": 200,
    "error": "",
    "data": {
        "status": 200,
        "message": "",
        "result": [
            {
                "vocr_id": "175c135b-abde-4c14-95af-a9dc2c295b0e",
                "vcdf_id": "VCDF000012",
                "vocr_barcode": "e_175c135b-abde-4c14-95af-a9dc2c295b0e",
                "pprj_id": "1938",
                "vocr_status": "C1",
                "vocr_amt": "0.00",
                "d_vocr": "2019/08/30",
                "txtIsUse": "未使用",
                "d_use": null,
                "stor_id": "",
                "d_effect": "2019/08/29",
                "d_expire": "2019/09/30",
                "vcdf_name": "VVIP續會滿額禮【主餐升級 $1690套餐】",
                "vcdf_rule1": "● 消費套餐兌換升等禮乙份，本券限用乙次後失效。\r\n● 點餐時請主動出示本券並告知服務人員兌換。\r\n● 限本人使用，出示優惠券截圖者恕不享優惠。\r\n● 圖片僅供參考，以門市實物為準。\r\n● 升等$1690主餐乙客以門店實際菜色為主。\r\n● 發送日+1年(365天)\r\n",
                "vcdf_rule2": " ",
                "vcdf_pic1": "https://www.wangsteak.com.tw/member/img/Coupon/VCDF000007.jpg"
            }
        ]
    }
};

function voucher_list(root)
{
/*
    var post_data = $.extend(getBasePostData(), {
        "act": "listwithsn",
        "app_secret": voucher_token,
        "careerno": careerno,
        "uid": "1184548F-4709-42AC-9967-E5D8D2422AEA",
        "mobileno": "0978222251"
    });
*/
    var post_data = $.extend(getBasePostData(), {
        "act": "listwithsn",
        "app_secret": app_secret,
        "careerno": careerno,
        "uid": loadSessionStorage('user_id'),
        "mobileno": loadSessionStorage('mobile')
    });

    //render_voucher_list_item(root, voucher_list_test);

    $.ajax({
        url: voucher_url,
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
        "app_secret": voucher_token,
        "careerno": careerno,
        "uid": loadSessionStorage('user_id'),
        "mobileno": loadSessionStorage('mobile'),
        "vocr_id": vocr_id
    });

    //callback(voucher_detail_test.data.result[0]);

    $.ajax({
        url: voucher_url,
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

