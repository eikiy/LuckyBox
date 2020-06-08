document.write('<script type=\"text/javascript\" src=\"WPJS/base.js\"></script>');


function api_couponQuery(couponcode)
{

    $('#gvCoupon').html('');

    var url = api_url + "/api/member";
    var post_data = $.extend(getBasePostData(), {       
        "act": "couponQuery",        
        "couponcode":couponcode        
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
                    var cc = '<table cellspacing="1" cellpadding="5" bgcolor="#CCCCCC" style="width:100%" class="table3_1"><tbody><tr style="background-color:#CCCCCC;"><th scope="col">禮卷編號</th><th scope="col">面額</th><th scope="col">銷售日期</th><th scope="col">禮券狀態</th><th scope="col">保證截止</th><th scope="col">保證銀行</th>';

                    $.each(data.data.result,(function(index, el) {
                        
                        cc=cc.concat('</tr><tr style="background-color:White;" ><td>',el.cuponNo,'</td><td>',el.price,'</td><td>',el.salesDate,'</td><td>',el.status,'</td><td>',el.retDate,'</td><td>',el.bankName,'</td></tr>');
                    }));
                    cc=cc.concat('</tbody></table>');
                    $('#gvCoupon').html(cc);
                    
                    $('#txtCode').val('');                    
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
}